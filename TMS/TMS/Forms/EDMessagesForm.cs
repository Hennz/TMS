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
    public partial class EDMessagesForm : Form
    {
        public EDMessagesForm()
        {
            InitializeComponent();
        }

        private void EDMessagesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tMS_MemberPathViewSet.MemberPathView' table. You can move, or remove it, as needed.
            this.memberPathViewTableAdapter.Fill(this.tMS_MemberPathViewSet.MemberPathView);
            
        }

    }
}
