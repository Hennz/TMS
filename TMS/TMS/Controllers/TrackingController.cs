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

        }

        public void AddAllRoutersToMap()
        {
            foreach (Router router in MineSite.GetInstance().siteRouters)
            {
                PictureBox picRouter = new PictureBox();
                picRouter.BackColor = Color.Transparent;
                picRouter.Image = router.isBlocked ? TMS.Properties.Resources.router_blocked_map : TMS.Properties.Resources.router_active_map;
                picRouter.Size = new Size(picRouter.Image.Width, picRouter.Image.Height);
                _picMinePlan.Controls.Add(picRouter);

                picRouter.Location = new Point((int)(router.posX * MineSite.GetInstance().mapScale), (int)(router.posY * MineSite.GetInstance().mapScale));
                
                picRouter.MouseDown += (sender,e) => 
                {
                    ShowMinerPosition(sender, e, router);
                };

                router.OnUpdated += (x, y, isBlocked) =>
                {
                    picRouter.Location = new Point((int)(router.posX * MineSite.GetInstance().mapScale), (int)(router.posY * MineSite.GetInstance().mapScale));
                    picRouter.Image = router.isBlocked ? TMS.Properties.Resources.router_blocked_map : TMS.Properties.Resources.router_active_map;
                };
            }
        }

        public void HideRouterForm()
        {
            if (routerMapForm != null)
                routerMapForm.Hide();
        }

        public void ShowMinerPosition(object sender, MouseEventArgs e, Router router)
        {
            if (routerMapForm == null)
            {
                routerMapForm = new RouterMapForm();
                routerMapForm.TopLevel = false;
                _picMinePlan.Controls.Add(routerMapForm);
            }

            // Center of the router
            int mouseX = (int)(router.posX * MineSite.GetInstance().mapScale) + 
                TMS.Properties.Resources.router_active_map.Width / 2;
            // Under the router
            int mouseY = (int)(router.posY * MineSite.GetInstance().mapScale) + 
                TMS.Properties.Resources.router_active_map.Height;

            // Calculates the form's x and y so it stays in the tracking window
            int x = _picMinePlan.Width - mouseX >= routerMapForm.Width ? mouseX : mouseX - routerMapForm.Width;
            int y = _picMinePlan.Height - mouseY >= routerMapForm.Height ? mouseY : mouseY - routerMapForm.Height - TMS.Properties.Resources.router_active_map.Height;

            routerMapForm.Show(router);
            routerMapForm.Location = new Point(x, y);
            routerMapForm.BringToFront();
        }
    }
}
