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
    public partial class GriDonusum : Form
    {
        public GriDonusum()
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

        private void btnDonustur_Click(object sender, EventArgs e)
        {
            Color renkBilgisi;
            byte griDeger, kirmizi, yesil, mavi;

            for (int i = 0; i < GirisResmi.Width; i++)
            {
                for (int j = 0; j < GirisResmi.Height; j++)
                {
                    renkBilgisi = GirisResmi.GetPixel(i, j);
                    kirmizi = renkBilgisi.R;
                    yesil = renkBilgisi.G;
                    mavi = renkBilgisi.B;

                    griDeger = Convert.ToByte((kirmizi + yesil + mavi) / 3);
                    CikisResmi.SetPixel(i, j, Color.FromArgb(griDeger, griDeger, griDeger));
                }
            }
            pictureBox2.Image = CikisResmi;
        }
    }
    
}
