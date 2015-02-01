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
    public partial class UserEditForm : Form
    {
        MasterController _controller;

        public UserEditForm(MasterController c)
        {
            InitializeComponent();

            _controller = c;

            lblUsername.Text = User.GetInstance().username + " - " + (User.GetInstance().isAdmin ? "Administrator" : "Regular User");
            txtFName.Text = User.GetInstance().fName;
            txtLName.Text = User.GetInstance().lName;
        }

        private void llblNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (User.GetInstance().isAdmin)
            {
                _controller.OpenCreateUser();
            }
            else
            {
                MessageBox.Show("Only Administrators are able to add new user accounts.", "Access Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void txtCNP_Leave(object sender, EventArgs e)
        {
            if (!txtCNP.Text.Equals(txtNPW.Text))
            {
                epPassword.SetError(txtCNP, "Password do not match.");
            }
            else
            {
                epPassword.Clear();
            }
        }

        private void chkPW_CheckedChanged(object sender, EventArgs e)
        {
            pnlNewPW.Enabled = chkPW.Checked;
        }

        private void btnNewPass_Click(object sender, EventArgs e)
        {
            if (txtCNP.Text.Equals(txtNPW.Text))
            {
                if (_controller.Authenticate(User.GetInstance().username, txtOPW.Text) == 0)
                {
                    bool didSucceed = _controller.UserPasswordUpdate(txtNPW.Text);

                    if (didSucceed)
                    {
                        btnSave.Enabled = false;

                        MessageBox.Show("You've successfully changed Your password.", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        chkPW.Checked = false;
                        txtOPW.Text = "";
                        txtNPW.Text = "";
                        txtCNP.Text = "";
                
                    }
                    else
                    {
                        MessageBox.Show("Password could not be changed", "Password Change Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!txtFName.Text.Equals("") && !txtLName.Text.Equals(""))
            {
                bool didSucceed = _controller.UserUpdate(txtFName.Text, txtLName.Text);
                if (didSucceed)
                {
                    btnSave.Enabled = false;

                    MessageBox.Show("User details successfully updated", "User Updated", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
                else
                {
                    MessageBox.Show("User details could not be updated", "User Update Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
