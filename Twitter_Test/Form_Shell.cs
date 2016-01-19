using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twitter_Test
{
    public partial class Form_Shell : Form
    {
        public Form_Shell()
        {
            InitializeComponent();
        }

        private string command = string.Empty;
        public string Command
        {
            get
            {
                return this.command;
            }
            set
            {
                this.command = value;
            }
        }

        private void Form_Shell_Load(object sender, EventArgs e)
        {
            this.textBox_Console.Focus();
            this.Size = new Size(200, 17);
        }

        private void textBox_Console_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            this.command = this.textBox_Console.Text.Trim();
            this.Close();
        }
    }
}
