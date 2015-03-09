using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS
{
    public partial class MessagesSendForm : Form
    {
        MessagingController _controller;
        
        public MessagesSendForm(MessagingController c, bool isDefaultBroadcast)
        {
            InitializeComponent();

            _controller = c;

            lblUsername.Text = User.GetInstance().username;
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

            foreach (Member member in MineSite.GetInstance().siteMembers.Values)
            {
                lstMembers.Items.Add(member);
            }

            rbBroadcast.Checked = isDefaultBroadcast;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            _controller.SendMessage(rbBroadcast.Checked, txtContent.Text);
        }

        private void rbBroadcast_CheckedChanged(object sender, EventArgs e)
        {
            lstMembers.Enabled = !rbBroadcast.Checked;
            txtContent.Enabled = rbBroadcast.Checked;

        }
    }
}
