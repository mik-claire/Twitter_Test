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

namespace Twitter_Test
{
    public partial class Form_UserInfo : Mik_Form
    {
        public Form_UserInfo(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private User user = null;

        private void Form_UserTweetList_Load(object sender, EventArgs e)
        {
            this.Title = "@" + this.user.ScreenName;
            setData(this.user);
        }

        private void setData(User user)
        {
            this.label_Id.Text += string.Format("{0} ", user.ScreenName);
            this.label_Name.Text = string.Format(" {0} ", user.Name);
            this.label_Profile.Text = user.Description != null ? user.Description : string.Empty;
            this.label_CountTweet.Text += "";
            this.label_Following.Text += string.Format("{0} ", user.FriendsCount);
            this.label_Follower.Text += string.Format("{0} ", user.FollowersCount);

            this.pictureBox_UserIcon.ImageLocation = user.ProfileImageUrl;
            this.pictureBox_UserIcon.Refresh();
        }
    }
}
