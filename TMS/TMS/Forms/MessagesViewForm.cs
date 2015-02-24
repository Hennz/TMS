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
    public partial class MessagesViewForm : Form
    {
        MessagingController _controller;

        public MessagesViewForm(MessagingController c)
        {
            InitializeComponent();

            _controller = c;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _controller.ClosedViewForm();
        }
    }
}
