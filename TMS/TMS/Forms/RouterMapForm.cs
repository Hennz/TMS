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
    public partial class RouterMapForm : Form
    {
        public RouterMapForm()
        {
            InitializeComponent();
        }

        private void RouterMapForm_Deactivate(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
