using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreTweet;
using MyControls;

namespace Twitter_Test
{
    public partial class Form_Talk :Mik_Form
    {
        public Form_Talk(Tokens tokens, List<Status> talk, Form_Main parentForm)
        {
            InitializeComponent();
            this.tokens = tokens;
            this.talk = talk;
            this.parentForm = parentForm;
        }

        private Tokens tokens = null;
        private List<Status> talk = new List<Status>();
        private Form_Main parentForm = null;

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Talk_Load(object sender, EventArgs e)
        {
            this.Title = "Talk";

            StringBuilder documentText = new StringBuilder();
            documentText.Append(
@"<html>
<head>
  <style type=""text/css"">
    <!--
    #icon {{ float: left; }}
    //-->
  </style>
</head>
<body bgcolor=""#404040"" text=""#F0F8FF"" link=""#6495ED"" vlink=""#FFB6C1"">
");

            foreach (Status tweet in this.talk)
            {
                Regex url = new Regex(@"s?https?://[-_.!~*'()a-zA-Z0-9;/?:@&=+$,%#]+", RegexOptions.IgnoreCase);
                Regex userId = new Regex(@"@([a-zA-Z0-9_]+)", RegexOptions.IgnoreCase);
                string context = url.Replace(tweet.Text, "<a href=\"$&\">$&</a>");
                context = userId.Replace(context, "<a href=\"https://www.twitter.com/$1\">$&</a>");

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
				
			string rt = @"<font style=""cursor:hand;"" color=""#6495ED""><u>RT</u></font>";
			string qt = @"<font style=""cursor:hand;"" color=""#6495ED""><u>QT</u></font>";
			string fav = string.Format(
@"<font style=""cursor:hand;"" color=""#6495ED""><u>{0}</u></font>",
				(bool)tweet.IsFavorited ? "★" : "☆");

			StringBuilder doc = new StringBuilder();
			doc.Append(string.Format(
@"<!-- {0} -->",
				tweet.Id));
                doc.Append("<font size=\"2\" face=\"Meiryo UI\">");
                doc.Append(tweet.CreatedAt.LocalDateTime.ToString("yyyy/MM/dd(ddd) HH:mm:ss")); // Date-Time
                doc.AppendFormat(" via {0} {1} {2} {3}<br>", tweet.Source,						// via
					rt, qt, fav);																// control
                doc.AppendFormat("<a href=\"https://www.twitter.com/{0}\">@{0}</a> / {1}<br>",
                    tweet.User.ScreenName,                                                      // user-ID
                    tweet.User.Name);                                                           // user-Name
                doc.AppendFormat("{0}<br></font>", context.Replace("\n", "<br>"));              // context
                documentText.AppendFormat(
@"
<p>
  <div id=""icon"">
    <img border=""0"" src=""{0}"" width=""32"" height=""32"">
  </div>
  <div id=""context"">
    {1}
  </div>
  {2}
</p>
",
                    tweet.User.ProfileImageUrl,
                    doc.ToString(),
                    entities == string.Empty ? string.Empty : "<div>" + entities + "</div>");
            }

            documentText.Append(
@"  </font>
</body>
</html>
");
            this.webBrowser_Talk.DocumentText = documentText.ToString();
            this.webBrowser_Talk.Document.Click += new HtmlElementEventHandler(webBrowser_Talk_DocumentClick);
        }

        private void webBrowser_Talk_DocumentClick(object sender, HtmlElementEventArgs e)
        {
            HtmlElement clickedElement = webBrowser_Talk.Document.GetElementFromPoint(e.MousePosition);
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

            if (clickedElement.InnerText == "RT")
            {
                string tweetId = clickedElement.Parent.Parent.Parent.InnerHtml.Split(new string[] { " -->" }, StringSplitOptions.RemoveEmptyEntries)[0];
                tweetId = tweetId.Substring(5, tweetId.Length - 5);
                Status tweet = getTweetFromId(this.tokens, tweetId);

                retweet(tweet);
                return;
            }

            if (clickedElement.InnerText == "QT")
            {
                string tweetId = clickedElement.Parent.Parent.Parent.InnerHtml.Split(new string[] { " -->" }, StringSplitOptions.RemoveEmptyEntries)[0];
                tweetId = tweetId.Substring(5, tweetId.Length - 5);
                Status tweet = getTweetFromId(this.tokens, tweetId);

                quoteTweet(tweet);
                return;
            }

            if (clickedElement.InnerText == "☆" ||
                clickedElement.InnerText == "★")
            {
                string tweetId = clickedElement.Parent.Parent.Parent.InnerHtml.Split(new string[] { " -->" }, StringSplitOptions.RemoveEmptyEntries)[0];
                tweetId = tweetId.Substring(5, tweetId.Length - 5);
                Status tweet = getTweetFromId(this.tokens, tweetId);
                if (tweet.RetweetedStatus != null)
                {
                    tweet = tweet.RetweetedStatus;
                }

                favorite(tweet);
                return;
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
                    Form_UserInfo f = new Form_UserInfo(this.tokens, user[0], this.tokens.Account.VerifyCredentials(), this.parentForm);
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

        private void webBrowser_Talk_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (e.Url.OriginalString != "about:blank")
            {
                e.Cancel = true;
            }
		}

		private Status getTweetFromId(Tokens tokens, string tweetId)
		{
			var tweet = tokens.Statuses.Show(id => tweetId);
			return tweet;
		}

        private void retweet(Status tweet)
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

        private void quoteTweet(Status tweet)
        {
            this.parentForm.SetQt(string.Format(@"https://twitter.com/{0}/status/{1}",
                tweet.User.ScreenName,
                tweet.ToString()));
        }

        private void favorite(Status tweet)
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

    }
}
