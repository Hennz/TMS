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

        public MessagesSendForm(MessagingController c)
        {
            InitializeComponent();

            _controller = c;

            lblUsername.Text = User.GetInstance().username;
            lblDate.Text = DateTime.Now.ToString("YYYY-MM-DD");
        }
    }
}
