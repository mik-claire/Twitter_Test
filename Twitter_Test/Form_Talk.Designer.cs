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
            this.button_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser_Talk
            // 
            this.webBrowser_Talk.Location = new System.Drawing.Point(12, 13);
            this.webBrowser_Talk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.webBrowser_Talk.MinimumSize = new System.Drawing.Size(23, 25);
            this.webBrowser_Talk.Name = "webBrowser_Talk";
            this.webBrowser_Talk.Size = new System.Drawing.Size(556, 301);
            this.webBrowser_Talk.TabIndex = 0;
            this.webBrowser_Talk.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser_Talk_Navigating);
            // 
            // button_Close
            // 
            this.button_Close.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Close.Location = new System.Drawing.Point(493, 322);
            this.button_Close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 23);
            this.button_Close.TabIndex = 1;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // Form_Talk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 358);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.webBrowser_Talk);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form_Talk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Talk";
            this.Load += new System.EventHandler(this.Form_Talk_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser_Talk;
        private System.Windows.Forms.Button button_Close;
    }
}