using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace TMS
{
    public class MessagingController
    {
        MainForm _mainForm;
        MessagesSendForm _sendForm;
        MessagesViewForm _viewForm;

        public MessagingController(MainForm mf)
        {
            _mainForm = mf;
        }

        public List<EDBroadcast> GetAllBroadcasts()
        {
            List<EDBroadcast> broadcasts = new List<EDBroadcast>();

            using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.TMS_DatabaseConnectionString))
            {
                string cmdString = "SELECT * FROM EDBroadcasts WHERE username=@username ORDER BY time DESC";

                SqlCommand oCmd = new SqlCommand(cmdString, sqlCon);
                oCmd.Parameters.AddWithValue("@username", User.GetInstance().username);

                sqlCon.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        broadcasts.Add(
                            new EDBroadcast(oReader["content"].ToString(), 
                                            oReader["username"].ToString(), 
                                            DateTime.Parse(oReader["time"].ToString())
                                            )
                        );
                    }
                }
            }

            return broadcasts;
        }

        /// <summary>
        /// Opens the form to send messages.
        /// </summary>
        public void OpenMessageSend(bool isDefaultBroadcast = false)
        {
            if (_sendForm == null || _sendForm.Visible == false)
            {
                _sendForm = new MessagesSendForm(this, isDefaultBroadcast);
                _sendForm.Show();

            }
        }

        /// <summary>
        /// Open the form to view all sent alerts and broadcasts
        /// </summary>
        public void OpenMessageView()
        {
            if (_viewForm == null || _viewForm.Visible == false)
            {
                _viewForm = new MessagesViewForm(this);
                _mainForm.AddToLeftPanel(_viewForm);
            }
        }

        /// <summary>
        /// TODO Sends the message to the coordinator and saves it to the database.
        /// </summary>
        /// <param name="isBroadcast">Whether or not this message will be broadcast to all members.</param>
        /// <param name="content">The content of the message</param>
        public void SendMessage(bool isBroadcast, string content)
        {

        }

    }
}
