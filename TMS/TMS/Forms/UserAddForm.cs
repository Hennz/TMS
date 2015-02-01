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
    public partial class UserAddForm : Form
    {
        MasterController _controller;

        List<string> allUsernames;

        public UserAddForm(MasterController c)
        {
            InitializeComponent();

            _controller = c;

            allUsernames = _controller.GetAllUsernames();
        }

        private void txtCNP_TextChanged(object sender, EventArgs e)
        {
            if (!txtCNP.Text.Equals(txtNPW.Text))
            {
                epCNP.SetError(txtCNP, "Passwords do not match.");
                btnConfirm.Enabled = false;
            }
            else
            {
                epCNP.Clear();
                btnConfirm.Enabled = true;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!txtUsername.Text.Equals("") &&
                !txtFName.Text.Equals("") &&
                !txtLName.Text.Equals("") &&
                !txtNPW.Text.Equals("") &&
                !txtCNP.Text.Equals(""))    
            {
                bool didSucceed = _controller.UserCreate(txtUsername.Text, txtNPW.Text, txtFName.Text, txtLName.Text);

                if (didSucceed)
                {
                    MessageBox.Show("User account created: " + txtUsername.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    txtUsername.Text = "";
                    txtFName.Text = "";
                    txtLName.Text = "";
                    txtNPW.Text = "";
                    txtCNP.Text = "";

                    btnConfirm.Enabled = false;
                }
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (allUsernames.Contains(txtUsername.Text))
            {
                epUsername.SetError(txtUsername, "This username already exists");
            }
            else
            {
                epUsername.Clear();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _controller.ClosedUserAddForm();
        }
    }
}
