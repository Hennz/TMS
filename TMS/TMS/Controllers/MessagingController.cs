using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        /// <summary>
        /// 
        /// </summary>
        public void ClosedViewForm()
        {
            _viewForm.Dispose();
        }

        public void OpenMessageSend()
        {
            if (_sendForm == null || _sendForm.Visible == false)
            {
                _sendForm = new MessagesSendForm(this);
                _sendForm.Show();

            }
        }

        public void OpenMessageView()
        {
            if (_viewForm == null || _viewForm.Visible == false)
            {
                _viewForm = new MessagesViewForm(this);
                _mainForm.AddToLeftPanel(_viewForm);

            }
        }

    }
}
