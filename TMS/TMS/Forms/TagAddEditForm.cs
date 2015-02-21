using System;
using System.Collections;
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
    public partial class TagAddEditForm : Form
    {
        MasterController _controller;

        public TagAddEditForm(MasterController c)
        {
            InitializeComponent();

            _controller = c;

            LoadAllTags();
        }

        private void LoadAllTags()
        {
            lstTags.Items.Clear();

            Dictionary<string, bool> tagsAssigned = _controller.GetAllTagsAssigned();

            foreach (KeyValuePair<string, bool> entry in tagsAssigned)
            {
                lstTags.Items.Add(entry.Key + "\t" + (entry.Value ? "\u2713" : "X"));
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool didComplete = _controller.TagCreate(mtxtNewTag.Text);

            if (didComplete)
            {
                mtxtNewTag.Text = "";
                LoadAllTags();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ((lstTags.SelectedItem.ToString()).Split('\t')[1] == "X") 
            {
                bool didComplete = _controller.TagDelete(lstTags.SelectedItem.ToString().Split('\t')[0]);

                if (didComplete)
                {
                    LoadAllTags();
                    mtxtNewTag.Text = "";
                }
            }
            else
            {
                MessageBox.Show("This tag is assigned to a member.", "Could Not Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mtxtNewTag_TextChanged(object sender, EventArgs e)
        {
            // Enable / disable the button if the text is filled / empty
            btnCreate.Enabled = !mtxtNewTag.Text.Equals("");
        }

        private void lstTags_SelectedValueChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = (lstTags.SelectedItems.Count > 0);
        }

    }
}
