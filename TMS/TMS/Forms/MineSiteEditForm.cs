﻿using System;
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
            lblName.Text = MineSite.GetInstance().siteName;
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
    }
}