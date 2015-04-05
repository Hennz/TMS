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
    public partial class MemberAddEditForm : Form
    {
        MasterController _controller;

        Member member;
        public MemberAddEditForm(MasterController c)
        {
            InitializeComponent();

            _controller = c;

            LoadMembersList();
            LoadTagsList();

            if (cboTags.Items.Count > 0)
            {
                cboTags.SelectedItem = cboTags.Items.IndexOf(0);
            }
            else
            {
                DialogResult result = MessageBox.Show("There are no free End Device tags. \nCreate a new tag ID from the Tag menu?", "No tags", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    _controller.OpenCreateTag();
                    Close();
                }
            }

            rbNew.Checked = true;
        }

        private void ClearInput()
        {
            mtxtMID.Text = "M";
            txtFName.Text = "";
            txtMName.Text = "";
            txtLName.Text = "";
            mtxtPin.Text = "";

            mtxtPhone.Text = "";
            mtxtMobile.Text = "";

            txtAddr.Text = "";
            txtProv.Text = "";
            txtCity.Text = "";

            chkIsVehicle.Checked = false;

            if (cboTags.Items.Count > 0)
            {
                cboTags.SelectedIndex = 0;
            }
        }

        private void EnterCreate(object sender, EventArgs e)
        {
            if (cboTags.SelectedItem != null && 
                !mtxtMID.Text.Equals("") &&
                !mtxtPin.Text.Equals("") &&
                !txtFName.Text.Equals("") &&
                !txtLName.Text.Equals("") &&
                !txtAddr.Text.Equals("") &&
                !txtProv.Text.Equals("") &&
                !txtCity.Text.Equals("") &&
                !mtxtPhone.Text.Equals("")
                )
            {
                bool didComplete = _controller.MemberCreate(mtxtMID.Text,
                    txtFName.Text, txtMName.Text, txtLName.Text,
                    txtAddr.Text, txtProv.Text, txtCity.Text,
                    Int32.Parse(mtxtPin.Text),
                    mtxtPhone.Text, mtxtMobile.Text,
                    chkIsVehicle.Checked,
                    (string)(cboTags.Items[cboTags.SelectedIndex]));

                if (didComplete)
                {
                    ClearInput();

                    LoadMembersList();
                }
                else
                {
                    MessageBox.Show("The member could not be created.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill out all mandatory fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnterUpdate(object sender, EventArgs e)
        {
            if (mtxtMID.Text.Equals("M"))
            {
                return;
            }

            bool didComplete = _controller.MemberUpdate(member, mtxtMID.Text,
                txtFName.Text, txtMName.Text, txtLName.Text,
                txtAddr.Text, txtProv.Text, txtCity.Text,
                Int32.Parse(mtxtPin.Text),
                mtxtPhone.Text, mtxtMobile.Text,
                chkIsVehicle.Checked,
                (string)(cboTags.Items[cboTags.SelectedIndex]));

            if (didComplete)
            {
                rbNew.Checked = true;

                LoadMembersList();
            }
        }

        /// <summary>
        /// Clears the current members and loads all members into the combo box
        /// </summary>
        private void LoadMembersList()
        {
            lstMembers.Items.Clear();

            foreach (Member member in MineSite.GetInstance().siteMembers.Values)
            {
                lstMembers.Items.Add(member);
            }
        }

        /// <summary>
        /// Clears the current tags and loads all tag IDs into the combo box
        /// </summary>
        private void LoadTagsList()
        {
            cboTags.Items.Clear();

            List<string> tags = _controller.RetrieveTagIDList();

            foreach (string tag in tags)
            {
                cboTags.Items.Add(tag);
            }

        }

        /// <summary>
        /// Open shift form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShift_Click(object sender, EventArgs e)
        {
            _controller.OpenAssignShift(member);
        }

        private void rbNew_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNew.Checked)
            {
                ClearInput();
                LoadTagsList();

                btnEnter.Click -= EnterUpdate;
                btnEnter.Click += EnterCreate;

                btnShift.Enabled = false;
                btnShift.Text = "Assign Shifts";

                mtxtMID.Enabled = true;
                btnDelete.Enabled = false;
            }
        }

        private void rbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            // Set to new input if there are no registered members
            if (lstMembers.Items.Count == 0)
            {
                rbNew.Checked = true;
            }

            // Automatically select the first member
            if (member == null)
            {
                lstMembers.SelectedIndex = 0;
                member = (Member)lstMembers.Items[0];
            }

            // Fill in the details of the selected member
            if (rbUpdate.Checked)
            {
                mtxtMID.Enabled = false;

                // Fill text boxes with values
                mtxtMID.Text = member.memberId;
                txtFName.Text = member.fName;
                txtMName.Text = member.mName;
                txtLName.Text = member.lName;
                mtxtPin.Text = "" + member.pinNo;

                mtxtPhone.Text = member.phoneNo;
                mtxtMobile.Text = member.mobileNo;

                txtAddr.Text = member.address;
                txtProv.Text = member.province;
                txtCity.Text = member.city;

                chkIsVehicle.Checked = member.isVehicle;

                LoadTagsList();
                cboTags.Items.Add(member.tagId);
                cboTags.SelectedIndex = cboTags.Items.IndexOf(member.tagId);

                btnEnter.Click -= EnterCreate;
                btnEnter.Click += EnterUpdate;

                btnShift.Enabled = true;
                btnShift.Text = "Edit Shifts";

                btnDelete.Enabled = true;
            }
        }

        private void lstMembers_SelectedValueChanged(object sender, EventArgs e)
        {
            member = (Member)(lstMembers.SelectedItem);

            rbUpdate.Checked = false;
            rbUpdate.Checked = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool didComplete = _controller.MemberDelete(member);

            if (didComplete)
            {
                rbNew.Checked = true;

                LoadMembersList();
            }
        }
    }
}
