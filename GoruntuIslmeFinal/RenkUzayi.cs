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
    public partial class RenkUzayi : Form
    {
        public RenkUzayi()
        {
            InitializeComponent();
        }
        public Bitmap GirisResmi;
        public Bitmap CikisResmi;
        private void btnGoruntuAl_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "İşlem için bir görüntü seçin!";
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            GirisResmi = new Bitmap(pictureBox1.ImageLocation);
            CikisResmi = new Bitmap(pictureBox1.ImageLocation);
        }

        private void RenkUzayi_Load(object sender, EventArgs e)
        {
            trackBarR.Value = 0;
            trackBarG.Value = 0;
            trackBarB.Value = 0;
        }

        private void btnDonustur_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = RenkUzayi.ChangeImageColor((Bitmap)pictureBox1.Image, trackBarR.Value, trackBarG.Value, trackBarB.Value);
        }





        public static Bitmap ChangeImageColor(Bitmap originalImage, int redValue, int greenValue, int blueValue)
        {
            Bitmap newImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color originalColor = originalImage.GetPixel(x, y);
                    Color newColor = Color.FromArgb(
                        originalColor.A,
                        Math.Min(originalColor.R + redValue, 255),
                        Math.Min(originalColor.G + greenValue, 255),
                        Math.Min(originalColor.B + blueValue, 255)
                    );
                    newImage.SetPixel(x, y, newColor);
                }
            }

            return newImage;
        }

    }
}
