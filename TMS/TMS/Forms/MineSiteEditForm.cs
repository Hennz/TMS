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
    public partial class MineSiteEditForm : Form
    {
        MasterController _controller;

        public MineSiteEditForm(MasterController c)
        {
            InitializeComponent();

            _controller = c;

            LoadAllInfo();
        }

        private void LoadAllInfo()
        {
            // Fill labels
            llblName.Text = MineSite.GetInstance().siteName;
            lblScale.Text = "Current Map Scale: " + MineSite.GetInstance().mapScale;
            lblPath.Text = MineSite.GetInstance().localMapFileAddr;

            // Fill list of miners
            foreach (Member member in MineSite.GetInstance().siteMembers.Values)
            {
                lstMiners.Items.Add(member);

            }

            // Fill list of routers
            foreach (Router router in MineSite.GetInstance().siteRouters)
            {
                lstRouters.Items.Add(router);

            }
        }

        private void llblNewSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string siteName = GetNewSitename();

            if (!siteName.Equals(""))
            {
                bool didComplete = _controller.MineSiteCreate(siteName);

                if (!didComplete)
                { 
                    MessageBox.Show("Could not create Mine Site", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void llblName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string siteName = GetNewSitename();

            MineSite.GetInstance().siteName = siteName;

            _controller.MineSiteUpdate();
        }

        private string GetNewSitename()
        {
            string siteName = "";
            MineSiteEnterForm enterForm = new MineSiteEnterForm();

            if (enterForm.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                siteName = enterForm.Controls[enterForm.Controls.Count - 1].Text;
            }
            
            enterForm.Dispose();
            

            return siteName;
        }
    }
}
