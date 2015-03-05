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
    public partial class ActiveMinersInfoForm : Form
    {
        TrackingController _controller;
        public ActiveMinersInfoForm(TrackingController c)
        {
            InitializeComponent();

            _controller = c;
        }

        private void ActiveMinersInfoForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tMS_DatabaseDataSet.Members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.tMS_DatabaseDataSet.Members);

        }
    }
}
