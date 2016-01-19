using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLib;
using MyControls;

using CoreTweet;
using CoreTweet.Core;

namespace Twitter_Test
{
    public partial class Form_SelectAccount : Mik_Form
    {
        public Form_SelectAccount()
        {
            InitializeComponent();
            this.Title = "Select your account.";
        }

        private int accountNumber = 0;
        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        private int selectedResult = 0;
        public int SelectedResult
        {
            get { return this.selectedResult; }
            set { this.selectedResult = value; }
        }

        private void Form_SelectAccount_Load(object sender, EventArgs e)
        {
            foreach (var tokenData in Properties.Settings.Default.AccessTokenList)
            {
                string[] data = tokenData.Split(',');
                ListViewItem item = new ListViewItem(data);
                this.listView_Account.Items.Add(item);
            }
        }

        private void listView_Account_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // 左クリック判定
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            // フォーカス判定
            ListViewItem item = this.listView_Account.FocusedItem;
            if (!this.listView_Account.FocusedItem.Bounds.Contains(e.Location))
            {
                return;
            }

            this.accountNumber = this.listView_Account.SelectedIndices[0];
            this.selectedResult = 1;
            this.Close();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            this.selectedResult = 2;
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
