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
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Authenticates the user and opens the main form
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="shouldRemember"></param>
        public void Login(string username, string password, bool shouldRemember)
        {
            _loginForm.Hide();

            _mainForm = new MainForm(this);
            _mainForm.Show();
        }

    }
}
