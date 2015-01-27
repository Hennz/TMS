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

        MinerAddEditForm _minerForm;
        RouterAddEditForm _routerForm;
        ShiftAddEditForm _shiftForm;
        UserAddEditForm _userForm;

        public PictureBox _picMinePlan { private get;  set; }

        bool isSelectingPos = false;

        public MasterController(LoginForm lf)
        {
            _loginForm = lf;

            // Load site info
            int siteId = 0;
            string siteName = "", mapAddr = "";
            float mapScale = 0;
            List<Router> routers = new List<Router>();
            List<Member> members = new List<Member>();

            // Load routers and members
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
                            Int32.Parse(oReader["y"].ToString()),
                            bool.Parse(oReader["isBlocked"].ToString()))
                            );
                    }
                }

                cmdString = "SELECT * FROM Members WHERE siteId = @siteId";
                oCmd = new SqlCommand(cmdString, sqlCon);
                oCmd.Parameters.AddWithValue("@siteId", siteId);

                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        members.Add(new Member(oReader["memberNo"].ToString(),
                            oReader["fName"].ToString(),
                            oReader["mName"].ToString(),
                            oReader["lName"].ToString(),
                            oReader["address"].ToString(),
                            oReader["province"].ToString(),
                            oReader["city"].ToString(),
                            Int32.Parse(oReader["pinNo"].ToString()),
                            oReader["phoneNo"].ToString(),
                            oReader["mobileNo"].ToString(),
                            oReader["isVehicle"].ToString() == "1" ? true : false,
                            oReader["tagId"].ToString()));
                    }
                }
            }

            MineSite.GetInstance().Init(siteId, siteName, mapAddr, mapScale, routers, members);
        }

        public int AssignShift(Member member, Shift[] shift)
        {
            using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.TMS_DatabaseConnectionString))
            {
                string cmdString = "INSERT INTO Shifts VALUES(@start, @end, @memberNo)";

                sqlCon.Open();

                SqlCommand[] oCmd = new SqlCommand[shift.Length];

                for (int i = 0; i < shift.Length; i++)
                {
                    oCmd[i] = new SqlCommand(cmdString, sqlCon);
                    oCmd[i].Parameters.AddWithValue("@start", shift[i].startTime.ToString("HH:mm:00"));
                    oCmd[i].Parameters.AddWithValue("@end", shift[i].endTime.ToString("HH:mm:00"));
                    oCmd[i].Parameters.AddWithValue("@memberNo", member.memberId);
                }

                try
                {
                    for (int i = 0; i < shift.Length; i++)
                    {
                        int rows = oCmd[i].ExecuteNonQuery();
                    }

                    return 0;
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return 1;
                }
            }
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
            string fName = "", lName = "";
            string salt = "";
            string passHash = "";
            bool isAdmin = false;

            using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.TMS_DatabaseConnectionString))
            {
                string cmdString = "SELECT * FROM Users WHERE username=@username";

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
                        fName = oReader["fName"].ToString();
                        lName = oReader["lName"].ToString();
                        isAdmin = oReader["isAdmin"].ToString().Equals("True") ? true : false;

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

            // Initialize user 
            User.GetInstance().Init(username, fName, lName, isAdmin);

            return 0;
        }

        public void ClosedRouterForm()
        {
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
                    MessageBox.Show("Error: Could not open file. \n", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #region Open Object Creation Forms

        /// <summary>
        /// Open assign shift form
        /// </summary>
        public void OpenAssignShift(Member member)
        {
            if (_shiftForm == null || _shiftForm.Visible == false)
            {
                _shiftForm = new ShiftAddEditForm(this, member);
                _shiftForm.Show();
            }
        }

        /// <summary>
        /// Open member form
        /// </summary>
        public void OpenCreateMember()
        {
            if (_minerForm == null || _minerForm.Visible == false)
            {
                _minerForm = new MinerAddEditForm(this);
                _minerForm.Show();
            }
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
            if (_routerForm == null) 
            {
                _routerForm = new RouterAddEditForm(this);
                _mainForm.AddToLeftPanel(_routerForm);

            }
            
        }

        /// <summary>
        /// Opens the form for creating / editing users
        /// </summary>
        public void OpenUsers()
        {
            if (_userForm == null || _userForm.Visible == false)
            {
                _userForm = new UserAddEditForm(this);
                _userForm.Show();
            }
        }

        #endregion

        /// <summary>
        /// Creates a member object in the database and adds it to MineSite
        /// </summary>
        public int MemberCreate(string memberNo, 
            string fName, string mName, string lName,
            string addr, string prov, string city, int pinNo, 
            string phoneNo, string mobileNo, bool isVehicle, 
            string tagId)
        {
            using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.TMS_DatabaseConnectionString))
            {
                string cmdString = 
                    "INSERT INTO Members(memberNo, fName, mName, lName, address, province, city, pinNo, phoneNo, mobileNo, isVehicle,  tagId, siteId) " + 
                                 "VALUES(@memberNo, @fName, @mName, @lName, @address, @province, @city, @pinNo, @phoneNo, @mobileNo, @isVehicle,  @tagId, @siteId)";

                sqlCon.Open();
                SqlCommand oCmd = new SqlCommand(cmdString, sqlCon);
                oCmd.Parameters.AddWithValue("@memberNo", memberNo);
                oCmd.Parameters.AddWithValue("@fName", fName);
                oCmd.Parameters.AddWithValue("@mName", mName);
                oCmd.Parameters.AddWithValue("@lName", lName);
                oCmd.Parameters.AddWithValue("@address", addr);
                oCmd.Parameters.AddWithValue("@province", prov);
                oCmd.Parameters.AddWithValue("@city", city);
                oCmd.Parameters.AddWithValue("@pinNo", pinNo);
                oCmd.Parameters.AddWithValue("@phoneNo", phoneNo);
                oCmd.Parameters.AddWithValue("@mobileNo", mobileNo);
                oCmd.Parameters.AddWithValue("@isVehicle", isVehicle ? 1 : 0);
                oCmd.Parameters.AddWithValue("@tagId", tagId);
                oCmd.Parameters.AddWithValue("@siteId", MineSite.GetInstance().siteId);

                try
                {
                    int rows = oCmd.ExecuteNonQuery();
                    
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
        public int MemberUpdate(Member member, string memberNo,
            string fName, string mName, string lName,
            string addr, string province, string city, int pinNo,
            string phoneNo, string mobileNo, bool isVehicle,
            string tagId)
        {
            using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.TMS_DatabaseConnectionString))
            {
                string cmdString = "UPDATE Members SET fName=@fName, mName=@mName, lName=@lName, address=@address, province=@province, city=@city, pinNo=@pinNo, phoneNo=@phoneNo, mobileNo=@mobileNo, isVehicle=@isVehicle, tagId=@tagId WHERE memberNo=@memberNo";

                sqlCon.Open();
                SqlCommand oCmd = new SqlCommand(cmdString, sqlCon);
                oCmd.Parameters.AddWithValue("@memberNo", memberNo);
                oCmd.Parameters.AddWithValue("@fName", fName);
                oCmd.Parameters.AddWithValue("@mName", mName);
                oCmd.Parameters.AddWithValue("@lName", lName);
                oCmd.Parameters.AddWithValue("@address", addr);
                oCmd.Parameters.AddWithValue("@province", province);
                oCmd.Parameters.AddWithValue("@city", city);
                oCmd.Parameters.AddWithValue("@pinNo", pinNo);
                oCmd.Parameters.AddWithValue("@phoneNo", phoneNo);
                oCmd.Parameters.AddWithValue("@mobileNo", mobileNo);
                oCmd.Parameters.AddWithValue("@isVehicle", isVehicle ? 1 : 0);
                oCmd.Parameters.AddWithValue("@tagId", tagId);
                
                try
                {
                    int rows = oCmd.ExecuteNonQuery();

                    member.Update(  memberNo,
                                    fName, mName, lName,
                                    addr, province, city, pinNo,
                                    phoneNo, mobileNo, isVehicle,
                                    tagId);

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
        /// Queries the database for a list of all the tags
        /// </summary>
        /// <returns></returns>
        public List<string> RetrieveTagIDList()
        {
            List<string> tags = new List<string>();

            using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.TMS_DatabaseConnectionString))
            {
                string cmdString = "SELECT * FROM Tags";

                SqlCommand oCmd = new SqlCommand(cmdString, sqlCon);

                sqlCon.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        tags.Add(oReader["Id"].ToString());
                    }
                }
            }

            return tags;
        }

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

        /// <summary>
        /// 
        /// </summary>
        public void SetRouterPositionSetable()
        {
            if (!isSelectingPos)
            {
                foreach (Control c in _picMinePlan.Controls)
                {
                    c.Visible = false;
                }

                _picMinePlan.MouseDown += SelectRouterPosClick;
                isSelectingPos = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectRouterPosClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Down");

            _routerForm.SetRouterPosFromMap(e.X, e.Y);

            foreach (Control c in _picMinePlan.Controls)
            {
                c.Visible = true;
            }

            _picMinePlan.MouseDown -= SelectRouterPosClick;
            isSelectingPos = false;
        }
    }
}
