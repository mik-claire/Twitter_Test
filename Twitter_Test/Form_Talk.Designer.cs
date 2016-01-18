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
            this.button_Close = new MyControls.Mik_LabelButton();
            this.SuspendLayout();
            // 
            // webBrowser_Talk
            // 
            this.webBrowser_Talk.Location = new System.Drawing.Point(0, 21);
            this.webBrowser_Talk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.webBrowser_Talk.MinimumSize = new System.Drawing.Size(23, 25);
            this.webBrowser_Talk.Name = "webBrowser_Talk";
            this.webBrowser_Talk.Size = new System.Drawing.Size(580, 315);
            this.webBrowser_Talk.TabIndex = 0;
            this.webBrowser_Talk.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser_Talk_Navigating);
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Close.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Close.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_Close.Location = new System.Drawing.Point(522, 340);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(46, 15);
            this.button_Close.TabIndex = 3;
            this.button_Close.Text = " Close ";
            // 
            // Form_Talk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 358);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.webBrowser_Talk);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Talk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Talk";
            this.Load += new System.EventHandler(this.Form_Talk_Load);
            this.Controls.SetChildIndex(this.webBrowser_Talk, 0);
            this.Controls.SetChildIndex(this.button_Close, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser_Talk;
        private MyControls.Mik_LabelButton button_Close;
    }
}