namespace Twitter_Test
{
    partial class Form_Shell
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
            this.textBox_Console = new System.Windows.Forms.TextBox();
            this.label_01 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Console
            // 
            this.textBox_Console.BackColor = System.Drawing.Color.Black;
            this.textBox_Console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Console.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Console.ForeColor = System.Drawing.Color.AliceBlue;
            this.textBox_Console.Location = new System.Drawing.Point(18, 1);
            this.textBox_Console.Name = "textBox_Console";
            this.textBox_Console.Size = new System.Drawing.Size(180, 15);
            this.textBox_Console.TabIndex = 0;
            this.textBox_Console.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Console_KeyDown);
            // 
            // label_01
            // 
            this.label_01.AutoSize = true;
            this.label_01.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_01.ForeColor = System.Drawing.Color.AliceBlue;
            this.label_01.Location = new System.Drawing.Point(0, 1);
            this.label_01.Name = "label_01";
            this.label_01.Size = new System.Drawing.Size(21, 14);
            this.label_01.TabIndex = 1;
            this.label_01.Text = "> ";
            this.label_01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_Shell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(200, 17);
            this.Controls.Add(this.textBox_Console);
            this.Controls.Add(this.label_01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Shell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Shell";
            this.Load += new System.EventHandler(this.Form_Shell_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Console;
        private System.Windows.Forms.Label label_01;
    }
}