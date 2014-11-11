using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TMS
{
    public partial class MainForm : Form
    {
        MasterController _masterController;
        TrackingController _trackingController;

        public MainForm(MasterController c)
        {
            InitializeComponent();

            _masterController = c;
            _trackingController = new TrackingController(this, picMinePlan);
        }


        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
        private void MainForm_LocationChanged(object sender, EventArgs e)
        {
            if (_trackingController != null)
                _trackingController.HideRouterForm();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (_trackingController != null)
                _trackingController.HideRouterForm();
            
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void miLoadMap_Click(object sender, EventArgs e)
        {
            _masterController.LoadMap(picMinePlan);
        }

        private void msMain_Click(object sender, EventArgs e)
        {
            if (_trackingController != null)
                _trackingController.HideRouterForm();
            
        }
        
        private void picMinePlan_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void picMinePlan_Click(object sender, EventArgs e)
        {
            _trackingController.ShowMinerPosition(MousePosition.X, MousePosition.Y);
        }

    }
}
