namespace GoruntuIslmeFinal
{
    partial class GriDonusum
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
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(26, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(345, 281);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(443, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(345, 281);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btnGoruntuAl
            // 
            btnGoruntuAl.Location = new Point(26, 328);
            btnGoruntuAl.Name = "btnGoruntuAl";
            btnGoruntuAl.Size = new Size(133, 49);
            btnGoruntuAl.TabIndex = 2;
            btnGoruntuAl.Text = "goruntu";
            btnGoruntuAl.UseVisualStyleBackColor = true;
            btnGoruntuAl.Click += btnGoruntuAl_Click;
            // 
            // btnDonustur
            // 
            btnDonustur.Location = new Point(202, 328);
            btnDonustur.Name = "btnDonustur";
            btnDonustur.Size = new Size(133, 49);
            btnDonustur.TabIndex = 3;
            btnDonustur.Text = "donustur";
            btnDonustur.UseVisualStyleBackColor = true;
            btnDonustur.Click += btnDonustur_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // GriDonusum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDonustur);
            Controls.Add(btnGoruntuAl);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "GriDonusum";
            Text = "GriDonusum";
            Load += GriDonusum_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnGoruntuAl;
        private Button btnDonustur;
        private OpenFileDialog openFileDialog1;
    }
}