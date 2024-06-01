using goruntu_isleme_proje;

namespace GoruntuIslmeFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GriDonusum griDonusum = new GriDonusum();
            griDonusum.Show();
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryDonusum binaryDonusum = new BinaryDonusum();
            binaryDonusum.Show();
        }

        private void renkUzay�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenkUzayi renk = new RenkUzayi();
            renk.Show();
        }

        private void d�nd�rmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResimDondurme resim = new ResimDondurme();
            resim.Show();
        }

        private void k�rpmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kirpma kirpma = new Kirpma();
            kirpma.Show();
        }

        private void yak�nla�t�rmauzakla�t�rmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zoom zoom = new Zoom();
            zoom.Show();
        }

        private void histogramToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            histogram_germe_genisletme histogram_Germe_Genisletme = new histogram_germe_genisletme();
            histogram_Germe_Genisletme.Show();
        }

        private void ��karmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AritmetikIslemler aritmetikislemler = new AritmetikIslemler();
            aritmetikislemler.Show();
        }

        private void konvol�sy�onMedianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Konvolisyyon_Median konvolisyyon_Median = new Konvolisyyon_Median();
            konvolisyyon_Median.Show();
        }

        private void kontrastAzaltmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kontrast_azaltma kontrast_Azaltma = new kontrast_azaltma();
            kontrast_Azaltma.Show();
        }

        private void �iftE�iklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CiftEsikleme ciftEsikleme = new CiftEsikleme();
            ciftEsikleme.Show();
        }

        private void kenarBulmaCannyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Canny canny = new Canny();
            canny.Show();
        }

        private void saltPaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gurultu_ekleme_ve_flitre_uygulama gurultu_Ekleme_Ve_Flitre_Uygulama = new Gurultu_ekleme_ve_flitre_uygulama();
            gurultu_Ekleme_Ve_Flitre_Uygulama.Show();
        }

        private void motionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Motion motion = new Motion();
            motion.Show();
        }

        private void morfolojik��lemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Morfolojik_islemler morfolojik_�slemler = new Morfolojik_islemler();
            morfolojik_�slemler.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
