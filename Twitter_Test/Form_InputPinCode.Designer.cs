﻿namespace Twitter_Test
{
    partial class Form_InputPinCode
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
            this.label_01 = new System.Windows.Forms.Label();
            this.textBox_PINcode = new System.Windows.Forms.TextBox();
            this.button_OK = new MyControls.Mik_LabelButton();
            this.button_Exit = new MyControls.Mik_LabelButton();
            this.SuspendLayout();
            // 
            // label_01
            // 
            this.label_01.AutoSize = true;
            this.label_01.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_01.ForeColor = System.Drawing.Color.AliceBlue;
            this.label_01.Location = new System.Drawing.Point(3, 28);
            this.label_01.Name = "label_01";
            this.label_01.Size = new System.Drawing.Size(171, 30);
            this.label_01.TabIndex = 0;
            this.label_01.Text = "Please enter the PIN code is\r\ndisplayed in the blowser.";
            // 
            // textBox_PINcode
            // 
            this.textBox_PINcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_PINcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_PINcode.ForeColor = System.Drawing.Color.AliceBlue;
            this.textBox_PINcode.Location = new System.Drawing.Point(12, 68);
            this.textBox_PINcode.Name = "textBox_PINcode";
            this.textBox_PINcode.Size = new System.Drawing.Size(168, 16);
            this.textBox_PINcode.TabIndex = 0;
            this.textBox_PINcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_PINcode_KeyDown);
            // 
            // button_OK
            // 
            this.button_OK.AutoSize = true;
            this.button_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_OK.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_OK.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_OK.Location = new System.Drawing.Point(102, 94);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(32, 15);
            this.button_OK.TabIndex = 1;
            this.button_OK.Text = " OK ";
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.AutoSize = true;
            this.button_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Exit.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Exit.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_Exit.Location = new System.Drawing.Point(143, 94);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(37, 15);
            this.button_Exit.TabIndex = 2;
            this.button_Exit.Text = " Exit ";
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // Form_InputPinCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 118);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.textBox_PINcode);
            this.Controls.Add(this.label_01);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_InputPinCode";
            this.Text = "Form_InputPinCode";
            this.Load += new System.EventHandler(this.Form_InputPinCode_Load);
            this.Controls.SetChildIndex(this.label_01, 0);
            this.Controls.SetChildIndex(this.textBox_PINcode, 0);
            this.Controls.SetChildIndex(this.button_OK, 0);
            this.Controls.SetChildIndex(this.button_Exit, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_01;
        private System.Windows.Forms.TextBox textBox_PINcode;
        private MyControls.Mik_LabelButton button_OK;
        private MyControls.Mik_LabelButton button_Exit;
    }
}