using System;
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
using MyControls;

using CoreTweet;
using CoreTweet.Core;

namespace Twitter_Test
{
    public partial class Form_UserInfo : Mik_Form
    {
        public Form_UserInfo(Tokens tokens, User user, User myData, Form_Main parentForm)
        {
            InitializeComponent();
            this.tokens = tokens;
            this.user = user;
            this.myData = myData;
            this.parentForm = parentForm;
        }

        private Tokens tokens = null;
        private User user = null;
        private User myData = null;

        private Form_Main parentForm = null;
        private MyClass util = new MyClass();

        private void Form_UserInfo_Load(object sender, EventArgs e)
        {
            this.Title = "@" + this.user.ScreenName;
            setData(this.user);

            if (this.user.Equals(this.myData))
            {
                this.label_MyRelation.TextAlign = ContentAlignment.BottomCenter;
                this.label_MyRelation.Text = " My Data. ";
                this.label_UserRelation.Text = string.Empty;

                this.button_Follow.Text = string.Empty;
                this.button_Follow.Enabled = false;
                this.button_Block.Text = string.Empty;
                this.button_Block.Enabled = false;
            }
        }

        private void setData(User user)
        {
            this.label_Id.Text += string.Format("{0} ", user.ScreenName);
            this.label_Name.Text = string.Format(" {0} ", user.Name);
            this.label_Profile.Text = user.Description != null ? user.Description : string.Empty;
            this.label_CountTweet.Text += string.Format("{0} ", user.StatusesCount);
            this.label_Following.Text += string.Format("{0} ", user.FriendsCount);
            this.label_Follower.Text += string.Format("{0} ", user.FollowersCount);

            setRelation(user, this.myData, this.tokens);

            this.pictureBox_UserIcon.ImageLocation = user.ProfileImageUrl;
            this.pictureBox_UserIcon.Refresh();

            this.webBrowser_Detail.DocumentText =
@"<body bgcolor=""#404040"" text=""#F0F8FF"" link=""#B0C4DE"" vlink=""#FFB6C1"">";

            showUserTimeline(this.listView_Tweet);
        }

        private void setRelation(User user, User myData, Tokens tokens)
        {
            this.button_Follow.Text = " Follow ";
            string myRelation = " Following : {0} ";
            string following = "false";
            var myFriendIds = this.tokens.Friends.EnumerateIds(EnumerateMode.Next, user_id => this.myData.Id);
            foreach (var id in myFriendIds)
            {
                if (id == user.Id)
                {
                    following = "true";
                    this.button_Follow.Text = " UnFollow ";
                    break;
                }
            }
            this.label_MyRelation.Text = string.Format(myRelation, following);

            string userRelation = " Followed : {0} ";
            string followed = "false";
            var userFriendIds = this.tokens.Friends.EnumerateIds(EnumerateMode.Next, user_id => user.Id);
            foreach (var id in userFriendIds)
            {
                if (id == this.myData.Id)
                {
                    followed = "true";
                    break;
                }
            }
            this.label_UserRelation.Text = string.Format(userRelation, followed);
        }

        private void showUserTimeline(ListView lv)
        {
            try
            {
                var home = getUserTweet(this.tokens, this.user.ScreenName);

                for (int i = home.Count - 1; i >= 0; i--)
                {
                    displayTimeline(this.listView_Tweet, home[i]);
                }
            }
            catch (Exception ex)
            {
                this.util.ShowExceptionMessageBox(ex.Message, ex.StackTrace);
                return;
            }
        }

        private ListedResponse<Status> getUserTweet(Tokens tokens, string screenName)
        {
            var param = new Dictionary<string, object>();
            param["count"] = 100;
            param["screen_name"] = screenName;

            var timeline = tokens.Statuses.UserTimeline(param);

            return timeline;
        }

