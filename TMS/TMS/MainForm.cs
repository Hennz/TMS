using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TMS
{
    public partial class MainForm : Form
    {
        RouterMapForm routerMapForm;
        public MainForm()
        {
            while(LogIn())
            {

            }
            InitializeComponent();
        }

        private bool LogIn()
        {

            return false;
        }


        private void miLoadMap_Click(object sender, EventArgs e)
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

        private void picMinePlan_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void picMinePlan_Click(object sender, EventArgs e)
        {
            if (routerMapForm == null)
                routerMapForm = new RouterMapForm();

            // Calculates the form's x and y so it stays in the tracking window
            int x = (MousePosition.X - (this.DesktopLocation.X + this.PointToClient(picMinePlan.Parent.PointToScreen(picMinePlan.Location)).X)) >= routerMapForm.Width ? MousePosition.X - routerMapForm.Width : MousePosition.X;
            int y = (MousePosition.Y - this.DesktopLocation.Y) >= routerMapForm.Height ? MousePosition.Y - routerMapForm.Height : MousePosition.Y;

            routerMapForm.Show();
            routerMapForm.SetDesktopLocation(x, y);
        }

        private void MainForm_LocationChanged(object sender, EventArgs e)
        {
            if (routerMapForm != null)
                routerMapForm.Hide();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (routerMapForm != null)
                routerMapForm.Hide();
        }

        private void msMain_Click(object sender, EventArgs e)
        {
            if (routerMapForm != null)
                routerMapForm.Hide();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
