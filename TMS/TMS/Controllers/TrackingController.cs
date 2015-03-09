using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using System.IO;
using System.Windows.Forms;
using System.Drawing;

using LibUsbDotNet;
using LibUsbDotNet.Main;

using System.Data.SqlClient;

namespace TMS
{
    public class TrackingController
    {
        /// <summary>
        /// The vendor ID of the coordinator
        /// </summary>
        const int COORDINATOR_VID = 0x18D1;
        /// <summary>
        /// The product ID of the coordinator
        /// </summary>
        const int COORDINATOR_PID = 0x4E42;

        private UsbDevice coordinatorUsb;

        private UsbDeviceFinder coordinatorUsbFinder = new UsbDeviceFinder(COORDINATOR_VID, COORDINATOR_PID);

        // Forms controlled by this
        MainForm _mainForm;
        PictureBox _picMinePlan;

        TestCommForm _testForm;

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

            InitUSB();
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

            OnRouterUpdate(picRouter, router);

            picRouter.Size = new Size(picRouter.Image.Width, picRouter.Image.Height);

            // Set up events for the router updating
            picRouter.MouseDown += (sender, e) =>
            {
                ShowMinerPosition(sender, e, router);
            };

            router.OnUpdated += () =>
            {
                OnRouterUpdate(picRouter, router);
            };
            MineSite.GetInstance().OnUpdated += (scale) =>
            {
                OnRouterUpdate(picRouter, router);
            };


        }

        /// <summary>
        /// Checks if a member has an active shift now
        /// </summary>
        /// <param name="m">The member to check</param>
        /// <returns>Whether or not the miner's shift is taking place now</returns>
        public bool CheckMemberActive(Member m)
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

