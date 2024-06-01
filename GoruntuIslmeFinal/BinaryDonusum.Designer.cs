namespace GoruntuIslmeFinal
{
    partial class BinaryDonusum
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
            openFileDialog1 = new OpenFileDialog();
            btnDonustur = new Button();
            textBox1 = new TextBox();
            threshold = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(345, 281);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(443, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(345, 281);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // btnGoruntuAl
            // 
            btnGoruntuAl.Location = new Point(12, 312);
            btnGoruntuAl.Name = "btnGoruntuAl";
            btnGoruntuAl.Size = new Size(133, 49);
            btnGoruntuAl.TabIndex = 3;
            btnGoruntuAl.Text = "goruntu";
            btnGoruntuAl.UseVisualStyleBackColor = true;
            btnGoruntuAl.Click += btnGoruntuAl_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDonustur
            // 
            btnDonustur.Location = new Point(189, 312);
            btnDonustur.Name = "btnDonustur";
            btnDonustur.Size = new Size(133, 49);
            btnDonustur.TabIndex = 4;
            btnDonustur.Text = "donustur";
            btnDonustur.UseVisualStyleBackColor = true;
            btnDonustur.Click += btnDonustur_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(189, 378);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            // 
            // threshold
            // 
            threshold.Location = new Point(91, 378);
            threshold.Name = "threshold";
            threshold.Size = new Size(92, 46);
            threshold.TabIndex = 6;
            threshold.Text = "threshold";
            // 
            // BinaryDonusum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(threshold);
            Controls.Add(textBox1);
            Controls.Add(btnDonustur);
            Controls.Add(btnGoruntuAl);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "BinaryDonusum";
            Text = "BinaryDonusum";
            Load += BinaryDonusum_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnGoruntuAl;
        private OpenFileDialog openFileDialog1;
        private Button btnDonustur;
        private TextBox textBox1;
        private Label threshold;
    }
}