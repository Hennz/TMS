using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace TMS
{
    public class TrackingController
    {
        MainForm _mainForm;
        PictureBox _picMinePlan;

        RouterMapForm routerMapForm;

        public TrackingController(MainForm m, PictureBox pm)
        {
            _mainForm = m;
            _picMinePlan = pm;

            routerMapForm = new RouterMapForm();
        }

        public void HideRouterForm()
        {
            if (routerMapForm != null)
                routerMapForm.Hide();
        }

        public void ShowMinerPosition(int mouseX, int mouseY)
        {
            if (routerMapForm == null)
                routerMapForm = new RouterMapForm();

            // Calculates the form's x and y so it stays in the tracking window
            int x = (mouseX - (_mainForm.DesktopLocation.X + _mainForm.PointToClient(_picMinePlan.Parent.PointToScreen(_picMinePlan.Location)).X)) >= routerMapForm.Width ? mouseX - routerMapForm.Width : mouseX;
            int y = (mouseY - _mainForm.DesktopLocation.Y) >= routerMapForm.Height ? mouseY - routerMapForm.Height : mouseY;

            routerMapForm.Show();
            routerMapForm.SetDesktopLocation(x, y);
        }
    }
}
