
namespace goruntu_isleme_proje
{
    partial class Gurultu_ekleme_ve_flitre_uygulama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            btnResimAl = new Button();
            btnGurultuEkle = new Button();
            btnMeanFiltre = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnMedian = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnResimAl
            // 
            btnResimAl.Location = new Point(32, 326);
            btnResimAl.Name = "btnResimAl";
            btnResimAl.Size = new Size(94, 29);
            btnResimAl.TabIndex = 2;
            btnResimAl.Text = "Resmi Al";
            btnResimAl.UseVisualStyleBackColor = true;
            btnResimAl.Click += btnResimAl_Click;
            // 
            // btnGurultuEkle
            // 
            btnGurultuEkle.Location = new Point(365, 326);
            btnGurultuEkle.Name = "btnGurultuEkle";
            btnGurultuEkle.Size = new Size(145, 29);
            btnGurultuEkle.TabIndex = 3;
            btnGurultuEkle.Text = "Gürültü Ekle";
            btnGurultuEkle.UseVisualStyleBackColor = true;
            btnGurultuEkle.Click += btnGurultuEkle_Click;
            // 
            // btnMeanFiltre
            // 
            btnMeanFiltre.Location = new Point(725, 326);
            btnMeanFiltre.Name = "btnMeanFiltre";
            btnMeanFiltre.Size = new Size(145, 29);
            btnMeanFiltre.TabIndex = 5;
            btnMeanFiltre.Text = "Mean Filtre";
            btnMeanFiltre.UseVisualStyleBackColor = true;
            btnMeanFiltre.Click += btnMeanFiltre_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(745, 361);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1106, 361);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 9;
            // 
            // btnMedian
            // 
            btnMedian.Location = new Point(1086, 326);
            btnMedian.Name = "btnMedian";
            btnMedian.Size = new Size(145, 29);
            btnMedian.TabIndex = 8;
            btnMedian.Text = "Median Filtre";
            btnMedian.UseVisualStyleBackColor = true;
            btnMedian.Click += btnMedian_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(365, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(345, 281);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(4, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(345, 281);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(725, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(345, 281);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 31;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(1086, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(345, 281);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 30;
            pictureBox4.TabStop = false;
            // 
            // Gurultu_ekleme_ve_flitre_uygulama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1457, 554);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(btnMedian);
            Controls.Add(textBox1);
            Controls.Add(btnMeanFiltre);
            Controls.Add(btnGurultuEkle);
            Controls.Add(btnResimAl);
            Name = "Gurultu_ekleme_ve_flitre_uygulama";
            Text = "Gurultu_ekleme_ve_flitre_uygulama";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button btnResimAl;
        private Button btnGurultuEkle;
        private Button btnMeanFiltre;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnMedian;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}