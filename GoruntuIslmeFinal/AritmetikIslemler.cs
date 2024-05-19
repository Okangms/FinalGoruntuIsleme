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
    public partial class AritmetikIslemler : Form
    {
        public AritmetikIslemler()
        {
            InitializeComponent();
        }
        Bitmap GirisResmi, GirisResmi2;

        private void btnGoruntuAl_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "İşlem için bir görüntü seçin!";
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;

            GirisResmi = new Bitmap(pictureBox1.ImageLocation);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "İşlem için bir görüntü seçin!";
            openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog1.FileName;

            GirisResmi2 = new Bitmap(pictureBox2.ImageLocation);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = AritmetikIslemler.AritmetikCikarma(GirisResmi, GirisResmi2);
        }

        private void btnDonustur_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = AritmetikIslemler.AritmetikCarpma(GirisResmi, GirisResmi2);
        }




        public static Bitmap AritmetikCikarma(Bitmap ilkResim, Bitmap ikinciResim)
        {
            if (ilkResim.Width != ikinciResim.Width || ilkResim.Height != ikinciResim.Height)
            {
                throw new ArgumentException("Resimler aynı boyutta olmalıdır.");
            }

            Bitmap sonucResim = new Bitmap(ilkResim.Width, ilkResim.Height);
            for (int i = 0; i < ilkResim.Width; i++)
            {
                for (int j = 0; j < ilkResim.Height; j++)
                {
                    Color ilkPixel = ilkResim.GetPixel(i, j);
                    Color ikinciPixel = ikinciResim.GetPixel(i, j);

                    int red = Math.Max(ilkPixel.R - ikinciPixel.R, 0);
                    int green = Math.Max(ilkPixel.G - ikinciPixel.G, 0);
                    int blue = Math.Max(ilkPixel.B - ikinciPixel.B, 0);

                    Color yeniPixel = Color.FromArgb(red, green, blue);

                    sonucResim.SetPixel(i, j, yeniPixel);
                }
            }
            return sonucResim;
        }

        public static Bitmap AritmetikCarpma(Bitmap image1, Bitmap image2)
        {
            // Görüntülerin boyutlarının aynı olup olmadığını kontrol etme
            if (image1.Width != image2.Width || image1.Height != image2.Height)
            {
                throw new ArgumentException("Görüntülerin boyutları aynı olmalıdır.");
            }

            // Çıktı için yeni bir görüntü oluştur
            Bitmap resultImage = new Bitmap(image1.Width, image1.Height);

            // Her piksel için aritmetik çarpma işlemi
            for (int x = 0; x < image1.Width; x++)
            {
                for (int y = 0; y < image1.Height; y++)
                {
                    Color pixel1 = image1.GetPixel(x, y);
                    Color pixel2 = image2.GetPixel(x, y);

                    // Piksellerin RGB değerlerini çarpma
                    int newRed = (int)Math.Min(pixel1.R * pixel2.R / 255.0, 255);
                    int newGreen = (int)Math.Min(pixel1.G * pixel2.G / 255.0, 255);
                    int newBlue = (int)Math.Min(pixel1.B * pixel2.B / 255.0, 255);

                    // Yeni pikseli oluşturma ve çıktı görüntüsüne ekleme
                    Color newPixel = Color.FromArgb(newRed, newGreen, newBlue);
                    resultImage.SetPixel(x, y, newPixel);
                }
            }

            return resultImage;
        }

        
    }
}
