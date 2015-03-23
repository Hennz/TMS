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
    public enum REPORT_TYPES
    {
        MEMBER,
        ROUTER,
        TAGS,
        TWMINER
    }

    public partial class ReportForm : Form
    {
        REPORT_TYPES reportType;

        string twMemberNo;

        public ReportForm(REPORT_TYPES type, string memberNo = null)
        {
            InitializeComponent();

            reportType = type;
            twMemberNo = memberNo;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            if (reportType == REPORT_TYPES.ROUTER)
            {
                this.RoutersTableAdapter.Fill(this.TMS_DatabaseDataSet5.Routers);
                this.routerReportViewer.RefreshReport();
                routerReportViewer.Visible = true;
            }
            else if (reportType == REPORT_TYPES.MEMBER)
            {
                this.MembersTableAdapter.Fill(this.TMS_DatabaseDataSet4.Members);
                this.membersReportViewer.RefreshReport();
                membersReportViewer.Visible = true;
            }
            else if (reportType == REPORT_TYPES.TAGS)
            {
                this.MembersTableAdapter.Fill(this.TMS_DatabaseDataSet4.Members);
                this.tagsReportViewer.RefreshReport();
                tagsReportViewer.Visible = true;
            }
            else if (reportType == REPORT_TYPES.TWMINER)
            {
                this.TWMinerProcedureTableAdapter.Fill(this.TMS_TWMinersDataSet.TWMinerProcedure, twMemberNo);
                this.timeWiseReportViewer.RefreshReport();
                timeWiseReportViewer.Visible = true;
            }
        }
    }
}
