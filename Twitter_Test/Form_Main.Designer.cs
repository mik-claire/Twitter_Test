namespace Twitter_Test
{
    partial class Form_Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView_Home = new System.Windows.Forms.ListView();
            this.columnHeader_HomeDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_HomeUserId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_HomeUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_HomeText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl_Timeline = new System.Windows.Forms.TabControl();
            this.tabPage_Home = new System.Windows.Forms.TabPage();
            this.tabPage_Mention = new System.Windows.Forms.TabPage();
            this.listView_Mention = new System.Windows.Forms.ListView();
            this.columnHeader_MentionDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_MentionUserId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_MentionUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_MentionText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage_Fav = new System.Windows.Forms.TabPage();
            this.listView_Fav = new System.Windows.Forms.ListView();
            this.columnHeader_FavDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_FavUserId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_FavUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_FavText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.webBrowser_Detail = new System.Windows.Forms.WebBrowser();
            this.label_InReplyTo = new System.Windows.Forms.Label();
            this.label_AppendFilesCount = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.button_ResetReply = new MyControls.Mik_LabelButton();
            this.button_Tweet = new MyControls.Mik_LabelButton();
            this.button_AccountChange = new MyControls.Mik_LabelButton();
            this.label_Status = new MyControls.Mik_Label();
            this.timer_ShowStatus = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_UserIcon = new System.Windows.Forms.PictureBox();
            this.timer_ReStreaming = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl_Timeline.SuspendLayout();
            this.tabPage_Home.SuspendLayout();
            this.tabPage_Mention.SuspendLayout();
            this.tabPage_Fav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UserIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_Home
            // 
            this.listView_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.listView_Home.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_Home.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_HomeDate,
            this.columnHeader_HomeUserId,
            this.columnHeader_HomeUserName,
            this.columnHeader_HomeText});
            this.listView_Home.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listView_Home.ForeColor = System.Drawing.Color.AliceBlue;
            this.listView_Home.FullRowSelect = true;
            this.listView_Home.GridLines = true;
            this.listView_Home.Location = new System.Drawing.Point(0, 0);
            this.listView_Home.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView_Home.MultiSelect = false;
            this.listView_Home.Name = "listView_Home";
            this.listView_Home.Size = new System.Drawing.Size(579, 252);
            this.listView_Home.TabIndex = 0;
            this.listView_Home.UseCompatibleStateImageBehavior = false;
            this.listView_Home.View = System.Windows.Forms.View.Details;
            this.listView_Home.SelectedIndexChanged += new System.EventHandler(this.listView_Timeline_SelectedIndexChanged);
            this.listView_Home.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_Timeline_MouseClick);
            this.listView_Home.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Timeline_MouseDoubleClick);
            // 
            // columnHeader_HomeDate
            // 
            this.columnHeader_HomeDate.Text = "Date";
            this.columnHeader_HomeDate.Width = 155;
            // 
            // columnHeader_HomeUserId
            // 
            this.columnHeader_HomeUserId.Text = "UserId";
            this.columnHeader_HomeUserId.Width = 80;
            // 
            // columnHeader_HomeUserName
            // 
            this.columnHeader_HomeUserName.Text = "UserName";
            this.columnHeader_HomeUserName.Width = 100;
            // 
            // columnHeader_HomeText
            // 
            this.columnHeader_HomeText.Text = "Text";
            this.columnHeader_HomeText.Width = 220;
            // 
            // tabControl_Timeline
            // 
            this.tabControl_Timeline.Controls.Add(this.tabPage_Home);
            this.tabControl_Timeline.Controls.Add(this.tabPage_Mention);
            this.tabControl_Timeline.Controls.Add(this.tabPage_Fav);
            this.tabControl_Timeline.Location = new System.Drawing.Point(12, 94);
            this.tabControl_Timeline.Name = "tabControl_Timeline";
            this.tabControl_Timeline.SelectedIndex = 0;
            this.tabControl_Timeline.Size = new System.Drawing.Size(586, 280);
            this.tabControl_Timeline.TabIndex = 3;
            // 
            // tabPage_Home
            // 
            this.tabPage_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tabPage_Home.Controls.Add(this.listView_Home);
            this.tabPage_Home.ForeColor = System.Drawing.Color.AliceBlue;
            this.tabPage_Home.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Home.Name = "tabPage_Home";
            this.tabPage_Home.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Home.Size = new System.Drawing.Size(578, 252);
            this.tabPage_Home.TabIndex = 0;
            this.tabPage_Home.Text = "Home";
            // 
            // tabPage_Mention
            // 
            this.tabPage_Mention.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tabPage_Mention.Controls.Add(this.listView_Mention);
            this.tabPage_Mention.ForeColor = System.Drawing.Color.AliceBlue;
            this.tabPage_Mention.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Mention.Name = "tabPage_Mention";
            this.tabPage_Mention.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Mention.Size = new System.Drawing.Size(578, 252);
            this.tabPage_Mention.TabIndex = 1;
            this.tabPage_Mention.Text = "Mention";
            // 
            // listView_Mention
            // 
            this.listView_Mention.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.listView_Mention.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_Mention.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_MentionDate,
            this.columnHeader_MentionUserId,
            this.columnHeader_MentionUserName,
            this.columnHeader_MentionText});
            this.listView_Mention.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listView_Mention.ForeColor = System.Drawing.Color.AliceBlue;
            this.listView_Mention.FullRowSelect = true;
            this.listView_Mention.GridLines = true;
            this.listView_Mention.Location = new System.Drawing.Point(0, 0);
            this.listView_Mention.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView_Mention.MultiSelect = false;
            this.listView_Mention.Name = "listView_Mention";
            this.listView_Mention.Size = new System.Drawing.Size(580, 252);
            this.listView_Mention.TabIndex = 1;
            this.listView_Mention.UseCompatibleStateImageBehavior = false;
            this.listView_Mention.View = System.Windows.Forms.View.Details;
            this.listView_Mention.SelectedIndexChanged += new System.EventHandler(this.listView_Timeline_SelectedIndexChanged);
            this.listView_Mention.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_Timeline_MouseClick);
            this.listView_Mention.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Timeline_MouseDoubleClick);
            // 
            // columnHeader_MentionDate
            // 
            this.columnHeader_MentionDate.Text = "Date";
            this.columnHeader_MentionDate.Width = 155;
            // 
            // columnHeader_MentionUserId
            // 
            this.columnHeader_MentionUserId.Text = "UserId";
            this.columnHeader_MentionUserId.Width = 80;
            // 
            // columnHeader_MentionUserName
            // 
            this.columnHeader_MentionUserName.Text = "UserName";
            this.columnHeader_MentionUserName.Width = 100;
            // 
            // columnHeader_MentionText
            // 
            this.columnHeader_MentionText.Text = "Text";
            this.columnHeader_MentionText.Width = 220;
            // 
            // tabPage_Fav
            // 
            this.tabPage_Fav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tabPage_Fav.Controls.Add(this.listView_Fav);
            this.tabPage_Fav.ForeColor = System.Drawing.Color.AliceBlue;
            this.tabPage_Fav.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Fav.Name = "tabPage_Fav";
            this.tabPage_Fav.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Fav.Size = new System.Drawing.Size(578, 252);
            this.tabPage_Fav.TabIndex = 2;
            this.tabPage_Fav.Text = "Fav";
            // 
            // listView_Fav
            // 
            this.listView_Fav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.listView_Fav.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_Fav.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_FavDate,
            this.columnHeader_FavUserId,
            this.columnHeader_FavUserName,
            this.columnHeader_FavText});
            this.listView_Fav.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listView_Fav.ForeColor = System.Drawing.Color.AliceBlue;
            this.listView_Fav.FullRowSelect = true;
            this.listView_Fav.GridLines = true;
            this.listView_Fav.Location = new System.Drawing.Point(0, 0);
            this.listView_Fav.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView_Fav.MultiSelect = false;
            this.listView_Fav.Name = "listView_Fav";
            this.listView_Fav.Size = new System.Drawing.Size(580, 252);
            this.listView_Fav.TabIndex = 2;
            this.listView_Fav.UseCompatibleStateImageBehavior = false;
            this.listView_Fav.View = System.Windows.Forms.View.Details;
            this.listView_Fav.SelectedIndexChanged += new System.EventHandler(this.listView_Timeline_SelectedIndexChanged);
            this.listView_Fav.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_Timeline_MouseClick);
            this.listView_Fav.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Timeline_MouseDoubleClick);
            // 
            // columnHeader_FavDate
            // 
            this.columnHeader_FavDate.Text = "Date";
            this.columnHeader_FavDate.Width = 155;
            // 
            // columnHeader_FavUserId
            // 
            this.columnHeader_FavUserId.Text = "UserId";
            this.columnHeader_FavUserId.Width = 80;
            // 
            // columnHeader_FavUserName
            // 
            this.columnHeader_FavUserName.Text = "UserName";
            this.columnHeader_FavUserName.Width = 100;
            // 
            // columnHeader_FavText
            // 
            this.columnHeader_FavText.Text = "Text";
            this.columnHeader_FavText.Width = 220;
            // 
            // textBox_Input
            // 
            this.textBox_Input.AllowDrop = true;
            this.textBox_Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Input.ForeColor = System.Drawing.Color.AliceBlue;
            this.textBox_Input.Location = new System.Drawing.Point(58, 24);
            this.textBox_Input.Multiline = true;
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Input.Size = new System.Drawing.Size(477, 40);
            this.textBox_Input.TabIndex = 0;
            this.textBox_Input.TextChanged += new System.EventHandler(this.textBox_Input_TextChanged);
            this.textBox_Input.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_Input_DragDrop);
            this.textBox_Input.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox_Input_DragEnter);
            this.textBox_Input.Enter += new System.EventHandler(this.textBox_Input_Enter);
            this.textBox_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Input_KeyDown);
            // 
            // webBrowser_Detail
            // 
            this.webBrowser_Detail.Location = new System.Drawing.Point(12, 380);
            this.webBrowser_Detail.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_Detail.Name = "webBrowser_Detail";
            this.webBrowser_Detail.Size = new System.Drawing.Size(586, 93);
            this.webBrowser_Detail.TabIndex = 7;
            this.webBrowser_Detail.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser_Detail_Navigating);
            // 
            // label_InReplyTo
            // 
            this.label_InReplyTo.AutoSize = true;
            this.label_InReplyTo.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_InReplyTo.ForeColor = System.Drawing.Color.AliceBlue;
            this.label_InReplyTo.Location = new System.Drawing.Point(60, 64);
            this.label_InReplyTo.Name = "label_InReplyTo";
            this.label_InReplyTo.Size = new System.Drawing.Size(0, 14);
            this.label_InReplyTo.TabIndex = 7;
            // 
            // label_AppendFilesCount
            // 
            this.label_AppendFilesCount.AutoSize = true;
            this.label_AppendFilesCount.ForeColor = System.Drawing.Color.AliceBlue;
            this.label_AppendFilesCount.Location = new System.Drawing.Point(546, 49);
            this.label_AppendFilesCount.Name = "label_AppendFilesCount";
            this.label_AppendFilesCount.Size = new System.Drawing.Size(53, 15);
            this.label_AppendFilesCount.TabIndex = 9;
            this.label_AppendFilesCount.Text = "Files : 0";
            this.label_AppendFilesCount.Click += new System.EventHandler(this.label_AppendFilesCount_Click);
            // 
            // button_ResetReply
            // 
            this.button_ResetReply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_ResetReply.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_ResetReply.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_ResetReply.Location = new System.Drawing.Point(22, 71);
            this.button_ResetReply.Name = "button_ResetReply";
            this.button_ResetReply.Size = new System.Drawing.Size(23, 15);
            this.button_ResetReply.TabIndex = 2;
            this.button_ResetReply.Text = " X ";
            this.button_ResetReply.Visible = false;
            this.button_ResetReply.Click += new System.EventHandler(this.button_ResetReply_Click);
            // 
            // button_Tweet
            // 
            this.button_Tweet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Tweet.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Tweet.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_Tweet.Location = new System.Drawing.Point(545, 24);
            this.button_Tweet.Name = "button_Tweet";
            this.button_Tweet.Size = new System.Drawing.Size(54, 20);
            this.button_Tweet.TabIndex = 1;
            this.button_Tweet.Text = " Reload ";
            this.button_Tweet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Tweet.Click += new System.EventHandler(this.button_Tweet_Click);
            // 
            // button_AccountChange
            // 
            this.button_AccountChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_AccountChange.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_AccountChange.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_AccountChange.Location = new System.Drawing.Point(384, 0);
            this.button_AccountChange.Name = "button_AccountChange";
            this.button_AccountChange.Size = new System.Drawing.Size(108, 20);
            this.button_AccountChange.TabIndex = 11;
            this.button_AccountChange.Text = " Account Change ";
            this.button_AccountChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_AccountChange.Click += new System.EventHandler(this.button_AccountChange_Click);
            // 
            // label_Status
            // 
            this.label_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_Status.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Status.ForeColor = System.Drawing.Color.AliceBlue;
            this.label_Status.Location = new System.Drawing.Point(0, 480);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(610, 20);
            this.label_Status.TabIndex = 14;
            this.label_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Status.Click += new System.EventHandler(this.label_Status_Click);
            // 
            // timer_ShowStatus
            // 
            this.timer_ShowStatus.Enabled = true;
            this.timer_ShowStatus.Interval = 1000;
            this.timer_ShowStatus.Tick += new System.EventHandler(this.timer_ShowStatus_Tick);
            // 
            // pictureBox_UserIcon
            // 
            this.pictureBox_UserIcon.Location = new System.Drawing.Point(12, 23);
            this.pictureBox_UserIcon.Name = "pictureBox_UserIcon";
            this.pictureBox_UserIcon.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_UserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_UserIcon.TabIndex = 15;
            this.pictureBox_UserIcon.TabStop = false;
            // 
            // timer_ReStreaming
            // 
            this.timer_ReStreaming.Interval = 1000;
            this.timer_ReStreaming.Tick += new System.EventHandler(this.timer_ReStreaming_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "mik-Client";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 500);
            this.Controls.Add(this.pictureBox_UserIcon);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.button_ResetReply);
            this.Controls.Add(this.button_Tweet);
            this.Controls.Add(this.button_AccountChange);
            this.Controls.Add(this.label_AppendFilesCount);
            this.Controls.Add(this.label_InReplyTo);
            this.Controls.Add(this.webBrowser_Detail);
            this.Controls.Add(this.textBox_Input);
            this.Controls.Add(this.tabControl_Timeline);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "mik_Twitter_Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Main_KeyDown);
            this.Controls.SetChildIndex(this.tabControl_Timeline, 0);
            this.Controls.SetChildIndex(this.textBox_Input, 0);
            this.Controls.SetChildIndex(this.webBrowser_Detail, 0);
            this.Controls.SetChildIndex(this.label_InReplyTo, 0);
            this.Controls.SetChildIndex(this.label_AppendFilesCount, 0);
            this.Controls.SetChildIndex(this.button_AccountChange, 0);
            this.Controls.SetChildIndex(this.button_Tweet, 0);
            this.Controls.SetChildIndex(this.button_ResetReply, 0);
            this.Controls.SetChildIndex(this.label_Status, 0);
            this.Controls.SetChildIndex(this.pictureBox_UserIcon, 0);
            this.tabControl_Timeline.ResumeLayout(false);
            this.tabPage_Home.ResumeLayout(false);
            this.tabPage_Mention.ResumeLayout(false);
            this.tabPage_Fav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UserIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Home;
        private System.Windows.Forms.ColumnHeader columnHeader_HomeDate;
        private System.Windows.Forms.ColumnHeader columnHeader_HomeUserId;
        private System.Windows.Forms.ColumnHeader columnHeader_HomeUserName;
        private System.Windows.Forms.ColumnHeader columnHeader_HomeText;
        private System.Windows.Forms.TabControl tabControl_Timeline;
        private System.Windows.Forms.TabPage tabPage_Home;
        private System.Windows.Forms.TabPage tabPage_Mention;
        private System.Windows.Forms.ListView listView_Mention;
        private System.Windows.Forms.ColumnHeader columnHeader_MentionDate;
        private System.Windows.Forms.ColumnHeader columnHeader_MentionUserId;
        private System.Windows.Forms.ColumnHeader columnHeader_MentionUserName;
        private System.Windows.Forms.ColumnHeader columnHeader_MentionText;
        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.WebBrowser webBrowser_Detail;
        private System.Windows.Forms.Label label_InReplyTo;
        private System.Windows.Forms.Label label_AppendFilesCount;
        private System.Windows.Forms.TabPage tabPage_Fav;
        private System.Windows.Forms.ListView listView_Fav;
        private System.Windows.Forms.ColumnHeader columnHeader_FavDate;
        private System.Windows.Forms.ColumnHeader columnHeader_FavUserId;
        private System.Windows.Forms.ColumnHeader columnHeader_FavUserName;
        private System.Windows.Forms.ColumnHeader columnHeader_FavText;
        private System.Windows.Forms.ToolTip toolTip;
        private MyControls.Mik_LabelButton button_AccountChange;
        private MyControls.Mik_LabelButton button_Tweet;
        private MyControls.Mik_LabelButton button_ResetReply;
        private MyControls.Mik_Label label_Status;
        private System.Windows.Forms.Timer timer_ShowStatus;
        private System.Windows.Forms.PictureBox pictureBox_UserIcon;
        private System.Windows.Forms.Timer timer_ReStreaming;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

