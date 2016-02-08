namespace Twitter_Test
{
    partial class Form_UserInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox_UserIcon = new System.Windows.Forms.PictureBox();
            this.label_Id = new MyControls.Mik_Label();
            this.label_Name = new MyControls.Mik_Label();
            this.label_Profile = new MyControls.Mik_Label();
            this.label_CountTweet = new MyControls.Mik_Label();
            this.label_Following = new MyControls.Mik_Label();
            this.label_Follower = new MyControls.Mik_Label();
            this.tabControl_Timeline = new System.Windows.Forms.TabControl();
            this.tabPage_Tweet = new System.Windows.Forms.TabPage();
            this.webBrowser_Detail = new System.Windows.Forms.WebBrowser();
            this.listView_Tweet = new System.Windows.Forms.ListView();
            this.columnHeader_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Text = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage_Following = new System.Windows.Forms.TabPage();
            this.listView_Following = new System.Windows.Forms.ListView();
            this.columnHeader_FollowingID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_FollowingName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage_Followers = new System.Windows.Forms.TabPage();
            this.listView_Followers = new System.Windows.Forms.ListView();
            this.columnHeader_FollowersID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_FollowersName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_MyRelation = new MyControls.Mik_Label();
            this.button_Follow = new MyControls.Mik_LabelButton();
            this.button_Block = new MyControls.Mik_LabelButton();
            this.label_UserRelation = new MyControls.Mik_Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UserIcon)).BeginInit();
            this.tabControl_Timeline.SuspendLayout();
            this.tabPage_Tweet.SuspendLayout();
            this.tabPage_Following.SuspendLayout();
            this.tabPage_Followers.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_UserIcon
            // 
            this.pictureBox_UserIcon.Location = new System.Drawing.Point(12, 26);
            this.pictureBox_UserIcon.Name = "pictureBox_UserIcon";
            this.pictureBox_UserIcon.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_UserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_UserIcon.TabIndex = 16;
            this.pictureBox_UserIcon.TabStop = false;
            // 
            // label_Id
            // 
            this.label_Id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_Id.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Id.ForeColor = System.Drawing.Color.AliceBlue;
            this.label_Id.Location = new System.Drawing.Point(58, 26);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(152, 20);
            this.label_Id.TabIndex = 17;
            this.label_Id.Text = " @";
            this.label_Id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Name
            // 
            this.label_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_Name.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Name.ForeColor = System.Drawing.Color.AliceBlue;
            this.label_Name.Location = new System.Drawing.Point(58, 46);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(152, 20);
            this.label_Name.TabIndex = 18;
            this.label_Name.Text = " ";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Profile
            // 
            this.label_Profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_Profile.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Profile.ForeColor = System.Drawing.Color.AliceBlue;
            this.label_Profile.Location = new System.Drawing.Point(12, 72);
            this.label_Profile.Name = "label_Profile";
            this.label_Profile.Size = new System.Drawing.Size(387, 102);
            this.label_Profile.TabIndex = 19;
            // 
            // label_CountTweet
            // 
            this.label_CountTweet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_CountTweet.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_CountTweet.ForeColor = System.Drawing.Color.AliceBlue;
            this.label_CountTweet.Location = new System.Drawing.Point(12, 177);
            this.label_CountTweet.Name = "label_CountTweet";
            this.label_CountTweet.Size = new System.Drawing.Size(125, 19);
            this.label_CountTweet.TabIndex = 20;
            this.label_CountTweet.Text = " Tweet : ";
            this.label_CountTweet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Following
            // 
            this.label_Following.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_Following.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Following.ForeColor = System.Drawing.Color.AliceBlue;
            this.label_Following.Location = new System.Drawing.Point(143, 177);
            this.label_Following.Name = "label_Following";
            this.label_Following.Size = new System.Drawing.Size(125, 19);
            this.label_Following.TabIndex = 21;
            this.label_Following.Text = " Following : ";
            this.label_Following.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Follower
            // 
            this.label_Follower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_Follower.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Follower.ForeColor = System.Drawing.Color.AliceBlue;
            this.label_Follower.Location = new System.Drawing.Point(274, 177);
            this.label_Follower.Name = "label_Follower";
            this.label_Follower.Size = new System.Drawing.Size(125, 19);
            this.label_Follower.TabIndex = 22;
            this.label_Follower.Text = " Follower : ";
            this.label_Follower.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl_Timeline
            // 
            this.tabControl_Timeline.Controls.Add(this.tabPage_Tweet);
            this.tabControl_Timeline.Controls.Add(this.tabPage_Following);
            this.tabControl_Timeline.Controls.Add(this.tabPage_Followers);
            this.tabControl_Timeline.Location = new System.Drawing.Point(12, 199);
            this.tabControl_Timeline.Name = "tabControl_Timeline";
            this.tabControl_Timeline.SelectedIndex = 0;
            this.tabControl_Timeline.Size = new System.Drawing.Size(387, 289);
            this.tabControl_Timeline.TabIndex = 23;
            // 
            // tabPage_Tweet
            // 
            this.tabPage_Tweet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tabPage_Tweet.Controls.Add(this.webBrowser_Detail);
            this.tabPage_Tweet.Controls.Add(this.listView_Tweet);
            this.tabPage_Tweet.ForeColor = System.Drawing.Color.AliceBlue;
            this.tabPage_Tweet.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Tweet.Name = "tabPage_Tweet";
            this.tabPage_Tweet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Tweet.Size = new System.Drawing.Size(379, 261);
            this.tabPage_Tweet.TabIndex = 0;
            this.tabPage_Tweet.Text = "Tweet";
            // 
            // webBrowser_Detail
            // 
            this.webBrowser_Detail.Location = new System.Drawing.Point(1, 133);
            this.webBrowser_Detail.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_Detail.Name = "webBrowser_Detail";
            this.webBrowser_Detail.Size = new System.Drawing.Size(377, 127);
            this.webBrowser_Detail.TabIndex = 24;
            this.webBrowser_Detail.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser_Detail_Navigating);
            // 
            // listView_Tweet
            // 
            this.listView_Tweet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.listView_Tweet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_Tweet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Date,
            this.columnHeader_Text});
            this.listView_Tweet.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listView_Tweet.ForeColor = System.Drawing.Color.AliceBlue;
            this.listView_Tweet.FullRowSelect = true;
            this.listView_Tweet.GridLines = true;
            this.listView_Tweet.Location = new System.Drawing.Point(2, 2);
            this.listView_Tweet.MultiSelect = false;
            this.listView_Tweet.Name = "listView_Tweet";
            this.listView_Tweet.Size = new System.Drawing.Size(375, 129);
            this.listView_Tweet.TabIndex = 0;
            this.listView_Tweet.UseCompatibleStateImageBehavior = false;
            this.listView_Tweet.View = System.Windows.Forms.View.Details;
            this.listView_Tweet.SelectedIndexChanged += new System.EventHandler(this.listView_Tweet_SelectedIndexChanged);
            this.listView_Tweet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_Tweet_MouseClick);
            this.listView_Tweet.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Tweet_MouseDoubleClick);
            // 
            // columnHeader_Date
            // 
            this.columnHeader_Date.Text = "Date";
            this.columnHeader_Date.Width = 155;
            // 
            // columnHeader_Text
            // 
            this.columnHeader_Text.Text = "Text";
            this.columnHeader_Text.Width = 200;
            // 
            // tabPage_Following
            // 
            this.tabPage_Following.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tabPage_Following.Controls.Add(this.listView_Following);
            this.tabPage_Following.ForeColor = System.Drawing.Color.AliceBlue;
            this.tabPage_Following.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Following.Name = "tabPage_Following";
            this.tabPage_Following.Size = new System.Drawing.Size(379, 261);
            this.tabPage_Following.TabIndex = 1;
            this.tabPage_Following.Text = "Following";
            // 
            // listView_Following
            // 
            this.listView_Following.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.listView_Following.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_Following.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_FollowingID,
            this.columnHeader_FollowingName});
            this.listView_Following.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listView_Following.ForeColor = System.Drawing.Color.AliceBlue;
            this.listView_Following.FullRowSelect = true;
            this.listView_Following.GridLines = true;
            this.listView_Following.Location = new System.Drawing.Point(2, 2);
            this.listView_Following.MultiSelect = false;
            this.listView_Following.Name = "listView_Following";
            this.listView_Following.Size = new System.Drawing.Size(375, 259);
            this.listView_Following.TabIndex = 0;
            this.listView_Following.UseCompatibleStateImageBehavior = false;
            this.listView_Following.View = System.Windows.Forms.View.Details;
            this.listView_Following.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_Users_MouseClick);
            // 
            // columnHeader_FollowingID
            // 
            this.columnHeader_FollowingID.Text = "ID";
            this.columnHeader_FollowingID.Width = 120;
            // 
            // columnHeader_FollowingName
            // 
            this.columnHeader_FollowingName.Text = "UserName";
            this.columnHeader_FollowingName.Width = 235;
            // 
            // tabPage_Followers
            // 
            this.tabPage_Followers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tabPage_Followers.Controls.Add(this.listView_Followers);
            this.tabPage_Followers.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabPage_Followers.ForeColor = System.Drawing.Color.AliceBlue;
            this.tabPage_Followers.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Followers.Name = "tabPage_Followers";
            this.tabPage_Followers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Followers.Size = new System.Drawing.Size(379, 261);
            this.tabPage_Followers.TabIndex = 2;
            this.tabPage_Followers.Text = "Followers";
            // 
            // listView_Followers
            // 
            this.listView_Followers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.listView_Followers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_Followers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_FollowersID,
            this.columnHeader_FollowersName});
            this.listView_Followers.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listView_Followers.ForeColor = System.Drawing.Color.AliceBlue;
            this.listView_Followers.FullRowSelect = true;
            this.listView_Followers.GridLines = true;
            this.listView_Followers.Location = new System.Drawing.Point(2, 2);
            this.listView_Followers.MultiSelect = false;
            this.listView_Followers.Name = "listView_Followers";
            this.listView_Followers.Size = new System.Drawing.Size(375, 259);
            this.listView_Followers.TabIndex = 1;
            this.listView_Followers.UseCompatibleStateImageBehavior = false;
            this.listView_Followers.View = System.Windows.Forms.View.Details;
            this.listView_Followers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_Users_MouseClick);
            // 
            // columnHeader_FollowersID
            // 
            this.columnHeader_FollowersID.Text = "ID";
            this.columnHeader_FollowersID.Width = 120;
            // 
            // columnHeader_FollowersName
            // 
            this.columnHeader_FollowersName.Text = "UserName";
            this.columnHeader_FollowersName.Width = 235;
            // 
            // label_MyRelation
            // 
            this.label_MyRelation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_MyRelation.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_MyRelation.ForeColor = System.Drawing.Color.AliceBlue;
            this.label_MyRelation.Location = new System.Drawing.Point(216, 26);
            this.label_MyRelation.Name = "label_MyRelation";
            this.label_MyRelation.Size = new System.Drawing.Size(109, 20);
            this.label_MyRelation.TabIndex = 24;
            this.label_MyRelation.Text = " Following : false ";
            this.label_MyRelation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Follow
            // 
            this.button_Follow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Follow.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Follow.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_Follow.Location = new System.Drawing.Point(331, 26);
            this.button_Follow.Name = "button_Follow";
            this.button_Follow.Size = new System.Drawing.Size(68, 18);
            this.button_Follow.TabIndex = 25;
            this.button_Follow.Text = " UnFollow ";
            this.button_Follow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Follow.Click += new System.EventHandler(this.button_Follow_Click);
            // 
            // button_Block
            // 
            this.button_Block.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Block.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Block.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_Block.Location = new System.Drawing.Point(331, 48);
            this.button_Block.Name = "button_Block";
            this.button_Block.Size = new System.Drawing.Size(68, 18);
            this.button_Block.TabIndex = 26;
            this.button_Block.Text = " Block ";
            this.button_Block.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Block.Click += new System.EventHandler(this.button_Block_Click);
            // 
            // label_UserRelation
            // 
            this.label_UserRelation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_UserRelation.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_UserRelation.ForeColor = System.Drawing.Color.AliceBlue;
            this.label_UserRelation.Location = new System.Drawing.Point(216, 46);
            this.label_UserRelation.Name = "label_UserRelation";
            this.label_UserRelation.Size = new System.Drawing.Size(109, 20);
            this.label_UserRelation.TabIndex = 27;
            this.label_UserRelation.Text = " Followed : false ";
            this.label_UserRelation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 500);
            this.Controls.Add(this.label_UserRelation);
            this.Controls.Add(this.button_Block);
            this.Controls.Add(this.button_Follow);
            this.Controls.Add(this.label_MyRelation);
            this.Controls.Add(this.tabControl_Timeline);
            this.Controls.Add(this.label_Profile);
            this.Controls.Add(this.label_Follower);
            this.Controls.Add(this.label_Following);
            this.Controls.Add(this.label_CountTweet);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.pictureBox_UserIcon);
            this.Name = "Form_UserInfo";
            this.Text = "Form_UserTweetList";
            this.Load += new System.EventHandler(this.Form_UserInfo_Load);
            this.Controls.SetChildIndex(this.pictureBox_UserIcon, 0);
            this.Controls.SetChildIndex(this.label_Id, 0);
            this.Controls.SetChildIndex(this.label_Name, 0);
            this.Controls.SetChildIndex(this.label_CountTweet, 0);
            this.Controls.SetChildIndex(this.label_Following, 0);
            this.Controls.SetChildIndex(this.label_Follower, 0);
            this.Controls.SetChildIndex(this.label_Profile, 0);
            this.Controls.SetChildIndex(this.tabControl_Timeline, 0);
            this.Controls.SetChildIndex(this.label_MyRelation, 0);
            this.Controls.SetChildIndex(this.button_Follow, 0);
            this.Controls.SetChildIndex(this.button_Block, 0);
            this.Controls.SetChildIndex(this.label_UserRelation, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UserIcon)).EndInit();
            this.tabControl_Timeline.ResumeLayout(false);
            this.tabPage_Tweet.ResumeLayout(false);
            this.tabPage_Following.ResumeLayout(false);
            this.tabPage_Followers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_UserIcon;
        private MyControls.Mik_Label label_Id;
        private MyControls.Mik_Label label_Name;
        private MyControls.Mik_Label label_Profile;
        private MyControls.Mik_Label label_CountTweet;
        private MyControls.Mik_Label label_Following;
        private MyControls.Mik_Label label_Follower;
        private System.Windows.Forms.TabControl tabControl_Timeline;
        private System.Windows.Forms.TabPage tabPage_Tweet;
        private System.Windows.Forms.ListView listView_Tweet;
        private System.Windows.Forms.ColumnHeader columnHeader_Date;
        private System.Windows.Forms.ColumnHeader columnHeader_Text;
        private System.Windows.Forms.WebBrowser webBrowser_Detail;
        private MyControls.Mik_Label label_MyRelation;
        private MyControls.Mik_LabelButton button_Follow;
        private MyControls.Mik_LabelButton button_Block;
        private MyControls.Mik_Label label_UserRelation;
        private System.Windows.Forms.TabPage tabPage_Following;
        private System.Windows.Forms.ListView listView_Following;
        private System.Windows.Forms.ColumnHeader columnHeader_FollowingID;
        private System.Windows.Forms.ColumnHeader columnHeader_FollowingName;
        private System.Windows.Forms.TabPage tabPage_Followers;
        private System.Windows.Forms.ListView listView_Followers;
        private System.Windows.Forms.ColumnHeader columnHeader_FollowersID;
        private System.Windows.Forms.ColumnHeader columnHeader_FollowersName;
    }
}