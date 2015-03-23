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

            if (Properties.Settings.Default.ShouldRemember)
            {
                chkRemember.CheckState = CheckState.Checked;
                txtUsername.Text = Properties.Settings.Default.Username;

                cboMineSites.SelectedIndex = cboMineSites.Items.IndexOf(Properties.Settings.Default.MineSite);
            }        
        }
        public void SetController(MasterController c)
        {
            _controller = c;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" &&
                txtPassword.Text != "")   {
                int error = _controller.Authenticate(txtUsername.Text, txtPassword.Text);

                if (error == 0)
                {
                    // Save username and if should remember
                    Properties.Settings.Default.ShouldRemember = chkRemember.Checked;
                    Properties.Settings.Default.Username = chkRemember.Checked ? txtUsername.Text : "";
                    Properties.Settings.Default.MineSite = chkRemember.Checked ? (int)cboMineSites.SelectedValue : -1;

                    Properties.Settings.Default.Save();

                    _controller.OpenMainForm((int)cboMineSites.SelectedValue);
                }
                else if (error == 1)
                {
                    MessageBox.Show("Invalid username", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (error == 2)
                {
                    MessageBox.Show("Invalid password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnLogin_Click(sender, e);

                e.Handled = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tMS_MineSiteDataSet.Site' table. You can move, or remove it, as needed.
            this.siteTableAdapter.Fill(this.tMS_MineSiteDataSet.Site);

        }

    }
}
