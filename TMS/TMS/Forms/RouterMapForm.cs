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
        TrackingController _controller;

        Router router;

        public RouterMapForm(TrackingController c)
        {
            InitializeComponent();

            _controller = c;
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
            
            // Load end devices into treeview
            tvEndDevices.BeginUpdate();
            tvEndDevices.Nodes[0].Nodes.Clear();

            foreach (Member member in router.hasConnectedMember)
            {
                if (_controller.IsMemberActive(member))
                {
                    TreeNode memberNode = new TreeNode(member.ToString());
                    tvEndDevices.Nodes[0].Nodes.Add(memberNode);
                }

            }
            tvEndDevices.Nodes[0].ExpandAll();

            tvEndDevices.EndUpdate();
            
            Show();
        }
    }
}
