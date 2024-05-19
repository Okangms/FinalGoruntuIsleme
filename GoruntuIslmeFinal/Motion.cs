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
    public partial class Motion : Form
    {
        public Motion()
        {
            InitializeComponent();
        }
        Bitmap GirisResmi;
        private void btnResimAl_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "İşlem için bir görüntü seçin!";
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;

            GirisResmi = new Bitmap(pictureBox1.ImageLocation);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int blurAmount = int.Parse(textBox1.Text);
            int angle = int.Parse(textBox2.Text);
            Bitmap filteredImage = Motion.ApplyMotionBlur(GirisResmi, blurAmount, angle);

            pictureBox2.Image = filteredImage;
        }

        public static Bitmap ApplyMotionBlur(Bitmap image, int blurAmount, double angle)
        {
            Bitmap blurredImage = new Bitmap(image.Width, image.Height);

            // Radyan cinsinden açıyı dereceye dönüştür
            double angleInRadians = angle * Math.PI / 180.0;

            // Bulanıklık etkisini uygula
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    int sumR = 0, sumG = 0, sumB = 0, count = 0;

                    for (int i = -blurAmount; i <= blurAmount; i++)
                    {
                        int offsetX = (int)(i * Math.Cos(angleInRadians));
                        int offsetY = (int)(i * Math.Sin(angleInRadians));

                        int newX = x + offsetX;
                        int newY = y + offsetY;

                        if (newX >= 0 && newX < image.Width && newY >= 0 && newY < image.Height)
                        {
                            Color pixel = image.GetPixel(newX, newY);
                            sumR += pixel.R;
                            sumG += pixel.G;
                            sumB += pixel.B;
                            count++;
                        }
                    }

                    int avgR = sumR / count;
                    int avgG = sumG / count;
                    int avgB = sumB / count;

                    blurredImage.SetPixel(x, y, Color.FromArgb(avgR, avgG, avgB));
                }
            }

            return blurredImage;
        }



    }
}
