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
    public partial class TestCommForm : Form
    {
        TrackingController _controller;

        public TestCommForm(TrackingController c)
        {
            InitializeComponent();

            _controller = c;

        }

        private void TestCommForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tMS_DatabaseDataSet3.Routers' table. You can move, or remove it, as needed.
            this.routersTableAdapter.Fill(this.tMS_DatabaseDataSet3.Routers);
            // TODO: This line of code loads data into the 'tMS_DatabaseDataSet2.Members' table. You can move, or remove it, as needed.
            this.membersTableAdapter1.Fill(this.tMS_DatabaseDataSet2.Members);

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lstMiners.SelectedIndex >= 0 &&
                lstRouters.SelectedIndex >= 0)
            {
                string memberNo = lstMiners.SelectedValue.ToString();
                string routerNo = lstRouters.SelectedValue.ToString();

                byte[] memberNoB = new byte[memberNo.Length * sizeof(char)];
                System.Buffer.BlockCopy(memberNo.ToCharArray(), 0, memberNoB, 0, memberNoB.Length);

                byte[] routerNoB = new byte[routerNo.Length * sizeof(char)];
                System.Buffer.BlockCopy(routerNo.ToCharArray(), 0, routerNoB, 0, routerNoB.Length);

                byte[] data = new byte[2 + memberNoB.Length + routerNoB.Length];
                data[0] = (byte)memberNo.Length;
                data[1] = (byte)routerNo.Length;

                for (int i = 2; i < memberNoB.Length + 2; i++)
                {
                    data[i] = memberNoB[i - 2];
                }
                for (int i = memberNoB.Length + 2; i < data.Length; i++)
                {
                    data[i] = routerNoB[i - 2 - memberNoB.Length];
                }

                _controller.ReadDataFromCoordinator(data);
            }
        }

    }
}
