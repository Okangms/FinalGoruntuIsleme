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
    public partial class Canny : Form
    {
        public Canny()
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

        private void button2_Click(object sender, EventArgs e)
        {

            Bitmap grayImage = ToGrayscale(GirisResmi);
            Bitmap blurredImage = GaussianBlur(grayImage);
            (Bitmap gradientImage, double[,] gradientDirections) = ComputeGradients(blurredImage);
            Bitmap nonMaxSuppressedImage = NonMaximumSuppression(gradientImage, gradientDirections);
            Bitmap finalImage = DoubleThresholdHysteresis(nonMaxSuppressedImage, 50, 150);
            pictureBox2.Image = finalImage;


        }

        private Bitmap ToGrayscale(Bitmap original)
        {
            Bitmap gray = new Bitmap(original.Width, original.Height);
            for (int y = 0; y < original.Height; y++)
            {
                for (int x = 0; x < original.Width; x++)
                {
                    Color c = original.GetPixel(x, y);
                    int grayValue = (int)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11);
                    gray.SetPixel(x, y, Color.FromArgb(grayValue, grayValue, grayValue));
                }
            }
            return gray;
        }

        private Bitmap GaussianBlur(Bitmap grayImage)
        {
            // Basit bir 5x5 Gaussian bulanıklık çekirdeği
            double[,] kernel = {
                { 2,  4,  5,  4, 2 },
                { 4,  9, 12,  9, 4 },
                { 5, 12, 15, 12, 5 },
                { 4,  9, 12,  9, 4 },
                { 2,  4,  5,  4, 2 }
            };

            int kernelWidth = kernel.GetLength(0);
            int kernelHeight = kernel.GetLength(1);
            int kernelSum = 159; // Kernel elemanlarının toplamı

            Bitmap blurred = new Bitmap(grayImage.Width, grayImage.Height);
            for (int y = 2; y < grayImage.Height - 2; y++)
            {
                for (int x = 2; x < grayImage.Width - 2; x++)
                {
                    double sum = 0.0;
                    for (int ky = -2; ky <= 2; ky++)
                    {
                        for (int kx = -2; kx <= 2; kx++)
                        {
                            Color c = grayImage.GetPixel(x + kx, y + ky);
                            sum += c.R * kernel[ky + 2, kx + 2];
                        }
                    }
                    int newValue = (int)(sum / kernelSum);
                    blurred.SetPixel(x, y, Color.FromArgb(newValue, newValue, newValue));
                }
            }
            return blurred;
        }

        private (Bitmap, double[,]) ComputeGradients(Bitmap blurredImage)
        {
            int width = blurredImage.Width;
            int height = blurredImage.Height;

            Bitmap gradientImage = new Bitmap(width, height);
            double[,] gradientDirections = new double[width, height];

            int[,] gx = {
        { -1, 0, 1 },
        { -2, 0, 2 },
        { -1, 0, 1 }
    };

            int[,] gy = {
        { -1, -2, -1 },
        {  0,  0,  0 },
        {  1,  2,  1 }
    };

            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    double sumX = 0;
                    double sumY = 0;
                    for (int ky = -1; ky <= 1; ky++)
                    {
                        for (int kx = -1; kx <= 1; kx++)
                        {
                            Color c = blurredImage.GetPixel(x + kx, y + ky);
                            sumX += c.R * gx[ky + 1, kx + 1];
                            sumY += c.R * gy[ky + 1, kx + 1];
                        }
                    }
                    double gradient = Math.Sqrt(sumX * sumX + sumY * sumY);
                    double direction = Math.Atan2(sumY, sumX) * (180.0 / Math.PI);
                    if (direction < 0) direction += 180;

                    int gradientInt = (int)Math.Min(255, Math.Max(0, gradient));
                    gradientImage.SetPixel(x, y, Color.FromArgb(gradientInt, gradientInt, gradientInt));
                    gradientDirections[x, y] = direction;
                }
            }
            return (gradientImage, gradientDirections);
        }

        private Bitmap NonMaximumSuppression(Bitmap gradientImage, double[,] gradientDirections)
        {
            Bitmap suppressed = new Bitmap(gradientImage.Width, gradientImage.Height);

            for (int y = 1; y < gradientImage.Height - 1; y++)
            {
                for (int x = 1; x < gradientImage.Width - 1; x++)
                {
                    double direction = gradientDirections[x, y];
                    int g = gradientImage.GetPixel(x, y).R;

                    int g1 = 0;
                    int g2 = 0;

                    if ((0 <= direction && direction < 22.5) || (157.5 <= direction && direction <= 180))
                    {
                        g1 = gradientImage.GetPixel(x - 1, y).R;
                        g2 = gradientImage.GetPixel(x + 1, y).R;
                    }
                    else if (22.5 <= direction && direction < 67.5)
                    {
                        g1 = gradientImage.GetPixel(x - 1, y - 1).R;
                        g2 = gradientImage.GetPixel(x + 1, y + 1).R;
                    }
                    else if (67.5 <= direction && direction < 112.5)
                    {
                        g1 = gradientImage.GetPixel(x, y - 1).R;
                        g2 = gradientImage.GetPixel(x, y + 1).R;
                    }
                    else if (112.5 <= direction && direction < 157.5)
                    {
                        g1 = gradientImage.GetPixel(x + 1, y - 1).R;
                        g2 = gradientImage.GetPixel(x - 1, y + 1).R;
                    }

                    if (g >= g1 && g >= g2)
                    {
                        suppressed.SetPixel(x, y, Color.FromArgb(g, g, g));
                    }
                    else
                    {
                        suppressed.SetPixel(x, y, Color.Black);
                    }
                }
            }
            return suppressed;
        }

        private Bitmap DoubleThresholdHysteresis(Bitmap suppressedImage, int lowThreshold, int highThreshold)
        {
            Bitmap finalImage = new Bitmap(suppressedImage.Width, suppressedImage.Height);

            for (int y = 0; y < suppressedImage.Height; y++)
            {
                for (int x = 0; x < suppressedImage.Width; x++)
                {
                    int pixelValue = suppressedImage.GetPixel(x, y).R;
                    if (pixelValue >= highThreshold)
                    {
                        finalImage.SetPixel(x, y, Color.White);
                    }
                    else if (pixelValue >= lowThreshold)
                    {
                        bool anyStrongEdgeNearby = false;
                        for (int ky = -1; ky <= 1; ky++)
                        {
                            for (int kx = -1; kx <= 1; kx++)
                            {
                                if (y + ky < 0 || y + ky >= suppressedImage.Height || x + kx < 0 || x + kx >= suppressedImage.Width)
                                    continue;
                                if (suppressedImage.GetPixel(x + kx, y + ky).R >= highThreshold)
                                {
                                    anyStrongEdgeNearby = true;
                                    break;
                                }
                            }
                            if (anyStrongEdgeNearby)
                                break;
                        }
                        finalImage.SetPixel(x, y, anyStrongEdgeNearby ? Color.White : Color.Black);
                    }
                    else
                    {
                        finalImage.SetPixel(x, y, Color.Black);
                    }
                }
            }
            return finalImage;
        }

    }
}
