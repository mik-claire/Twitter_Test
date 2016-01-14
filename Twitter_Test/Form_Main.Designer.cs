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
            this.listView_Home = new System.Windows.Forms.ListView();
            this.columnHeader_HomeDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_HomeId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_HomeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_HomeText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl_Timeline = new System.Windows.Forms.TabControl();
            this.tabPage_Home = new System.Windows.Forms.TabPage();
            this.tabPage_Mention = new System.Windows.Forms.TabPage();
            this.listView_Mention = new System.Windows.Forms.ListView();
            this.columnHeader_MentionDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_MentionUserId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_MentionUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_MentionText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.button_Tweet = new System.Windows.Forms.Button();
            this.webBrowser_Detail = new System.Windows.Forms.WebBrowser();
            this.label_InReplyTo = new System.Windows.Forms.Label();
            this.button_ResetReply = new System.Windows.Forms.Button();
            this.tabControl_Timeline.SuspendLayout();
            this.tabPage_Home.SuspendLayout();
            this.tabPage_Mention.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_Home
            // 
            this.listView_Home.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_HomeDate,
            this.columnHeader_HomeId,
            this.columnHeader_HomeName,
            this.columnHeader_HomeText});
            this.listView_Home.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listView_Home.FullRowSelect = true;
            this.listView_Home.GridLines = true;
            this.listView_Home.Location = new System.Drawing.Point(0, 0);
            this.listView_Home.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView_Home.MultiSelect = false;
            this.listView_Home.Name = "listView_Home";
            this.listView_Home.Size = new System.Drawing.Size(578, 252);
            this.listView_Home.TabIndex = 0;
            this.listView_Home.UseCompatibleStateImageBehavior = false;
            this.listView_Home.View = System.Windows.Forms.View.Details;
            this.listView_Home.SelectedIndexChanged += new System.EventHandler(this.listView_Timeline_SelectedIndexChanged);
            this.listView_Home.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Timeline_MouseDoubleClick);
            // 
            // columnHeader_HomeDate
            // 
            this.columnHeader_HomeDate.Text = "Date";
            this.columnHeader_HomeDate.Width = 155;
            // 
            // columnHeader_HomeId
            // 
            this.columnHeader_HomeId.Text = "UserId";
            this.columnHeader_HomeId.Width = 80;
            // 
            // columnHeader_HomeName
            // 
            this.columnHeader_HomeName.Text = "UserName";
            this.columnHeader_HomeName.Width = 100;
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
            this.tabControl_Timeline.Location = new System.Drawing.Point(12, 12);
            this.tabControl_Timeline.Name = "tabControl_Timeline";
            this.tabControl_Timeline.SelectedIndex = 0;
            this.tabControl_Timeline.Size = new System.Drawing.Size(586, 280);
            this.tabControl_Timeline.TabIndex = 4;
            // 
            // tabPage_Home
            // 
            this.tabPage_Home.Controls.Add(this.listView_Home);
            this.tabPage_Home.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Home.Name = "tabPage_Home";
            this.tabPage_Home.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Home.Size = new System.Drawing.Size(578, 252);
            this.tabPage_Home.TabIndex = 0;
            this.tabPage_Home.Text = "Home";
            this.tabPage_Home.UseVisualStyleBackColor = true;
            // 
            // tabPage_Mention
            // 
            this.tabPage_Mention.Controls.Add(this.listView_Mention);
            this.tabPage_Mention.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Mention.Name = "tabPage_Mention";
            this.tabPage_Mention.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Mention.Size = new System.Drawing.Size(578, 252);
            this.tabPage_Mention.TabIndex = 1;
            this.tabPage_Mention.Text = "Mention";
            this.tabPage_Mention.UseVisualStyleBackColor = true;
            // 
            // listView_Mention
            // 
            this.listView_Mention.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_MentionDate,
            this.columnHeader_MentionUserId,
            this.columnHeader_MentionUserName,
            this.columnHeader_MentionText});
            this.listView_Mention.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listView_Mention.FullRowSelect = true;
            this.listView_Mention.GridLines = true;
            this.listView_Mention.Location = new System.Drawing.Point(0, 0);
            this.listView_Mention.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView_Mention.MultiSelect = false;
            this.listView_Mention.Name = "listView_Mention";
            this.listView_Mention.Size = new System.Drawing.Size(578, 252);
            this.listView_Mention.TabIndex = 1;
            this.listView_Mention.UseCompatibleStateImageBehavior = false;
            this.listView_Mention.View = System.Windows.Forms.View.Details;
            this.listView_Mention.SelectedIndexChanged += new System.EventHandler(this.listView_Timeline_SelectedIndexChanged);
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
            // textBox_Input
            // 
            this.textBox_Input.Location = new System.Drawing.Point(12, 428);
            this.textBox_Input.Multiline = true;
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(505, 40);
            this.textBox_Input.TabIndex = 5;
            this.textBox_Input.TextChanged += new System.EventHandler(this.textBox_Input_TextChanged);
            this.textBox_Input.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_Input_DragDrop);
            this.textBox_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Input_KeyDown);
            // 
            // button_Tweet
            // 
            this.button_Tweet.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Tweet.Location = new System.Drawing.Point(523, 445);
            this.button_Tweet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Tweet.Name = "button_Tweet";
            this.button_Tweet.Size = new System.Drawing.Size(75, 23);
            this.button_Tweet.TabIndex = 6;
            this.button_Tweet.Text = "Reload";
            this.button_Tweet.UseVisualStyleBackColor = true;
            this.button_Tweet.Click += new System.EventHandler(this.button_Tweet_Click);
            // 
            // webBrowser_Detail
            // 
            this.webBrowser_Detail.Location = new System.Drawing.Point(12, 300);
            this.webBrowser_Detail.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_Detail.Name = "webBrowser_Detail";
            this.webBrowser_Detail.Size = new System.Drawing.Size(586, 93);
            this.webBrowser_Detail.TabIndex = 2;
            this.webBrowser_Detail.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser_Detail_Navigating);
            // 
            // label_InReplyTo
            // 
            this.label_InReplyTo.AutoSize = true;
            this.label_InReplyTo.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_InReplyTo.Location = new System.Drawing.Point(50, 396);
            this.label_InReplyTo.Name = "label_InReplyTo";
            this.label_InReplyTo.Size = new System.Drawing.Size(0, 14);
            this.label_InReplyTo.TabIndex = 7;
            // 
            // button_ResetReply
            // 
            this.button_ResetReply.Location = new System.Drawing.Point(12, 399);
            this.button_ResetReply.Name = "button_ResetReply";
            this.button_ResetReply.Size = new System.Drawing.Size(23, 23);
            this.button_ResetReply.TabIndex = 8;
            this.button_ResetReply.Text = "X";
            this.button_ResetReply.UseVisualStyleBackColor = true;
            this.button_ResetReply.Visible = false;
            this.button_ResetReply.Click += new System.EventHandler(this.button_ResetReply_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 478);
            this.Controls.Add(this.button_ResetReply);
            this.Controls.Add(this.label_InReplyTo);
            this.Controls.Add(this.webBrowser_Detail);
            this.Controls.Add(this.button_Tweet);
            this.Controls.Add(this.textBox_Input);
            this.Controls.Add(this.tabControl_Timeline);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.tabControl_Timeline.ResumeLayout(false);
            this.tabPage_Home.ResumeLayout(false);
            this.tabPage_Mention.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Home;
        private System.Windows.Forms.ColumnHeader columnHeader_HomeDate;
        private System.Windows.Forms.ColumnHeader columnHeader_HomeId;
        private System.Windows.Forms.ColumnHeader columnHeader_HomeName;
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
        private System.Windows.Forms.Button button_Tweet;
        private System.Windows.Forms.WebBrowser webBrowser_Detail;
        private System.Windows.Forms.Label label_InReplyTo;
        private System.Windows.Forms.Button button_ResetReply;
    }
}