        private void displayTimeline(ListView lv, Status tweet)
        {
            try
            {
                string[] msg = 
                {
                    (tweet.RetweetedStatus != null ? tweet.RetweetedStatus : tweet).CreatedAt.LocalDateTime.ToString("yyyy/MM/dd(ddd) HH:mm:ss"),
                    (tweet.RetweetedStatus != null ? tweet.RetweetedStatus : tweet).Text,
                    (tweet.RetweetedStatus != null ? tweet.RetweetedStatus : tweet).ToString()
                };
                ListViewItem item = new ListViewItem(msg);
                item.Tag = tweet;

                lv.Items.Insert(0, item);
            }
            catch (Exception ex)
            {
                util.ShowExceptionMessageBox(ex.Message, ex.StackTrace);
            }
        }

        private void listView_Tweet_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = getFocusedListView();

            if (lv.SelectedItems.Count == 0)
            {
                this.webBrowser_Detail.DocumentText =
@"<body bgcolor=""#404040"" text=""#F0F8FF"" link=""#B0C4DE"" vlink=""#FFB6C1"">";
                return;
            }

            if (lv.SelectedItems.Count != 1)
            {
                return;
            }

            ListViewItem item = lv.SelectedItems[0];
            var tweet = ((Status)item.Tag).RetweetedStatus != null ?
                ((Status)item.Tag).RetweetedStatus : ((Status)item.Tag);

            Regex url = new Regex(@"s?https?://[-_.!~*'()a-zA-Z0-9;/?:@&=+$,%#]+", RegexOptions.IgnoreCase);
            Regex userId = new Regex(@"@([a-zA-Z0-9_]+)", RegexOptions.IgnoreCase);
            string context = url.Replace(item.SubItems[1].Text, "<a href=\"$&\">$&</a>");
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
                foreach (var media in tweet.ExtendedEntities.Media)
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

