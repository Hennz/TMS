using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TMS
{
    public class ReportsController
    {
        ReportForm _reportForm;
        
        public ReportsController()
        {

        }

        public void MembersReport()
        {
            _reportForm = new ReportForm(REPORT_TYPES.MEMBER);
            _reportForm.Show();

        }

        public void RoutersReport()
        {
            _reportForm = new ReportForm(REPORT_TYPES.ROUTER);
            _reportForm.Show();
        }

        public void TagsReport()
        {
            _reportForm = new ReportForm(REPORT_TYPES.TAGS);
            _reportForm.Show();
        }
    }
}
