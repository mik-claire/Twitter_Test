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

namespace Twitter_Test.Properties
{
    public partial class Form_SelectAccount : Mik_Form
    {
        public Form_SelectAccount()
        {
            InitializeComponent();
            this.Title = "Select your account.";
        }

        private void Form_SelectAccount_Load(object sender, EventArgs e)
        {

        }

        private void listView_Account_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
