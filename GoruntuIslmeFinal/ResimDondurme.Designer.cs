namespace GoruntuIslmeFinal
{
    partial class ResimDondurme
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
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnDonustur
            // 
            btnDonustur.Location = new Point(212, 299);
            btnDonustur.Name = "btnDonustur";
            btnDonustur.Size = new Size(133, 49);
            btnDonustur.TabIndex = 9;
            btnDonustur.Text = "donustur";
            btnDonustur.UseVisualStyleBackColor = true;
            btnDonustur.Click += btnDonustur_Click;
            // 
            // btnGoruntuAl
            // 
            btnGoruntuAl.Location = new Point(12, 299);
            btnGoruntuAl.Name = "btnGoruntuAl";
            btnGoruntuAl.Size = new Size(133, 49);
            btnGoruntuAl.TabIndex = 8;
            btnGoruntuAl.Text = "goruntu";
            btnGoruntuAl.UseVisualStyleBackColor = true;
            btnGoruntuAl.Click += btnGoruntuAl_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(443, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(345, 281);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(345, 281);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(212, 375);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 10;
            // 
            // label1
            // 
            label1.Location = new Point(108, 375);
            label1.Name = "label1";
            label1.Size = new Size(88, 40);
            label1.TabIndex = 11;
            label1.Text = "açı";
            // 
            // ResimDondurme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(btnDonustur);
            Controls.Add(btnGoruntuAl);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "ResimDondurme";
            Text = "ResimDondurme";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDonustur;
        private Button btnGoruntuAl;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private TextBox textBox1;
        private Label label1;
    }
}