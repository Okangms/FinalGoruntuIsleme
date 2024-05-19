namespace GoruntuIslmeFinal
{
    partial class Zoom
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
            btnDonustur = new Button();
            btnGoruntuAl = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            textBox1 = new TextBox();
            splitter1 = new Splitter();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDonustur
            // 
            btnDonustur.Location = new Point(212, 299);
            btnDonustur.Name = "btnDonustur";
            btnDonustur.Size = new Size(133, 49);
            btnDonustur.TabIndex = 9;
            btnDonustur.Text = "küçült";
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
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(345, 281);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(224, 363);
            button1.Name = "button1";
            button1.Size = new Size(133, 49);
            button1.TabIndex = 10;
            button1.Text = "büyüt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(48, 385);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 11;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 450);
            splitter1.TabIndex = 12;
            splitter1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(382, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(406, 426);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // Zoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(splitter1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(btnDonustur);
            Controls.Add(btnGoruntuAl);
            Controls.Add(pictureBox1);
            Name = "Zoom";
            Text = "Zoom";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button btnDonustur;
        private Button btnGoruntuAl;
        private PictureBox pictureBox1;
        private Button button1;
        private TextBox textBox1;
        private Splitter splitter1;
        private PictureBox pictureBox2;
    }
}