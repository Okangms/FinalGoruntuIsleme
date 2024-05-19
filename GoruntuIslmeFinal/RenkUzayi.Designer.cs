namespace GoruntuIslmeFinal
{
    partial class RenkUzayi
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnGoruntuAl = new Button();
            btnDonustur = new Button();
            trackBarR = new TrackBar();
            trackBarG = new TrackBar();
            trackBarB = new TrackBar();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarB).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(345, 281);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(443, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(345, 281);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btnGoruntuAl
            // 
            btnGoruntuAl.Location = new Point(12, 299);
            btnGoruntuAl.Name = "btnGoruntuAl";
            btnGoruntuAl.Size = new Size(133, 49);
            btnGoruntuAl.TabIndex = 4;
            btnGoruntuAl.Text = "goruntu";
            btnGoruntuAl.UseVisualStyleBackColor = true;
            btnGoruntuAl.Click += btnGoruntuAl_Click;
            // 
            // btnDonustur
            // 
            btnDonustur.Location = new Point(212, 299);
            btnDonustur.Name = "btnDonustur";
            btnDonustur.Size = new Size(133, 49);
            btnDonustur.TabIndex = 5;
            btnDonustur.Text = "donustur";
            btnDonustur.UseVisualStyleBackColor = true;
            btnDonustur.Click += btnDonustur_Click;
            // 
            // trackBarR
            // 
            trackBarR.BackColor = Color.FromArgb(192, 0, 0);
            trackBarR.Location = new Point(15, 382);
            trackBarR.Maximum = 255;
            trackBarR.Name = "trackBarR";
            trackBarR.Size = new Size(130, 56);
            trackBarR.TabIndex = 6;
            // 
            // trackBarG
            // 
            trackBarG.BackColor = Color.FromArgb(0, 192, 0);
            trackBarG.Location = new Point(176, 382);
            trackBarG.Maximum = 255;
            trackBarG.Name = "trackBarG";
            trackBarG.Size = new Size(130, 56);
            trackBarG.TabIndex = 7;
            // 
            // trackBarB
            // 
            trackBarB.BackColor = Color.FromArgb(0, 192, 192);
            trackBarB.Location = new Point(336, 382);
            trackBarB.Maximum = 255;
            trackBarB.Name = "trackBarB";
            trackBarB.Size = new Size(130, 56);
            trackBarB.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // RenkUzayi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(trackBarB);
            Controls.Add(trackBarG);
            Controls.Add(trackBarR);
            Controls.Add(btnDonustur);
            Controls.Add(btnGoruntuAl);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "RenkUzayi";
            Text = "RenkUzayi";
            Load += RenkUzayi_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarR).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarG).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnGoruntuAl;
        private Button btnDonustur;
        private TrackBar trackBarR;
        private TrackBar trackBarG;
        private TrackBar trackBarB;
        private OpenFileDialog openFileDialog1;
    }
}