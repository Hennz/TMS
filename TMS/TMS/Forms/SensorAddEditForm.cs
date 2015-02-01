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
    public partial class SensorAddEditForm : Form
    {
        MasterController _controller;

        public SensorAddEditForm(MasterController c)
        {
            InitializeComponent();

            _controller = c;

            LoadAllSensors();
        }

        private void LoadAllSensors()
        {
            lstSensors.Items.Clear();

            foreach (string sId in MineSite.GetInstance().siteSensors)
            {
                lstSensors.Items.Add(sId);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool didComplete = _controller.SensorCreate(mtxtNewSensor.Text);

            if (didComplete)
            {
                LoadAllSensors();
                mtxtNewSensor.Text = "";
                btnCreate.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool didComplete = _controller.SensorDelete(lstSensors.SelectedItems[0].ToString());

            if (didComplete)
            {
                LoadAllSensors();
            }
        }

        private void mtxtNewSensor_TextChanged(object sender, EventArgs e)
        {
            if (mtxtNewSensor.Text != "")
            {
                btnCreate.Enabled = true;
            }
            else
            {
                btnCreate.Enabled = false;
            }
        }

        private void lstSensors_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstSensors.SelectedItems.Count != 0)
            {
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
            }
        }

        private void mtxtNewSensor_Leave(object sender, EventArgs e)
        {
            if (MineSite.GetInstance().siteSensors.Contains(mtxtNewSensor.Text))
            {
                epSId.SetError(mtxtNewSensor, "This ID already exists.");
                btnCreate.Enabled = false;
            }
            else
            {
                epSId.Clear();
                btnCreate.Enabled = true;
            }
        }
    }
}
