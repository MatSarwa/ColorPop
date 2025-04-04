using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BasicWindowsForm
{
    public static class ImageLoader
    {

        public static Bitmap OriginalImage { get; private set; }

        public static void LoadImage(PictureBox pictureBox)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff";
            openFileDialog.Title = "Select an Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fileExtension = Path.GetExtension(openFileDialog.FileName).ToLower();
                    if (fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png" ||
                        fileExtension == ".bmp" || fileExtension == ".gif" || fileExtension == ".tiff")
                    {
                        OriginalImage = new Bitmap(openFileDialog.FileName);

                      
                        Bitmap resizedImage = new Bitmap(OriginalImage, pictureBox.Size);

                        pictureBox.Image = resizedImage;
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        MessageBox.Show("Invalid file type. Please select a valid image file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading the image. Details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
