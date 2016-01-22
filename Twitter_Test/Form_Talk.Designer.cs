namespace Twitter_Test
{
    partial class Form_Talk
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
            this.webBrowser_Talk = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowser_Talk
            // 
            this.webBrowser_Talk.Location = new System.Drawing.Point(6, 24);
            this.webBrowser_Talk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.webBrowser_Talk.MinimumSize = new System.Drawing.Size(23, 25);
            this.webBrowser_Talk.Name = "webBrowser_Talk";
            this.webBrowser_Talk.Size = new System.Drawing.Size(568, 328);
            this.webBrowser_Talk.TabIndex = 0;
            this.webBrowser_Talk.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser_Talk_Navigating);
            // 
            // Form_Talk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 358);
            this.Controls.Add(this.webBrowser_Talk);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Talk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Talk";
            this.Load += new System.EventHandler(this.Form_Talk_Load);
            this.Controls.SetChildIndex(this.webBrowser_Talk, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser_Talk;
    }
}