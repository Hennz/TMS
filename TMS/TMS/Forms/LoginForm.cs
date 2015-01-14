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
    public partial class LoginForm : Form
    {
        MasterController _controller;

        public LoginForm()
        {
            InitializeComponent();
            _controller = new MasterController(this);
        }
        public void SetController(MasterController c)
        {
            _controller = c;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            _controller.Login(txtUsername.Text, txtPassword.Text, chkRemember.Checked);

        }

    }
}
