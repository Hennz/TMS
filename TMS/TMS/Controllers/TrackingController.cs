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

        /// <summary>
        /// The form for displaying all active miners and their locations
        /// </summary>
        ActiveMinersInfoForm _activeMinersForm;

        /// <summary>
        /// The info form that appears wen clicking on a router.
        /// </summary>
        RouterMapForm routerMapForm;

        /// <summary>
        /// The current member whose path is being drawn
        /// </summary>
        private Member currentMember;

        public TrackingController(MainForm m, PictureBox pm)
        {
            _mainForm = m;
            _picMinePlan = pm;

            MineSite.GetInstance().OnUpdated += (new_scale) =>
            {
                DrawGridLines();
            };
        }

        /// <summary>
        /// Adds every site router to the map
        /// </summary>
        public void AddAllRoutersToMap()
        {
            foreach (Router router in MineSite.GetInstance().siteRouters)
            {
                AddOneRouterToMap(router);
            }
        }

        /// <summary>
        /// Adds a router image to the map and event handlers for clicking.
        /// </summary>
        /// <param name="router">The router to be added to the map.</param>
        public void AddOneRouterToMap(Router router)
        {
            PictureBox picRouter = new PictureBox();

            _picMinePlan.Controls.Add(picRouter);

            picRouter.BackColor = Color.Transparent;
            picRouter.Image = router.isBlocked ? TMS.Properties.Resources.router_blocked_map : TMS.Properties.Resources.router_active_map;
            picRouter.Size = new Size(picRouter.Image.Width, picRouter.Image.Height);
            picRouter.Location = new Point((int)(router.posX * MineSite.GetInstance().mapScale - picRouter.Width / 2), (int)(router.posY * MineSite.GetInstance().mapScale - picRouter.Width / 2));

            // Set up events for the router
            picRouter.MouseDown += (sender, e) =>
            {
                ShowMinerPosition(sender, e, router);
            };

            router.OnUpdated += (x, y, isBlocked) =>
            {
                picRouter.Location = new Point((int)(router.posX * MineSite.GetInstance().mapScale - picRouter.Width / 2), (int)(router.posY * MineSite.GetInstance().mapScale - picRouter.Width / 2));
                picRouter.Image = router.isBlocked ? TMS.Properties.Resources.router_blocked_map : TMS.Properties.Resources.router_active_map;
            };
            MineSite.GetInstance().OnUpdated += (scale) =>
            {
                picRouter.Location = new Point((int)(router.posX * MineSite.GetInstance().mapScale - picRouter.Width / 2), (int)(router.posY * MineSite.GetInstance().mapScale - picRouter.Width / 2));
                picRouter.Image = router.isBlocked ? TMS.Properties.Resources.router_blocked_map : TMS.Properties.Resources.router_active_map;
            };
        }

        /// <summary>
        /// Checks if a member has an active shift now
        /// </summary>
        /// <param name="m">The member to check</param>
        /// <returns>Whether or not the miner's shift is taking place now</returns>
        public bool IsMemberActive(Member m)
        {
            foreach (Shift s in m.assignedShifts)
            {
                if (s.startTime < DateTime.Now && s.endTime > DateTime.Now)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Draws grids to scale over top of the map.
        /// </summary>
        /// <param name="graphics"></param>
        public void DrawGridLines(Graphics graphics = null)
        {
            if (graphics == null)
            {
                _picMinePlan.Refresh();
            }

            // Too many gridlines would appear
            if (MineSite.GetInstance().mapScale == 1)
            {
                return;
            }

            // Draw grid over the image
            Graphics g = graphics == null ? _picMinePlan.CreateGraphics() : graphics;

            float cellSize = MineSite.GetInstance().mapScale;
            int numOfCells = (int)(_picMinePlan.Width / cellSize);
            Pen p = new Pen(Color.Black);
            p.Width = 0.1f;

            // Horizontal lines
            for (int i = 1; i < numOfCells; i++)
            {
                g.DrawLine(p, 0, i * cellSize, numOfCells * cellSize, i * cellSize);
            }

            // Vertical lines
            for (int i = 1; i < numOfCells; i++)
            {
                g.DrawLine(p, i * cellSize, 0, i * cellSize, numOfCells * cellSize);
            }

            // Draw a member's path
            if (currentMember != null)
            {
                Pen pathPen = new Pen(Color.Red);
                pathPen.Width = 3.0f;

                Router lastRouter = null;

                foreach (Router router in currentMember.path)
                {
                    if (lastRouter == null)
                    {
                        lastRouter = router;
                        continue;
                    }

                    g.DrawLine(pathPen,
                        lastRouter.posX * MineSite.GetInstance().mapScale, lastRouter.posY * MineSite.GetInstance().mapScale,
                        router.posX * MineSite.GetInstance().mapScale, router.posY * MineSite.GetInstance().mapScale);
                    lastRouter = router;
                }
            }
            

        }

        public void DrawMemberPath(Member member)
        {
            currentMember = member;
            _picMinePlan.Refresh();
        }

        /// <summary>
        /// Hides the router info form.
        /// </summary>
        public void HideRouterForm()
        {
            if (routerMapForm != null)
                routerMapForm.Hide();
        }

        public void OpenAllMinersView()
        {
            if (_activeMinersForm == null || _activeMinersForm.Visible == false)
            {
                _activeMinersForm = new ActiveMinersInfoForm(this);
                _activeMinersForm.Show();
            }
        }

        public void ShowMinerPosition(object sender, MouseEventArgs e, Router router)
        {
            if (routerMapForm == null)
            {
                routerMapForm = new RouterMapForm(this);
                routerMapForm.TopLevel = false;
                _picMinePlan.Controls.Add(routerMapForm);
            }

            // Center of the router
            int mouseX = (int)(router.posX * MineSite.GetInstance().mapScale);
            // Under the router
            int mouseY = (int)(router.posY * MineSite.GetInstance().mapScale);

            // Calculates the form's x and y so it stays in the tracking window
            int x = _picMinePlan.Width - mouseX >= routerMapForm.Width ? mouseX : mouseX - routerMapForm.Width;
            int y = _picMinePlan.Height - mouseY >= routerMapForm.Height ? mouseY : mouseY - routerMapForm.Height;

            routerMapForm.Show(router);
            routerMapForm.Location = new Point(x, y);
            routerMapForm.BringToFront();
        }
    }
}
