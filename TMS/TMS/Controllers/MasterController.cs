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

        public MasterController(LoginForm lf)
        {
            _loginForm = lf;
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

                    sqlCon.Close();
                }
            }

            // TODO: Do hashing and checking 
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

        /// <summary>
        /// TODO Create an admin user if there are none
        /// </summary>
        private void CreateAdmin()
        {

        }

        /// <summary>
        /// TODO Create a new user and adds it to the database
        /// </summary>
        private void CreateUser()
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
        private void OpenAssignShift()
        {

        }

        /// <summary>
        /// TODO Open member form
        /// </summary>
        private void OpenCreateMember()
        {

        }

        /// <summary>
        /// TODO Open tag form
        /// </summary>
        private void OpenCreateTag()
        {

        }

        /// <summary>
        /// TODO Open user form
        /// </summary>
        private void OpenCreateUser()
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

        #endregion

    }
}
