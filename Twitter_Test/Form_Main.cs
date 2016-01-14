using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreTweet;
using MyLib;
using System.Text.RegularExpressions;
using System.IO;

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
                }

                return;
            }

            this.tokens = Tokens.Create(
                apiKey,
                apiKeySecret,
                Properties.Settings.Default.AccessToken,
                Properties.Settings.Default.AccessTokenSecret);
        }

        private MyClass util = new MyClass();

        private Tokens tokens;

        private void Form_Main_Load(object sender, EventArgs e)
        {
            if (this.tokens == null)
            {
                this.Close();
            }

            this.textBox_Input.Text = string.Empty;
            show(this.tokens);
        }

        private void show(Tokens tokens)
        {
            showHomeTimeline(this.listView_Home);
            showMentionTimeline(this.listView_Mention);
        }

        private void showHomeTimeline(ListView lv)
        {
            try
            {
                var home = tokens.Statuses.HomeTimeline(count => 50);
                lv.Items.Clear();

                for (int i = 0; i < home.Count; i++)
                {
                    string[] msg = 
                    {
                        home[i].CreatedAt.LocalDateTime.ToString("yyyy/MM/dd(ddd) HH:mm:ss"),
                        home[i].User.ScreenName,
                        home[i].User.Name,
                        home[i].Text
                    };

                    if (home[i].RetweetedStatus != null)
                    {
                        var origin = home[i].RetweetedStatus;
                        msg[0] = origin.CreatedAt.LocalDateTime.ToString("yyyy/MM/dd(ddd) HH:mm:ss");
                        msg[1] = origin.User.ScreenName;
                        msg[2] = origin.User.Name;
                        msg[3] = origin.Text;
                    }

                    ListViewItem item = new ListViewItem(msg);
                    item.Tag = home[i];
                    lv.Items.Add(item);
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
                var mention = tokens.Statuses.MentionsTimeline(count => 50);
                lv.Items.Clear();

                for (int i = 0; i < mention.Count; i++)
                {
                    List<string> source = getSourceNameAndUrl(mention[i].Source);

                    string[] msg = 
                    {
                        mention[i].CreatedAt.LocalDateTime.ToString("yyyy/MM/dd(ddd) HH:mm:ss"),
                        mention[i].User.ScreenName,
                        mention[i].User.Name,
                        mention[i].Text,
                    };
                    ListViewItem item = new ListViewItem(msg);
                    item.Tag = mention[i];
                    lv.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                util.ShowExceptionMessageBox(ex.Message, ex.StackTrace);
                return;
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
@"<a href=""{0}""><img border=""0"" src=""{0}"" width=""{1}"" height=""{2}"" alt=""{0}""></a>",
                        media.MediaUrl,
                        media.Sizes.Small.Width * (96 / (float)media.Sizes.Small.Width),
                        media.Sizes.Small.Height * (96 / (float)media.Sizes.Small.Width));
                }
            }

            StringBuilder sb2 = new StringBuilder();
            sb2.Append("");
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
@"<html><head><style type=""text/css""><!-- #icon {{ float: left; }} //--></style></head><body><div id=""icon""><img border=""0"" src=""{0}"" width=""32"" height=""32""></div><div id=""context"">{1}</div>{2}</body></html>",
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

                show(this.tokens);
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
        }

        private Status status = null;
        private void listView_Timeline_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView lv = getFocusedListView();

            // フォーカス判定
            ListViewItem item = lv.FocusedItem;
            if (!lv.FocusedItem.Bounds.Contains(e.Location))
            {
                return;
            }

            this.status = (Status)item.Tag;
            string inReplyTo = string.Format(
@"{0}: 
{1}",
                this.status.User.ScreenName,
                this.status.Text.Substring(0, this.status.Text.IndexOfAny(new char[] { '\0', '\n' }) + 1 == 0 ?
                    this.status.Text.Length :
                    this.status.Text.IndexOfAny(new char[] { '\0', '\n' }) + 1));
            this.label_InReplyTo.Text = inReplyTo;
            this.textBox_Input.Text =
                this.textBox_Input.Text.Insert(0, string.Format("@{0} ", this.status.User.ScreenName));
            this.button_ResetReply.Visible = true;
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.tokens == null)
            {
                return;
            }

            Properties.Settings.Default.AccessToken = this.tokens.AccessToken;
            Properties.Settings.Default.AccessTokenSecret = this.tokens.AccessTokenSecret;
            Properties.Settings.Default.Save();
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

                    show(this.tokens);
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
    }
}
