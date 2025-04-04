using System.Drawing;
using System.Windows.Forms;

namespace BasicWindowsForm
{
    public static class ImageProcessor
    {
        public static void ProcessAndDisplayImage(PictureBox inputPictureBox, PictureBox outputPictureBox)
        {
            if (inputPictureBox.Image == null)
            {
                MessageBox.Show("Proszę załadować obraz do pierwszego PictureBoxu.");
                return;
            }


            Bitmap inputImage = new Bitmap(inputPictureBox.Image);

     
            Bitmap processedImage = new Bitmap(inputImage.Width, inputImage.Height);

            for (int y = 0; y < inputImage.Height; y++)
            {
                for (int x = 0; x < inputImage.Width; x++)
                {
                    Color pixelColor = inputImage.GetPixel(x, y);
               
                    Color newColor = Color.FromArgb(255 - pixelColor.R, 255 - pixelColor.G, 255 - pixelColor.B);
                    processedImage.SetPixel(x, y, newColor);
                }
            }

            Bitmap resizedImage = new Bitmap(processedImage, new Size(outputPictureBox.Width, outputPictureBox.Height));
            outputPictureBox.Image = resizedImage;
        }

    }
}
