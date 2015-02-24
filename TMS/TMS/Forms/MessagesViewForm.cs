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
    public partial class MessagesViewForm : Form
    {
        MessagingController _controller;

        public MessagesViewForm(MessagingController c)
        {
            InitializeComponent();

            _controller = c;

            LoadMessages();
        }

        private void LoadMessages()
        {
            List<EDBroadcast> broadcasts = _controller.GetAllBroadcasts();

            flpnlMessages.Controls.Remove(btnViewMessage);
            foreach (EDBroadcast broadcast in broadcasts)
            {
                Button btnNewMessage = new Button();
                btnNewMessage.BackColor = btnViewMessage.BackColor;
                btnNewMessage.FlatStyle = btnViewMessage.FlatStyle;
                btnNewMessage.Font = btnViewMessage.Font;
                btnNewMessage.Size = btnViewMessage.Size;
                btnNewMessage.TextAlign = btnViewMessage.TextAlign;
                btnNewMessage.Text = User.GetInstance().username + "\n" +
                                        broadcast.created.ToString("yyyy-MM-dd") + "\n" + 
                                        broadcast.content;

                btnNewMessage.Click += btnViewMessage_Click;


                flpnlMessages.Controls.Add(btnNewMessage);
            }
        }

        /// <summary>
        /// TODO Expand message to view all contents
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnViewMessage_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Clicked");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
