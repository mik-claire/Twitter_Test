﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLib;

using CoreTweet;
using CoreTweet.Streaming;

namespace Twitter_Test
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();

            string apiKey = "9LQZDfaCSJR88d2HLkkXrBFz0";
            string apiKeySecret = "HzupFEw0SFaLA2U4NGIBW0BFXybVY3M7uTgS33x1nByiEmjnI7";
            if (string.IsNullOrEmpty(Properties.Settings.Default.AccessToken) &&
                string.IsNullOrEmpty(Properties.Settings.Default.AccessTokenSecret))
            {
                var sessions = OAuth.Authorize(apiKey, apiKeySecret);
                var url = sessions.AuthorizeUri;

                using (Form_InputPinCode f = new Form_InputPinCode(url.ToString()))
                {
                    DialogResult dr = f.ShowDialog();
                    if (dr != DialogResult.OK)
                    {
                        return;
                    }

                    string pin = f.PinCode;
                    var t = OAuth.GetTokens(sessions, pin);
                    this.tokens = t;
                    this.user = t.Account.VerifyCredentials();
                }

                return;
            }

            this.tokens = Tokens.Create(
                apiKey,
                apiKeySecret,
                Properties.Settings.Default.AccessToken,
                Properties.Settings.Default.AccessTokenSecret);
            this.user = this.tokens.Account.VerifyCredentials();
        }

        private MyClass util = new MyClass();

        private Tokens tokens;
        private User user;

        private void Form_Main_Load(object sender, EventArgs e)
        {
            if (this.tokens == null)
            {
                this.Close();
            }
            this.textBox_Input.Text = string.Empty;
            show(this.tokens);

            streaming(this.tokens);

            this.Text = "@" + this.user.ScreenName;
        }

        private void show(Tokens tokens)
        {
            showHomeTimeline(this.listView_Home);
            this.listView_Home.Items[this.listView_Home.Items.Count - 1].EnsureVisible();

            showMentionTimeline(this.listView_Mention);
            this.listView_Mention.Items[this.listView_Mention.Items.Count - 1].EnsureVisible();
        }

        private void showHomeTimeline(ListView lv)
        {
            try
            {
                var home = tokens.Statuses.HomeTimeline(count => 100);

                for (int i = home.Count - 1; i >= 0; i--)
                {
                    displayTimeline(this.listView_Home, home[i]);
                }
            }
            catch(Exception ex)
            {
                util.ShowExceptionMessageBox(ex.Message, ex.StackTrace);
                return;
            }
        }

        private void showMentionTimeline(ListView lv)
        {
            try
            {
                var mention = tokens.Statuses.MentionsTimeline(count => 100);

                for (int i = mention.Count - 1; i >= 0; i--)
                {
                    displayTimeline(this.listView_Mention, mention[i]);
                }
            }
            catch (Exception ex)
            {
                util.ShowExceptionMessageBox(ex.Message, ex.StackTrace);
                return;
            }
        }

        private delegate void delegateDispay(ListView lv, Status tweet);
        private void displayTimeline(ListView lv, Status tweet)
        {
            try
            {
                if (lv.InvokeRequired)
                {
                    delegateDispay d = new delegateDispay(displayTimeline);

                    this.Invoke(d, new object[] { lv, tweet });
                }
                else
                {
                    string[] msg = 
                    {
                        (tweet.RetweetedStatus != null ? tweet.RetweetedStatus : tweet).CreatedAt.LocalDateTime.ToString("yyyy/MM/dd(ddd) HH:mm:ss"),
                        (tweet.RetweetedStatus != null ? tweet.RetweetedStatus : tweet).User.ScreenName,
                        (tweet.RetweetedStatus != null ? tweet.RetweetedStatus : tweet).User.Name,
                        (tweet.RetweetedStatus != null ? tweet.RetweetedStatus : tweet).Text,
                        (tweet.RetweetedStatus != null ? tweet.RetweetedStatus : tweet).ToString()
                    };
                    ListViewItem item = new ListViewItem(msg);
                    item.Tag = tweet;

                    deleteOldTweet(lv);
                    lv.Items.Add(item);
                    lv.Items[lv.Items.Count - 1].EnsureVisible();
                }
                /*
                if (lvスクロールが一番下)
                {
                    lv.Items[lv.Items.Count - 1].EnsureVisible();
                }
                */
            }
            catch(Exception ex)
            {
                util.ShowExceptionMessageBox(ex.Message, ex.StackTrace);
            }
        }

        private void deleteOldTweet(ListView lv)
        {
            while (100 < lv.Items.Count)
            {
                lv.Items.RemoveAt(0);
            }
        }

        private List<string> getSourceNameAndUrl(string source)
        {
            List<string> sourceList = new List<string>();

            string[] ary = source.Split(new string[] { "<", ">" }, StringSplitOptions.RemoveEmptyEntries);

            sourceList.Add(ary[1]);
            sourceList.Add(ary[0].Split('"')[1]);

            return sourceList;
        }

        private void listView_Timeline_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = getFocusedListView();

            if (lv.SelectedItems.Count == 0)
            {
                this.webBrowser_Detail.DocumentText = string.Empty;
                return;
            }

            if (lv.SelectedItems.Count != 1)
            {
                return;
            }
            
            ListViewItem item = lv.SelectedItems[0];
            var tweet = (Status)item.Tag;

            Regex url = new Regex(@"s?https?://[-_.!~*'()a-zA-Z0-9;/?:@&=+$,%#]+", RegexOptions.IgnoreCase);
            Regex userId = new Regex(@"@([a-zA-Z0-9_]+)", RegexOptions.IgnoreCase);
            string context = url.Replace(item.SubItems[3].Text, "<a href=\"$&\">$&</a>");
            context = userId.Replace(context, "<a href=\"http://www.twitter.com/$1\">$&</a>");

            string retweeter = string.Empty;
            if (tweet.RetweetedStatus != null)
            {
                retweeter = string.Format(" retweeted by <a href=\"http://www.twitter.com/{0}\">@{0}</a> / {1}",
                    tweet.User.ScreenName,
                    tweet.User.Name);
            }

            string entities = string.Empty;
            if (tweet.ExtendedEntities != null)
            {
                foreach(var media in tweet.ExtendedEntities.Media)
                {
                    entities += string.Format(
@"<a href=""{0}"">
  <img border=""0"" src=""{0}"" width=""{1}"" height=""{2}"" alt=""{0}"">
</a>",
                        media.MediaUrl,
                        media.Sizes.Small.Width * (96 / (float)media.Sizes.Small.Width),
                        media.Sizes.Small.Height * (96 / (float)media.Sizes.Small.Width));
                }
            }

            if (tweet.InReplyToStatusId == null)
            {
                this.button_ShowTalk.Enabled = false;
            }
            else
            {
                this.button_ShowTalk.Enabled = true;
            }

            StringBuilder sb2 = new StringBuilder();
            sb2.Append("<font size=\"2\" face=\"Meiryo UI\">");
            sb2.Append(item.SubItems[0].Text);                                  // Date-Time
            sb2.AppendFormat(" via {0}<br>", tweet.Source);                     // via
            sb2.AppendFormat(
                "<a href=\"https://twitter.com/{0}\">@{0}</a> / {1}{2}<br>",
                item.SubItems[1].Text,                                          // user-ID
                item.SubItems[2].Text,                                          // user-Name
                retweeter);                                                     // retweeter-Name
            sb2.AppendFormat("{0}<br></font>", context.Replace("\n", "<br>"));  // context
            this.webBrowser_Detail.DocumentText = string.Format(
@"<html>
<head>
  <style type=""text/css"">
    <!--
    #icon {{ float: left; }}
    //-->
  </style>
</head>
<body>
  <div id=""icon"">
    <img border=""0"" src=""{0}"" width=""32"" height=""32"">
  </div>
  <div id=""context"">
    {1}
  </div>
  {2}
</body>
</html>",
                tweet.RetweetedStatus == null ? tweet.User.ProfileImageUrl : tweet.RetweetedStatus.User.ProfileImageUrl,
                sb2.ToString(),
                entities == string.Empty ? string.Empty : "<div>" + entities + "</div>");
            
            this.webBrowser_Detail.Document.Click -= new HtmlElementEventHandler(webBrowser_Detail_DocumentClick);
            this.webBrowser_Detail.Document.Click += new HtmlElementEventHandler(webBrowser_Detail_DocumentClick);
        }

        private ListView getFocusedListView()
        {
            if (this.tabControl_Timeline.SelectedTab.Text == this.tabPage_Home.Text)
            {
                return this.listView_Home;
            }
            else if (this.tabControl_Timeline.SelectedTab.Text == this.tabPage_Mention.Text)
            {
                return this.listView_Mention;
            }
            else
            {
                return null;
            }
        }

        private void button_Tweet_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.button_Tweet.Text == "Tweet")
                {
                    tweet(this.tokens, this.textBox_Input.Text, this.uploadFilePathList);
                    this.textBox_Input.Text = string.Empty;
                }
            }
            catch(Exception ex)
            {
                util.ShowExceptionMessageBox(ex.Message, ex.StackTrace);
            }
        }

        private void tweet(Tokens tokens, string context, List<string> uploadFiles)
        {
            var image = uploadFiles.Select(m => this.tokens.Media.Upload(media => m).MediaId);

            List<MediaUploadResult> results = new List<MediaUploadResult>();
            foreach (string filePath in uploadFiles)
            {
                MediaUploadResult result = tokens.Media.Upload(media: new FileInfo(filePath));
                results.Add(result);
            }

            var param = new Dictionary<string, object>();
            param.Add("status", context);
            if (0 < results.Count)
            {
                param.Add("media_ids", results.Select(x => x.MediaId));
            }

            if (this.status != null)
            {
                param.Add("in_reply_to_status_id", this.status.Id.ToString());
            }

            tokens.Statuses.Update(param);
            resetReply();
            resetAppend();
        }

        private void textBox_Input_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox_Input.Text.Trim() == string.Empty)
            {
                this.button_Tweet.Text = "Reload";
            }
            else
            {
                this.button_Tweet.Text = "Tweet";
            }

            if (this.afterTweet)
            {
                this.textBox_Input.Text = string.Empty;
                this.afterTweet = false;
            }

            string tmp = this.button_Tweet.Text;
            if (140 < this.textBox_Input.Text.Length)
            {
                this.button_Tweet.Text = "Over!!";
                this.button_Tweet.Enabled = false;
                return;
            }
            this.button_Tweet.Text = tmp;
            this.button_Tweet.Enabled = true;
        }

        private Status status = null;
        private void listView_Timeline_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView lv = getFocusedListView();

            // 左クリック判定
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            // フォーカス判定
            ListViewItem item = lv.FocusedItem;
            if (!lv.FocusedItem.Bounds.Contains(e.Location))
            {
                return;
            }

            this.status = ((Status)item.Tag).RetweetedStatus != null ?
                ((Status)item.Tag).RetweetedStatus : ((Status)item.Tag);
            string inReplyTo = string.Format(
@"{0}: 
{1}",
                this.status.User.ScreenName,
                this.status.Text.Substring(0, this.status.Text.IndexOfAny(new char[] { '\0', '\n' }) + 1 == 0 ?
                    this.status.Text.Length : this.status.Text.IndexOfAny(new char[] { '\0', '\n' }) + 1));
            this.label_InReplyTo.Text = inReplyTo;
            this.textBox_Input.Text =
                this.textBox_Input.Text.Insert(0, string.Format("@{0} ", this.status.User.ScreenName));
            this.button_ResetReply.Visible = true;
        }

        IDisposable disposable = null;
        private void streaming(Tokens tokens)
        {
            var homeStream = tokens.Streaming.UserAsObservable().Publish();
            homeStream.OfType<StatusMessage>().Subscribe(x => streamTL(x.Status));

            this.disposable = homeStream.Connect();
        }

        private void streamTL(Status tweet)
        {
            displayTimeline(this.listView_Home, tweet);
            
            if (tweet.InReplyToScreenName != null &&
                tweet.InReplyToScreenName == this.user.ScreenName)
            {
                displayTimeline(this.listView_Mention, tweet);
            }
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.tokens == null)
            {
                return;
            }

            try
            {
                Properties.Settings.Default.AccessToken = this.tokens.AccessToken;
                Properties.Settings.Default.AccessTokenSecret = this.tokens.AccessTokenSecret;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (this.disposable != null)
                {
                    this.disposable.Dispose();
                }
            }
        }

        private void button_ResetReply_Click(object sender, EventArgs e)
        {
            resetReply();
        }

        private void resetReply()
        {
            this.label_InReplyTo.Text = string.Empty;
            this.status = null;
            this.textBox_Input.Text = string.Empty;
            this.button_ResetReply.Visible = false;
        }

        private void resetAppend()
        {
            this.uploadFilePathList.Clear();
            setAppendFilesCount();
        }

        private void setAppendFilesCount()
        {
            this.label_AppendFilesCount.Text = string.Format("Files : {0}", this.uploadFilePathList.Count);
        }

        private void webBrowser_Detail_DocumentClick(object sender, HtmlElementEventArgs e)
        {
            HtmlElement clickedElement = webBrowser_Detail.Document.GetElementFromPoint(e.MousePosition);
            string link = null;
            if (clickedElement.TagName == "a" || clickedElement.TagName == "A")
            {
                link = clickedElement.GetAttribute("href");
            }
            else if (clickedElement.Parent != null)
            {
                if (clickedElement.Parent.TagName == "a" || clickedElement.Parent.TagName == "A")
                {
                    link = clickedElement.Parent.GetAttribute("href");
                }
            }

            if (link != null && link != "")
            {
                try
                {
                    System.Diagnostics.Process.Start(link);
                }
                catch
                {
                }
            }
        }

        private void webBrowser_Detail_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (e.Url.OriginalString != "about:blank")
            {
                e.Cancel = true;
            }
        }

        private bool afterTweet = false;
        private void textBox_Input_KeyDown(object sender, KeyEventArgs e)
        {
            //e.Handled = true;

            if (Control.ModifierKeys == Keys.Control &&
                e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (this.button_Tweet.Text == "Tweet")
                    {
                        tweet(this.tokens, this.textBox_Input.Text, this.uploadFilePathList);
                        this.textBox_Input.Text = string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    util.ShowExceptionMessageBox(ex.Message, ex.StackTrace);
                }

                this.afterTweet = true;
            }
        }

        List<string> uploadFilePathList = new List<string>();
        private void textBox_Input_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.None;
                return;
            }

            e.Effect = DragDropEffects.Copy;
        }
        
        private void textBox_Input_DragDrop(object sender, DragEventArgs e)
        {
            string filePath = ((string[])e.Data.GetData(DataFormats.FileDrop, false))[0];

            if (4 <= this.uploadFilePathList.Count)
            {
                MessageBox.Show("アップロードできる画像は4つまでです。",
                    "Error!!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            this.uploadFilePathList.Add(filePath);
            setAppendFilesCount();
        }

        private void label_AppendFilesCount_Click(object sender, EventArgs e)
        {
            resetAppend();
        }

        private void listView_Timeline_MouseClick(object sender, MouseEventArgs e)
        {
            ListView lv = getFocusedListView();

            // 右クリック判定
            if (e.Button != MouseButtons.Right)
            {
                return;
            }

            // フォーカス判定
            ListViewItem item = lv.FocusedItem;
            if (!lv.FocusedItem.Bounds.Contains(e.Location))
            {
                return;
            }

            Status tweet = getTweetFromId(this.tokens, item.SubItems[4].Text);
            if (tweet.RetweetedStatus != null)
            {
                tweet = tweet.RetweetedStatus;
            }

            ContextMenuStrip cMenu = new ContextMenuStrip();

            // RT
            ToolStripMenuItem menuItem_RT = new ToolStripMenuItem();
            // menuItem_RT.Text = (bool)tweet.IsRetweeted ? "RT解除" : "RT";
            menuItem_RT.Text = "RT";
            menuItem_RT.Click += delegate
            {
                try
                {
                    /*
                    if ((bool)tweet.IsRetweeted)
                    {
                        long retweetId = this.tokens.Statuses.Show(include_my_retweet => true).Id;
                        this.tokens.Statuses.Destroy(id => retweetId);
                    }
                    else
                    {
                        this.tokens.Statuses.Retweet(id => tweet.Id);
                    }
                    */

                    this.tokens.Statuses.Retweet(id => tweet.Id);
                }
                catch (Exception)
                {
                    MessageBox.Show("存在しないツイートです。",
                        "Error!!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            };
            cMenu.Items.Add(menuItem_RT);

            // QT
            ToolStripMenuItem menuItem_QT = new ToolStripMenuItem();
            menuItem_QT.Text = "QT";
            menuItem_QT.Click += delegate
            {
                try
                {
                    this.textBox_Input.Text += string.Format(@"https://twitter.com/{0}/status/{1}",
                        tweet.User.ScreenName,
                        tweet.ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show("存在しないツイートです。",
                        "Error!!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            };
            cMenu.Items.Add(menuItem_QT);

            // favorte / Un-favorite
            ToolStripMenuItem menuItem_Favorite = new ToolStripMenuItem();
            menuItem_Favorite.Text = (bool)tweet.IsFavorited ? "Un-favorite" : "favorite";
            menuItem_Favorite.Click += delegate
            {
                try
                {
                    if ((bool)tweet.IsFavorited)
                    {
                        this.tokens.Favorites.Destroy(id => tweet.Id);
                    }
                    else
                    {
                        this.tokens.Favorites.Create(id => tweet.Id);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("存在しないツイートです。",
                        "Error!!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            };
            cMenu.Items.Add(menuItem_Favorite);

            // delete
            if (tweet.User.ScreenName == this.user.ScreenName)
            {
                ToolStripMenuItem menuItem_Delete = new ToolStripMenuItem();
                menuItem_Delete.Text = "Delete";
                menuItem_Delete.Click += delegate
                {
                    try
                    {
                        this.tokens.Statuses.Destroy(id => tweet.Id);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("存在しないツイートです。",
                            "Error!!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                };
                cMenu.Items.Add(menuItem_Delete);
            }

            cMenu.Show(Cursor.Position);
        }

        private Status getTweetFromId(Tokens tokens, string tweetId)
        {
            var tweet = tokens.Statuses.Show(id => tweetId);
            return tweet;
        }

        private List<Status> getTalk(Status tweet)
        {
            List<Status> talk = new List<Status>();
            talk.Add(tweet);

            while (tweet.InReplyToStatusId != null)
            {
                tweet = getTweetFromId(this.tokens, tweet.InReplyToStatusId.ToString());
                talk.Add(tweet);
            }

            return talk;
        }

        private void button_ShowTalk_Click(object sender, EventArgs e)
        {
            ListView lv = getFocusedListView();
            List<Status> talk =  getTalk((Status)lv.SelectedItems[0].Tag);

            Form_Talk f = new Form_Talk(talk);
            f.Show();
        }

        private void tabControl_Timeline_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.tabControl_Timeline.SelectedIndex)
            {
                case 0:
                    this.listView_Home.Items[this.listView_Home.Items.Count - 1].EnsureVisible();
                    break;
                case 1:
                    this.listView_Mention.Items[this.listView_Mention.Items.Count - 1].EnsureVisible();
                    break;
                case 2:
                    this.listView_Home.Items[this.listView_Home.Items.Count - 1].EnsureVisible();
                    break;
                default:
                    break;
            }
        }
    }
}
