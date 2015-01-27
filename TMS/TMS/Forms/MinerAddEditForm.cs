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
    public partial class MinerAddEditForm : Form
    {
        MasterController _controller;

        Member member;
        public MinerAddEditForm(MasterController c)
        {
            InitializeComponent();

            _controller = c;

            LoadMembersList();
            LoadTagsList();

            cboTags.SelectedIndex = 0;
            rbNew.Checked = true;
        }

        private void ClearInput()
        {
            txtMID.Text = "";
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
            cboTags.SelectedIndex = 0;
        }

        private void EnterCreate(object sender, EventArgs e)
        {
            if (cboTags.SelectedItem != null)
            {
                int errorCode = _controller.MemberCreate(txtMID.Text,
                    txtFName.Text, txtMName.Text, txtLName.Text,
                    txtAddr.Text, txtProv.Text, txtCity.Text,
                    Int32.Parse(mtxtPin.Text),
                    mtxtPhone.Text, mtxtMobile.Text,
                    chkIsVehicle.Checked,
                    (string)(cboTags.SelectedItem));

                if (errorCode == 0)
                {
                    ClearInput();

                    LoadMembersList();
                }
            }
        }

        private void EnterUpdate(object sender, EventArgs e)
        {
            int errorCode = _controller.MemberUpdate(member, txtMID.Text,
                txtFName.Text, txtMName.Text, txtLName.Text,
                txtAddr.Text, txtProv.Text, txtCity.Text,
                Int32.Parse(mtxtPin.Text),
                mtxtPhone.Text, mtxtMobile.Text,
                chkIsVehicle.Checked,
                (string)(cboTags.SelectedItem));

            if (errorCode == 0)
            {
                ClearInput();

                LoadMembersList();
                lstMembers.SelectedItem = member;
            }
        }

        /// <summary>
        /// Clears the current members and loads all members into the combo box
        /// </summary>
        private void LoadMembersList()
        {
            lstMembers.Items.Clear();

            foreach (Member member in MineSite.GetInstance().siteMembers)
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

                btnEnter.Click -= EnterUpdate;
                btnEnter.Click += EnterCreate;

                btnShift.Enabled = false;
                btnShift.Text = "Assign Shifts";
            }
        }

        private void rbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUpdate.Checked && member != null)
            {
                txtMID.Enabled = false;

                // Fill text boxes with values
                txtMID.Text = member.memberId;
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
                cboTags.SelectedValue = member.tagId;

                btnEnter.Click -= EnterCreate;
                btnEnter.Click += EnterUpdate;

                btnShift.Enabled = true;
                btnShift.Text = "Edit Shifts";
            }
        }

        private void lstMembers_SelectedValueChanged(object sender, EventArgs e)
        {
            member = (Member)(lstMembers.SelectedItem);

            rbUpdate.Checked = true;
        }
    }
}
