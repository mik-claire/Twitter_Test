namespace Twitter_Test.Properties
{
    partial class Form_SelectAccount
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
            this.button_Cancel = new MyControls.Mik_LabelButton();
            this.listView_Account = new System.Windows.Forms.ListView();
            this.columnHeader_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_01 = new System.Windows.Forms.Label();
            this.button_Add = new MyControls.Mik_LabelButton();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.AutoSize = true;
            this.button_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Cancel.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Cancel.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_Cancel.Location = new System.Drawing.Point(235, 156);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(53, 15);
            this.button_Cancel.TabIndex = 3;
            this.button_Cancel.Text = " Cancel ";
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // listView_Account
            // 
            this.listView_Account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.listView_Account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_Account.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_ID,
            this.columnHeader_Name});
            this.listView_Account.ForeColor = System.Drawing.Color.AliceBlue;
            this.listView_Account.FullRowSelect = true;
            this.listView_Account.GridLines = true;
            this.listView_Account.Location = new System.Drawing.Point(12, 46);
            this.listView_Account.MultiSelect = false;
            this.listView_Account.Name = "listView_Account";
            this.listView_Account.Size = new System.Drawing.Size(276, 97);
            this.listView_Account.TabIndex = 4;
            this.listView_Account.UseCompatibleStateImageBehavior = false;
            this.listView_Account.View = System.Windows.Forms.View.Details;
            this.listView_Account.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Account_MouseDoubleClick);
            // 
            // columnHeader_ID
            // 
            this.columnHeader_ID.Text = "ID";
            this.columnHeader_ID.Width = 120;
            // 
            // columnHeader_Name
            // 
            this.columnHeader_Name.Text = "Name";
            this.columnHeader_Name.Width = 140;
            // 
            // label_01
            // 
            this.label_01.AutoSize = true;
            this.label_01.ForeColor = System.Drawing.Color.AliceBlue;
            this.label_01.Location = new System.Drawing.Point(12, 25);
            this.label_01.Name = "label_01";
            this.label_01.Size = new System.Drawing.Size(181, 15);
            this.label_01.TabIndex = 5;
            this.label_01.Text = "DoubleClick to select account.";
            // 
            // button_Add
            // 
            this.button_Add.AutoSize = true;
            this.button_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Add.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Add.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_Add.Location = new System.Drawing.Point(192, 156);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(37, 15);
            this.button_Add.TabIndex = 6;
            this.button_Add.Text = " Add ";
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // Form_SelectAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 182);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label_01);
            this.Controls.Add(this.listView_Account);
            this.Controls.Add(this.button_Cancel);
            this.Name = "Form_SelectAccount";
            this.Text = "Form_SelectAccount";
            this.Load += new System.EventHandler(this.Form_SelectAccount_Load);
            this.Controls.SetChildIndex(this.button_Cancel, 0);
            this.Controls.SetChildIndex(this.listView_Account, 0);
            this.Controls.SetChildIndex(this.label_01, 0);
            this.Controls.SetChildIndex(this.button_Add, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControls.Mik_LabelButton button_Cancel;
        private System.Windows.Forms.ListView listView_Account;
        private System.Windows.Forms.ColumnHeader columnHeader_ID;
        private System.Windows.Forms.ColumnHeader columnHeader_Name;
        private System.Windows.Forms.Label label_01;
        private MyControls.Mik_LabelButton button_Add;
    }
}