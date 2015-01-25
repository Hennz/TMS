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
    public partial class RouterMapForm : Form
    {
        Router router;

        public RouterMapForm()
        {
            InitializeComponent();
        }

        private void RouterMapForm_Deactivate(object sender, EventArgs e)
        {
            Hide();
        }

        public void Show(Router r)
        {
            router = r;

            lblTitle.Text = "Router: " + router.routerId;
            lblRouterInfo.Text =    "Address : " + router.address + 
                                    "\nLocation: " + router.location + 
                                    "\nPosition: " + router.posX + ", " + router.posY;

            Show();
        }
    }
}
