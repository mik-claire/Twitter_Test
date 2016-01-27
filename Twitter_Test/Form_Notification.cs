using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyControls;
using CoreTweet;

namespace Twitter_Test
{
    public partial class Form_Notification : Mik_Form
    {
        public Form_Notification(NotificationStatus notificationStatus, Status tweet)
        {
            InitializeComponent();

            this.Title = notificationStatus.ToString();
            this.Text = this.Title;
        }

        private void Form_Notification_Load(object sender, EventArgs e)
        {
            
        }
    }
}
