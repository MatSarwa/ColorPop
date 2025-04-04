using System.Windows.Forms;
using System.Drawing;

namespace BasicWindowsForm
{
    public class ColorHandler
    {
        private TextBox textBoxR;
        private TextBox textBoxG;
        private TextBox textBoxB;

        public ColorHandler(TextBox textBoxR, TextBox textBoxG, TextBox textBoxB)
        {
            this.textBoxR = textBoxR;
            this.textBoxG = textBoxG;
            this.textBoxB = textBoxB;
        }

        public void ShowColorDialogAndSetRGB()
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
  
                colorDialog.FullOpen = true; 

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color selectedColor = colorDialog.Color;

                    // Aktualizacja pól tekstowych RGB
                    textBoxR.Text = selectedColor.R.ToString();
                    textBoxG.Text = selectedColor.G.ToString();
                    textBoxB.Text = selectedColor.B.ToString();
                }
            }
        }
    }
}
