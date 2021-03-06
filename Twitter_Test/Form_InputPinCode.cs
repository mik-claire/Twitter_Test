﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLib;
using MyControls;

namespace Twitter_Test
{
    public partial class Form_InputPinCode : Mik_Form
    {
        public Form_InputPinCode(string url)
        {
            InitializeComponent();
            this.authorizeUrl = url;
            this.Title = "Startup.";
        }

        /// <summary>
        /// PINコード
        /// </summary>
        private string pinCode = string.Empty;
        public string PinCode { get { return this.pinCode; } }

        /// <summary>
        /// 認証用URL
        /// </summary>
        private string authorizeUrl = string.Empty;

        private void Form_InputPinCode_Load(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(this.authorizeUrl);
            }
            catch (Exception ex)
            {
                MyClass util = new MyClass();
                util.ShowExceptionMessageBox(ex.Message, ex.StackTrace);
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            enterPinCode(this.textBox_PINcode.Text);
        }

        private void textBox_PINcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enterPinCode(this.textBox_PINcode.Text);
            }
        }

        private void enterPinCode(string input)
        {
            int pin = 0;
            if (!int.TryParse(this.textBox_PINcode.Text, out pin) ||
                this.textBox_PINcode.Text.Length != 7)
            {
                MessageBox.Show("It is not PIN code.",
                    "Error!!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            this.pinCode = this.textBox_PINcode.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
