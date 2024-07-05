using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoruntuIslmeFinal
{
    public partial class CiftEsikleme : Form
    {
        public CiftEsikleme()
        {
            InitializeComponent();
        }
        Bitmap GirisResmi;
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "İşlem için bir görüntü seçin!";
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;

            GirisResmi = new Bitmap(pictureBox1.ImageLocation);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int lowerThreshold = int.Parse(textBox1.Text);
            int upperThreshold = int.Parse(textBox2.Text);
            Bitmap resultImage = CiftEsikleme.ApplyDoubleThreshold(GirisResmi, lowerThreshold, upperThreshold);
            pictureBox2.Image = (Image)resultImage;
        }

        public static Bitmap ApplyDoubleThreshold(Bitmap image, int lowerThreshold, int upperThreshold)
        {
            Bitmap resultImage = new Bitmap(image.Width, image.Height);

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    int grayValue = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);

                    if (grayValue < lowerThreshold)
                    {
                        resultImage.SetPixel(x, y, Color.Black);
                    }
                    else if (grayValue >= lowerThreshold && grayValue <= upperThreshold)
                    {
                        resultImage.SetPixel(x, y, Color.Gray);
                    }
                    else
                    {
                        resultImage.SetPixel(x, y, Color.White);
                    }
                }
            }

            return resultImage;
        }

        private void CiftEsikleme_Load(object sender, EventArgs e)
        {

        }
    }
}
