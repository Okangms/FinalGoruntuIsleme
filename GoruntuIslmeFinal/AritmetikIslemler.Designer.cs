namespace GoruntuIslmeFinal
{
    partial class AritmetikIslemler
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
            btnDonustur = new Button();
            btnGoruntuAl = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnDonustur
            // 
            btnDonustur.Location = new Point(626, 392);
            btnDonustur.Name = "btnDonustur";
            btnDonustur.Size = new Size(133, 49);
            btnDonustur.TabIndex = 21;
            btnDonustur.Text = "Çarp";
            btnDonustur.UseVisualStyleBackColor = true;
            btnDonustur.Click += btnDonustur_Click;
            // 
            // btnGoruntuAl
            // 
            btnGoruntuAl.Location = new Point(428, 337);
            btnGoruntuAl.Name = "btnGoruntuAl";
            btnGoruntuAl.Size = new Size(133, 49);
            btnGoruntuAl.TabIndex = 20;
            btnGoruntuAl.Text = "goruntu";
            btnGoruntuAl.UseVisualStyleBackColor = true;
            btnGoruntuAl.Click += btnGoruntuAl_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(3, 299);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(345, 281);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(345, 281);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            button1.Location = new Point(428, 392);
            button1.Name = "button1";
            button1.Size = new Size(133, 49);
            button1.TabIndex = 22;
            button1.Text = "goruntu 2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(428, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(345, 281);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(626, 337);
            button2.Name = "button2";
            button2.Size = new Size(133, 49);
            button2.TabIndex = 24;
            button2.Text = "Çıkartma";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AritmetikIslemler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 603);
            Controls.Add(button2);
            Controls.Add(pictureBox3);
            Controls.Add(button1);
            Controls.Add(btnDonustur);
            Controls.Add(btnGoruntuAl);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "AritmetikIslemler";
            Text = "AritmetikIslemler";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDonustur;
        private Button btnGoruntuAl;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private Button button1;
        private PictureBox pictureBox3;
        private Button button2;
    }
}