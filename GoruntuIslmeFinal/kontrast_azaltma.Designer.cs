
namespace goruntu_isleme_proje
{
    partial class kontrast_azaltma
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
            button1 = new Button();
            btnKontrast = new Button();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            button1.Location = new Point(12, 311);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Resmi Al";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnKontrast
            // 
            btnKontrast.Location = new Point(624, 314);
            btnKontrast.Name = "btnKontrast";
            btnKontrast.Size = new Size(94, 29);
            btnKontrast.TabIndex = 14;
            btnKontrast.Text = "Kontrast";
            btnKontrast.UseVisualStyleBackColor = true;
            btnKontrast.Click += btnKontrast_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(568, 316);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(50, 27);
            textBox1.TabIndex = 17;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(373, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(345, 281);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(345, 281);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // kontrast_azaltma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 465);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(btnKontrast);
            Controls.Add(button1);
            Name = "kontrast_azaltma";
            Text = "kontrast_azaltma";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button button1;
        private Button btnKontrast;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
