using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Windows.Forms;
using System.Drawing;

using System.Data.SqlClient;
using System.Security.Cryptography;

namespace TMS
{
    public class MasterController
    {
        LoginForm _loginForm;
        MainForm _mainForm;

        RouterAddEditForm _routerForm;

        bool isEnteringRouter = false;

        public MasterController(LoginForm lf)
        {
            _loginForm = lf;

            // Load site info
            int siteId = 0;
            string siteName = "", mapAddr = "";
            float mapScale = 0;
            List<Router> routers = new List<Router>();

            using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.TMS_DatabaseConnectionString))
            {
                string cmdString = "SELECT * FROM Site";
                SqlCommand oCmd = new SqlCommand(cmdString, sqlCon);

                sqlCon.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        siteId = Int32.Parse(oReader["Id"].ToString());
                        siteName = oReader["siteName"].ToString();
                        mapAddr = oReader["localMapFileAddr"].ToString();
                        mapScale = float.Parse(oReader["mapScale"].ToString());
                    }
                }

                cmdString = "SELECT * FROM Routers WHERE siteId = @siteId";
                oCmd = new SqlCommand(cmdString, sqlCon);
                oCmd.Parameters.AddWithValue("@siteId", siteId);

                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        routers.Add(
                            new Router(oReader["Id"].ToString(),
                            oReader["address"].ToString(),
                            oReader["location"].ToString(),
                            Int32.Parse(oReader["x"].ToString()),
                            Int32.Parse(oReader["x"].ToString()),
                            bool.Parse(oReader["isBlocked"].ToString()))
                            );
                    }
                }
            }

            MineSite.GetInstance().Init(siteId, siteName, mapAddr, mapScale, routers);

        }

        public void AssignShift()
        {

        }

        /// <summary>
        /// Authenticates the username and password
        /// 
        /// Returns 1 if username is invalid
        /// Returns 2 if password does not match username
        /// Returns 0 if successful
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public int Authenticate(string username, string password)
        {
            // Get salt from database
            string salt = "";
            string passHash = "";

            using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.TMS_DatabaseConnectionString))
            {
                string cmdString = "SELECT password, salt FROM Users WHERE username=@username";

                SqlCommand oCmd = new SqlCommand(cmdString, sqlCon);
                oCmd.Parameters.AddWithValue("@username", username);

                sqlCon.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    // Check if username is found
                    if (!oReader.HasRows)
                    {
                        return 1;
                    }

                    while (oReader.Read())
                    {
                        salt = oReader["salt"].ToString();
                        passHash = oReader["password"].ToString();
                    }
                }
            }

            // Hashes and checks password 
            byte[] passBytes = Encoding.UTF8.GetBytes(salt + password);

            SHA256 hasherSHA256 = SHA256Managed.Create();
            byte[] hashValue = hasherSHA256.ComputeHash(passBytes);

            string hashedPass = "";
            foreach (byte x in hashValue)
            {
                hashedPass += String.Format("{0:x2}", x);
            }

            if (!hashedPass.Equals(passHash))
            {
                return 2;
            }

            return 0;
        }

        public void ClosedRouterForm()
        {
            isEnteringRouter = false;
            _routerForm.Dispose();
        }

        /// <summary>
        /// TODO Create an admin user if there are none
        /// </summary>
        private void CreateAdmin()
        {

        }

        /// <summary>
        /// TODO Create a new user and adds it to the database
        /// </summary>
        public void CreateUser()
        {

        }

        /// <summary>
        /// Opens a dialog to load a jpg, jpeg, or bmp image of map data
        /// </summary>
        public void LoadMap(PictureBox picMinePlan)
        {
            Stream imageStream = null;
            OpenFileDialog openImageFileDialog = new OpenFileDialog();

            openImageFileDialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
            openImageFileDialog.Filter = "Image Files (*.bmp, *.jpg, *.jpeg)|*.bmp;*.jpg;*.jpeg";
            openImageFileDialog.FilterIndex = 1;
            openImageFileDialog.RestoreDirectory = true;

            if (openImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((imageStream = openImageFileDialog.OpenFile()) != null)
                    {
                        using (imageStream)
                        {
                            Image image = Image.FromStream(imageStream);
                            picMinePlan.Image = image;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. \nOriginal error: " + ex.Message);
                }
            }
        }

        #region Open Object Creation Forms

        /// <summary>
        /// TODO Open assign shift form
        /// </summary>
        public void OpenAssignShift()
        {

        }

        /// <summary>
        /// TODO Open member form
        /// </summary>
        public void OpenCreateMember()
        {

        }

        /// <summary>
        /// TODO Open tag form
        /// </summary>
        public void OpenCreateTag()
        {

        }

        /// <summary>
        /// TODO Open user form
        /// </summary>
        public void OpenCreateUser()
        {

        }

        /// <summary>
        /// Closes the login form and open the main form
        /// </summary>
        public void OpenMainForm()
        {
            _loginForm.Hide();

            _mainForm = new MainForm(this);
            _mainForm.Show();
        }

        public void OpenRouters()
        {
            if (!isEnteringRouter) 
            {
                _routerForm = new RouterAddEditForm(this);
                _mainForm.AddToLeftPanel(_routerForm);

                isEnteringRouter = true;
            }
            
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        public int RouterCreate(string rId, string addr, string loc, int x, int y, bool isBlocked)
        {
            using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.TMS_DatabaseConnectionString))
            {
                string cmdString = "INSERT INTO Routers(Id, address, location, x, y, isBlocked, siteId) VALUES(@Id, @address, @location, @x, @y, @isBlocked, @siteId)";

                sqlCon.Open();
                SqlCommand oCmd = new SqlCommand(cmdString, sqlCon);
                oCmd.Parameters.AddWithValue("@Id", rId);
                oCmd.Parameters.AddWithValue("@address", addr);
                oCmd.Parameters.AddWithValue("@location", loc);
                oCmd.Parameters.AddWithValue("@x", x);
                oCmd.Parameters.AddWithValue("@y", y);
                oCmd.Parameters.AddWithValue("@isBlocked", isBlocked ? 1 : 0);
                oCmd.Parameters.AddWithValue("@siteId", MineSite.GetInstance().siteId);

                try
                {
                    int rows = oCmd.ExecuteNonQuery();
                    MineSite.GetInstance().siteRouters.Add(new Router(rId, addr, loc, x, y, isBlocked));

                    cmdString = "SELECT * FROM Routers";
                    oCmd = new SqlCommand(cmdString, sqlCon);

                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            Console.WriteLine(oReader["Id"].ToString());
                        }
                    }

                    return 0;
                }
                catch (SqlException e)
                {
                    MessageBox.Show("Error", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return 1;
                }

            }
        }

        /// <summary>
        /// Composes an update statement for Routers table
        /// </summary>
        public int RouterUpdate(Router router, string rId, string addr, string loc, int x, int y, bool isBlocked)
        {
            using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.TMS_DatabaseConnectionString))
            {
                string cmdString = "UPDATE Routers SET address=@address, location=@location, x=@x, y=@y, isBlocked=@isBlocked WHERE Id=@Id";

                SqlCommand oCmd = new SqlCommand(cmdString, sqlCon);
                oCmd.Parameters.AddWithValue("@Id", rId);
                oCmd.Parameters.AddWithValue("@address", addr);
                oCmd.Parameters.AddWithValue("@location", loc);
                oCmd.Parameters.AddWithValue("@x", x);
                oCmd.Parameters.AddWithValue("@y", y);
                oCmd.Parameters.AddWithValue("@isBlocked", isBlocked ? 1 : 0);

                sqlCon.Open();

                try
                {
                    int rows = oCmd.ExecuteNonQuery();
                    router.Update(rId, addr, loc, x, y, isBlocked);
                    return 0;
                }
                catch (SqlException e)
                {
                    MessageBox.Show("Error", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return 1;
                }
            }
        }
    }
}
