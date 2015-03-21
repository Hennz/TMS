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
    public partial class ReportForm : Form
    {
        ReportsController _controller;

        public ReportForm(ReportsController c)
        {
            InitializeComponent();

            _controller = c;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TMS_DatabaseDataSet4.Members' table. You can move, or remove it, as needed.
            this.MembersTableAdapter.Fill(this.TMS_DatabaseDataSet4.Members);

            this.reportViewer.RefreshReport();
        }
    }
}
