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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UserIcon)).BeginInit();
            this.tabControl_Timeline.SuspendLayout();
            this.tabPage_Tweet.SuspendLayout();
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
            this.label_Id.AutoSize = true;
            this.label_Id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_Id.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Id.ForeColor = System.Drawing.Color.AliceBlue;
            this.label_Id.Location = new System.Drawing.Point(59, 26);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(23, 15);
            this.label_Id.TabIndex = 17;
            this.label_Id.Text = " @";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_Name.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Name.ForeColor = System.Drawing.Color.AliceBlue;
            this.label_Name.Location = new System.Drawing.Point(59, 51);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(11, 15);
            this.label_Name.TabIndex = 18;
            this.label_Name.Text = " ";
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
            this.label_CountTweet.Location = new System.Drawing.Point(12, 179);
            this.label_CountTweet.Name = "label_CountTweet";
            this.label_CountTweet.Size = new System.Drawing.Size(125, 15);
            this.label_CountTweet.TabIndex = 20;
            this.label_CountTweet.Text = " Tweet : ";
            // 
            // label_Following
            // 
            this.label_Following.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_Following.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Following.ForeColor = System.Drawing.Color.AliceBlue;
            this.label_Following.Location = new System.Drawing.Point(143, 179);
            this.label_Following.Name = "label_Following";
            this.label_Following.Size = new System.Drawing.Size(125, 15);
            this.label_Following.TabIndex = 21;
            this.label_Following.Text = " Following : ";
            // 
            // label_Follower
            // 
            this.label_Follower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_Follower.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Follower.ForeColor = System.Drawing.Color.AliceBlue;
            this.label_Follower.Location = new System.Drawing.Point(274, 179);
            this.label_Follower.Name = "label_Follower";
            this.label_Follower.Size = new System.Drawing.Size(125, 15);
            this.label_Follower.TabIndex = 22;
            this.label_Follower.Text = " Follower : ";
            // 
            // tabControl_Timeline
            // 
            this.tabControl_Timeline.Controls.Add(this.tabPage_Tweet);
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
            this.webBrowser_Detail.Location = new System.Drawing.Point(1, 168);
            this.webBrowser_Detail.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_Detail.Name = "webBrowser_Detail";
            this.webBrowser_Detail.Size = new System.Drawing.Size(377, 92);
            this.webBrowser_Detail.TabIndex = 24;
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
            this.listView_Tweet.Size = new System.Drawing.Size(375, 160);
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
            // Form_UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 500);
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
            this.Load += new System.EventHandler(this.Form_UserTweetList_Load);
            this.Controls.SetChildIndex(this.pictureBox_UserIcon, 0);
            this.Controls.SetChildIndex(this.label_Id, 0);
            this.Controls.SetChildIndex(this.label_Name, 0);
            this.Controls.SetChildIndex(this.label_CountTweet, 0);
            this.Controls.SetChildIndex(this.label_Following, 0);
            this.Controls.SetChildIndex(this.label_Follower, 0);
            this.Controls.SetChildIndex(this.label_Profile, 0);
            this.Controls.SetChildIndex(this.tabControl_Timeline, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UserIcon)).EndInit();
            this.tabControl_Timeline.ResumeLayout(false);
            this.tabPage_Tweet.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}