        private bool CreatePathElement(Member member, Router router)
        {
            using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.TMS_DatabaseConnectionString))
            {
                string cmdString = "INSERT INTO PathElement(routerId, memberId, timeVisited) VALUES(@routerId, @memberId, GETDATE())";

                sqlCon.Open();
                SqlCommand oCmd = new SqlCommand(cmdString, sqlCon);
                oCmd.Parameters.AddWithValue("@memberId", member.memberId);
                oCmd.Parameters.AddWithValue("@routerId", router.routerId);

                try
                {
                    int rows = oCmd.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Frees all USB resources
        /// </summary>
        public void Dispose()
        {
            if (coordinatorUsb != null)
            {
                if (coordinatorUsb.IsOpen)
                {
                    IUsbDevice wholeUsbDevice = coordinatorUsb as IUsbDevice;
                    if (!ReferenceEquals(wholeUsbDevice, null))
                    {
                        // Release interface #0.
                        wholeUsbDevice.ReleaseInterface(0);
                    }

                    coordinatorUsb.Close();
                }
                coordinatorUsb = null;

                // Free USB resources
                UsbDevice.Exit();
            }
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

        /// <summary>
        /// Sets the member for whom to draw a path
        /// </summary>
        /// <param name="member"></param>
        public void SetCurrentDrawMember(Member member)
        {
            if (member != null)
            {
                if (currentMember != null)
                {
                    currentMember.OnPathUpdated -= DrawCurrentMember;
                }
            
                currentMember = member;

                currentMember.OnPathUpdated += DrawCurrentMember;
            }

            DrawCurrentMember();
        }

        public void DrawCurrentMember()
        {
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

        /// <summary>
        //  USB initialization
        /// </summary>
        private void InitUSB()
        {
            coordinatorUsb = UsbDevice.OpenUsbDevice(coordinatorUsbFinder);

            // If the device is open and ready
            if (coordinatorUsb == null)
            {
                _mainForm.SetStatusText("Coordinator Not Connected.");
                return;
            }
            else
            {
                _mainForm.SetStatusText("Connected to coordinator: " + coordinatorUsb.UsbRegistryInfo.FullName);
            }

            IUsbDevice wholeUsbDevice = coordinatorUsb as IUsbDevice;
            if (!ReferenceEquals(wholeUsbDevice, null))
            {
                // Select config #1
                wholeUsbDevice.SetConfiguration(1);

                // Claim interface #0.
                wholeUsbDevice.ClaimInterface(0);

                Console.WriteLine("IUsbDevice Worked");

            }
            
            // open read endpoint 1.
            UsbEndpointReader reader = coordinatorUsb.OpenEndpointReader(ReadEndpointID.Ep01);

            ErrorCode ecRead;
            int transferredIn;
            UsbTransfer usbReadTransfer;
            byte[] readBuffer = new byte[1024];
            int testCount = 0;

            do
            {
                // Create and submit transfer
                ecRead = reader.SubmitAsyncTransfer(readBuffer, 0, readBuffer.Length, 100, out usbReadTransfer);
                if (ecRead != ErrorCode.None)
                {
                    Console.WriteLine("Submit Async Read Failed.");
                }

                if (usbReadTransfer == null)
                {
                    return;
                }

                WaitHandle.WaitAll(new WaitHandle[] { usbReadTransfer.AsyncWaitHandle }, 200, false);
                if (!usbReadTransfer.IsCompleted) usbReadTransfer.Cancel();

                ecRead = usbReadTransfer.Wait(out transferredIn);

                usbReadTransfer.Dispose();

                Console.WriteLine("Read  :{0} ErrorCode:{1}", transferredIn, ecRead);
                Console.WriteLine("Data  :" + Encoding.Default.GetString(readBuffer, 0, transferredIn));
                testCount++;
            } while (testCount < 1);
            Console.WriteLine("\r\nDone!\r\n");

        }

        public void OpenAllMinersView()
        {
            if (_activeMinersForm == null || _activeMinersForm.Visible == false)
            {
                _activeMinersForm = new ActiveMinersInfoForm(this);
                _activeMinersForm.Show();
            }
        }

        private void OnRouterUpdate(PictureBox picRouter, Router router)
        {
            picRouter.Location = new Point((int)(router.posX * MineSite.GetInstance().mapScale - picRouter.Width / 2), (int)(router.posY * MineSite.GetInstance().mapScale - picRouter.Width / 2));

            if (router.hasConnectedMember.Count > 0)
            {
                picRouter.Image = router.isBlocked ? TMS.Properties.Resources.router_blocked_miner_map : TMS.Properties.Resources.router_active_miner_map;
            }
            else
            {
                picRouter.Image = router.isBlocked ? TMS.Properties.Resources.router_blocked_map : TMS.Properties.Resources.router_active_map;
            }

            HideRouterForm();
        }

        public void OpenTestForm()
        {
            if (_testForm == null || _testForm.Visible == false)
            {
                _testForm = new TestCommForm(this);
                _testForm.Show();
            }
        }

        /// <summary>
        /// Processes a byte stream from the coordinator
        /// </summary>
        /// <param name="data">Data formatted so we have a member id and a router ID like MXXXXRXXXX</param>
        public void PutDataFromCoordinator(byte[] data)
        {
            int memberNoL = (int)data[0];
            int routerNoL = (int)data[1];

            char[] chars = new char[memberNoL];
            System.Buffer.BlockCopy(data, 2, chars, 0, memberNoL * sizeof(char));
            string memberId = new string(chars);

            chars = new char[routerNoL];
            System.Buffer.BlockCopy(data, 2 + memberNoL * sizeof(char), chars, 0, routerNoL * sizeof(char));
            string routerNo = new string(chars);

            Console.WriteLine(memberId + " at " + routerNo);

            Member member = MineSite.GetInstance().siteMembers[memberId];
            Router router = MineSite.GetInstance().ContainsRouter(routerNo);

            if (router != null && member != null)
            {
                member.AppendRouter(router);

                CreatePathElement(member, router);
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