            StringBuilder sb2 = new StringBuilder();
            sb2.Append("<font size=\"2\" face=\"Meiryo UI\">");
            sb2.Append(item.SubItems[0].Text);                                  // Date-Time
            sb2.AppendFormat(" via {0}<br>", tweet.Source);                     // via
            sb2.AppendFormat(
                "<a href=\"https://twitter.com/{0}\">@{0}</a> / {1}{2}<br>",
                tweet.User.ScreenName,                                          // user-ID
                tweet.User.Name,                                                // user-Name
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
<body
<body bgcolor=""#404040"" text=""#F0F8FF"" link=""#6495ED"" vlink=""#FFB6C1"">
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
            switch (this.tabControl_Timeline.SelectedIndex)
            {
                case 0:
                    return this.listView_Tweet;
                default:
                    return this.listView_Tweet;
            }
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

            if (link == null || link == string.Empty)
            {
                return;
            }

            Regex linkToAccount = new Regex("https://www.twitter.com/[a-zA-Z0-9_]+", RegexOptions.IgnoreCase);
            if (linkToAccount.IsMatch(link))
            {
                try
                {
                    string screenName = link.Substring(24, link.Length - 24);
                    var user = this.tokens.Users.Lookup(screen_name => screenName);
                    Form_UserInfo f = new Form_UserInfo(this.tokens, user[0], this.myData, this.parentForm);
                    f.Show();
                    return;
                }
                catch (Exception)
                {
                    MessageBox.Show("存在しないツイートです。",
                        "Error!!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            }

            try
            {
                System.Diagnostics.Process.Start(link);
            }
            catch
            {
            }
        }

        private void webBrowser_Detail_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (e.Url.OriginalString != "about:blank")
            {
                e.Cancel = true;
            }
        }
        private void listView_Tweet_MouseClick(object sender, MouseEventArgs e)
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

            Status tweet = getTweetFromId(this.tokens, item.SubItems[2].Text);
            if (tweet.RetweetedStatus != null)
            {
                tweet = tweet.RetweetedStatus;
            }

            ContextMenuStrip cMenu = new ContextMenuStrip();

            // UserInfo
            ToolStripMenuItem menuItem_UserInfo = new ToolStripMenuItem();
            menuItem_UserInfo.Text = "UserInfo";
            menuItem_UserInfo.Click += delegate
            {
                try
                {
                    Form_UserInfo f = new Form_UserInfo(this.tokens, tweet.User, this.myData, this.parentForm);
                    f.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("存在しないツイートです。",
                        "Error!!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            };
            cMenu.Items.Add(menuItem_UserInfo);

            if (tweet.InReplyToStatusId != null)
            {
                // Talk
                ToolStripMenuItem menuItem_Talk = new ToolStripMenuItem();
                menuItem_Talk.Text = "Talk";
                menuItem_Talk.Click += delegate
                {
                    try
                    {
                        List<Status> talk = getTalk((Status)lv.SelectedItems[0].Tag);

                        Form_Talk f = new Form_Talk(this.tokens, talk, this.parentForm);
                        f.Show();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("存在しないツイートです。",
                            "Error!!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                };
                cMenu.Items.Add(menuItem_Talk);
            }

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
                    string message = string.Format("Retweeted to @{0}: {1}",
                        tweet.User.ScreenName,
                        tweet.Text);
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
                    string context = string.Format(@"https://twitter.com/{0}/status/{1}",
                        tweet.User.ScreenName,
                        tweet.ToString());
                    this.parentForm.SetQt(context);
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
                        lv.Items.RemoveAt(lv.SelectedIndices[0]);
                        string message = string.Format("Un-Favorited to @{0}: {1}",
                            tweet.User.ScreenName,
                            tweet.Text);
                    }
                    else
                    {
                        this.tokens.Favorites.Create(id => tweet.Id);
                        string message = string.Format("Favorited to @{0}: {1}",
                            tweet.User.ScreenName,
                            tweet.Text);
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
            if (tweet.User.ScreenName == this.tokens.Account.VerifyCredentials().ScreenName)
            {
                ToolStripMenuItem menuItem_Delete = new ToolStripMenuItem();
                menuItem_Delete.Text = "Delete";
                menuItem_Delete.Click += delegate
                {
                    try
                    {
                        this.tokens.Statuses.Destroy(id => tweet.Id);
                        lv.Items.RemoveAt(lv.SelectedIndices[0]);
                        string message = string.Format("Deleted: {0}",
                            tweet.Text);
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

        private void listView_Tweet_MouseDoubleClick(object sender, MouseEventArgs e)
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

            Status tweet = ((Status)item.Tag).RetweetedStatus != null ?
                ((Status)item.Tag).RetweetedStatus : ((Status)item.Tag);
            string inReplyTo = string.Format(
@"{0}: 
{1}",
                tweet.User.ScreenName,
                tweet.Text.Substring(0, tweet.Text.IndexOfAny(new char[] { '\0', '\n' }) + 1 == 0 ?
                    tweet.Text.Length : tweet.Text.IndexOfAny(new char[] { '\0', '\n' }) + 1));
            this.parentForm.SetTweet(tweet, inReplyTo);
        }

        private void button_Follow_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.button_Follow.Text == " Follow ")
                {
                    this.tokens.Friendships.Create(screen_name => this.user.ScreenName);
                    return;
                }

                this.tokens.Friendships.Destroy(screen_name => this.user.ScreenName);
            }
            catch (Exception ex)
            {
                util.ShowExceptionMessageBox(ex.Message, ex.StackTrace);
            }
            finally
            {
                setRelation(this.user, this.myData, this.tokens);
            }
        }

        private void button_Block_Click(object sender, EventArgs e)
        {
            try
            {
                this.tokens.Blocks.Create(screen_name => this.user.ScreenName);
            }
            catch (Exception ex)
            {
                util.ShowExceptionMessageBox(ex.Message, ex.StackTrace);
            }
            finally
            {
                setRelation(this.user, this.myData, this.tokens);
            }
        }
    }
}
