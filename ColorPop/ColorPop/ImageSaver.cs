using System;
using System.Drawing;
using System.Windows.Forms;


namespace BasicWindowsForm
{
    public static class ImageSaver
    {
        public static void SaveImage(Bitmap originalImage)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Nie ma obrazu do zapisania. Proszę załadować obraz najpierw.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "JPEG Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp",
                Title = "Zapisz obraz jako"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = saveFileDialog.FileName;

              
                    originalImage.Save(filePath);
                    MessageBox.Show("Obraz został zapisany pomyślnie.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd podczas zapisywania obrazu: " + ex.Message);
                }
            }
        }
    }
}
