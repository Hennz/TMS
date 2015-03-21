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
            _reportForm = new ReportForm(this);
            _reportForm.Show();

        }

        public void RoutersReport()
        {

        }
    }
}
