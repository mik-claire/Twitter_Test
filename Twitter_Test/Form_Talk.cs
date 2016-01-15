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

namespace Twitter_Test
{
    public partial class Form_Talk : Form
    {
        public Form_Talk(List<Status> talk)
        {
            InitializeComponent();
            this.talk = talk;
        }

        private List<Status> talk = new List<Status>();

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Talk_Load(object sender, EventArgs e)
        {
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
<body>
");

            foreach (Status tweet in this.talk)
            {
                Regex url = new Regex(@"s?https?://[-_.!~*'()a-zA-Z0-9;/?:@&=+$,%#]+", RegexOptions.IgnoreCase);
                Regex userId = new Regex(@"@([a-zA-Z0-9_]+)", RegexOptions.IgnoreCase);
                string context = url.Replace(tweet.Text, "<a href=\"$&\">$&</a>");
                context = userId.Replace(context, "<a href=\"http://www.twitter.com/$1\">$&</a>");

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

                StringBuilder doc = new StringBuilder();
                doc.Append("<font size=\"2\" face=\"Meiryo UI\">");
                doc.Append(tweet.CreatedAt.LocalDateTime.ToString("yyyy/MM/dd(ddd) HH:mm:ss")); // Date-Time
                doc.AppendFormat(" via {0}<br>", tweet.Source);                                 // via
                doc.AppendFormat("<a href=\"https://twitter.com/{0}\">@{0}</a> / {1}<br>",
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

        private void webBrowser_Talk_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (e.Url.OriginalString != "about:blank")
            {
                e.Cancel = true;
            }
        }
    }
}
