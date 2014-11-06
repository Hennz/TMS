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
        public MainForm()
        {
            InitializeComponent();
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
    }
}
