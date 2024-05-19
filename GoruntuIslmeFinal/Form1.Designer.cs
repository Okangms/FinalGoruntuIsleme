namespace GoruntuIslmeFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            dosyaToolStripMenuItem = new ToolStripMenuItem();
            binaryToolStripMenuItem = new ToolStripMenuItem();
            griToolStripMenuItem = new ToolStripMenuItem();
            renkUzayıToolStripMenuItem = new ToolStripMenuItem();
            biçimlendirmeToolStripMenuItem = new ToolStripMenuItem();
            döndürmeToolStripMenuItem = new ToolStripMenuItem();
            kırpmaToolStripMenuItem = new ToolStripMenuItem();
            yakınlaştırmauzaklaştırmaToolStripMenuItem = new ToolStripMenuItem();
            histogramToolStripMenuItem = new ToolStripMenuItem();
            histogramToolStripMenuItem1 = new ToolStripMenuItem();
            aritmetikİşlemlerToolStripMenuItem = new ToolStripMenuItem();
            çıkarmaToolStripMenuItem = new ToolStripMenuItem();
            işlemlerToolStripMenuItem = new ToolStripMenuItem();
            kontrastAzaltmaToolStripMenuItem = new ToolStripMenuItem();
            konvolüsyüonMedianToolStripMenuItem = new ToolStripMenuItem();
            çiftEşiklemeToolStripMenuItem = new ToolStripMenuItem();
            kenarBulmaCannyToolStripMenuItem = new ToolStripMenuItem();
            filtrelerToolStripMenuItem = new ToolStripMenuItem();
            saltPaperToolStripMenuItem = new ToolStripMenuItem();
            motionToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            filtrelerToolStripMenuItem1 = new ToolStripMenuItem();
            morfolojikİşlemlerToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dosyaToolStripMenuItem, biçimlendirmeToolStripMenuItem, histogramToolStripMenuItem, aritmetikİşlemlerToolStripMenuItem, işlemlerToolStripMenuItem, filtrelerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            dosyaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { binaryToolStripMenuItem, griToolStripMenuItem, renkUzayıToolStripMenuItem });
            dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            dosyaToolStripMenuItem.Size = new Size(86, 24);
            dosyaToolStripMenuItem.Text = "Dönüşüm";
            // 
            // binaryToolStripMenuItem
            // 
            binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
            binaryToolStripMenuItem.Size = new Size(224, 26);
            binaryToolStripMenuItem.Text = "Gri";
            binaryToolStripMenuItem.Click += binaryToolStripMenuItem_Click;
            // 
            // griToolStripMenuItem
            // 
            griToolStripMenuItem.Name = "griToolStripMenuItem";
            griToolStripMenuItem.Size = new Size(224, 26);
            griToolStripMenuItem.Text = "Binary";
            griToolStripMenuItem.Click += griToolStripMenuItem_Click;
            // 
            // renkUzayıToolStripMenuItem
            // 
            renkUzayıToolStripMenuItem.Name = "renkUzayıToolStripMenuItem";
            renkUzayıToolStripMenuItem.Size = new Size(224, 26);
            renkUzayıToolStripMenuItem.Text = "Renk Uzayı";
            renkUzayıToolStripMenuItem.Click += renkUzayıToolStripMenuItem_Click;
            // 
            // biçimlendirmeToolStripMenuItem
            // 
            biçimlendirmeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { döndürmeToolStripMenuItem, kırpmaToolStripMenuItem, yakınlaştırmauzaklaştırmaToolStripMenuItem });
            biçimlendirmeToolStripMenuItem.Name = "biçimlendirmeToolStripMenuItem";
            biçimlendirmeToolStripMenuItem.Size = new Size(119, 24);
            biçimlendirmeToolStripMenuItem.Text = "Biçimlendirme";
            // 
            // döndürmeToolStripMenuItem
            // 
            döndürmeToolStripMenuItem.Name = "döndürmeToolStripMenuItem";
            döndürmeToolStripMenuItem.Size = new Size(268, 26);
            döndürmeToolStripMenuItem.Text = "döndürme";
            döndürmeToolStripMenuItem.Click += döndürmeToolStripMenuItem_Click;
            // 
            // kırpmaToolStripMenuItem
            // 
            kırpmaToolStripMenuItem.Name = "kırpmaToolStripMenuItem";
            kırpmaToolStripMenuItem.Size = new Size(268, 26);
            kırpmaToolStripMenuItem.Text = "kırpma";
            kırpmaToolStripMenuItem.Click += kırpmaToolStripMenuItem_Click;
            // 
            // yakınlaştırmauzaklaştırmaToolStripMenuItem
            // 
            yakınlaştırmauzaklaştırmaToolStripMenuItem.Name = "yakınlaştırmauzaklaştırmaToolStripMenuItem";
            yakınlaştırmauzaklaştırmaToolStripMenuItem.Size = new Size(268, 26);
            yakınlaştırmauzaklaştırmaToolStripMenuItem.Text = "yakınlaştırma/uzaklaştırma";
            yakınlaştırmauzaklaştırmaToolStripMenuItem.Click += yakınlaştırmauzaklaştırmaToolStripMenuItem_Click;
            // 
            // histogramToolStripMenuItem
            // 
            histogramToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { histogramToolStripMenuItem1 });
            histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            histogramToolStripMenuItem.Size = new Size(93, 24);
            histogramToolStripMenuItem.Text = "Histogram";
            // 
            // histogramToolStripMenuItem1
            // 
            histogramToolStripMenuItem1.Name = "histogramToolStripMenuItem1";
            histogramToolStripMenuItem1.Size = new Size(224, 26);
            histogramToolStripMenuItem1.Text = "histogram";
            histogramToolStripMenuItem1.Click += histogramToolStripMenuItem1_Click;
            // 
            // aritmetikİşlemlerToolStripMenuItem
            // 
            aritmetikİşlemlerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { çıkarmaToolStripMenuItem });
            aritmetikİşlemlerToolStripMenuItem.Name = "aritmetikİşlemlerToolStripMenuItem";
            aritmetikİşlemlerToolStripMenuItem.Size = new Size(140, 24);
            aritmetikİşlemlerToolStripMenuItem.Text = "Aritmetik İşlemler";
            // 
            // çıkarmaToolStripMenuItem
            // 
            çıkarmaToolStripMenuItem.Name = "çıkarmaToolStripMenuItem";
            çıkarmaToolStripMenuItem.Size = new Size(224, 26);
            çıkarmaToolStripMenuItem.Text = "İşlemler";
            çıkarmaToolStripMenuItem.Click += çıkarmaToolStripMenuItem_Click;
            // 
            // işlemlerToolStripMenuItem
            // 
            işlemlerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kontrastAzaltmaToolStripMenuItem, konvolüsyüonMedianToolStripMenuItem, çiftEşiklemeToolStripMenuItem, kenarBulmaCannyToolStripMenuItem, morfolojikİşlemlerToolStripMenuItem });
            işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            işlemlerToolStripMenuItem.Size = new Size(75, 24);
            işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // kontrastAzaltmaToolStripMenuItem
            // 
            kontrastAzaltmaToolStripMenuItem.Name = "kontrastAzaltmaToolStripMenuItem";
            kontrastAzaltmaToolStripMenuItem.Size = new Size(240, 26);
            kontrastAzaltmaToolStripMenuItem.Text = "Kontrast Azaltma";
            kontrastAzaltmaToolStripMenuItem.Click += kontrastAzaltmaToolStripMenuItem_Click;
            // 
            // konvolüsyüonMedianToolStripMenuItem
            // 
            konvolüsyüonMedianToolStripMenuItem.Name = "konvolüsyüonMedianToolStripMenuItem";
            konvolüsyüonMedianToolStripMenuItem.Size = new Size(240, 26);
            konvolüsyüonMedianToolStripMenuItem.Text = "Konvolüsyon (Median)";
            konvolüsyüonMedianToolStripMenuItem.Click += konvolüsyüonMedianToolStripMenuItem_Click;
            // 
            // çiftEşiklemeToolStripMenuItem
            // 
            çiftEşiklemeToolStripMenuItem.Name = "çiftEşiklemeToolStripMenuItem";
            çiftEşiklemeToolStripMenuItem.Size = new Size(240, 26);
            çiftEşiklemeToolStripMenuItem.Text = "Çift Eşikleme";
            çiftEşiklemeToolStripMenuItem.Click += çiftEşiklemeToolStripMenuItem_Click;
            // 
            // kenarBulmaCannyToolStripMenuItem
            // 
            kenarBulmaCannyToolStripMenuItem.Name = "kenarBulmaCannyToolStripMenuItem";
            kenarBulmaCannyToolStripMenuItem.Size = new Size(240, 26);
            kenarBulmaCannyToolStripMenuItem.Text = "Kenar Bulma(Canny)";
            kenarBulmaCannyToolStripMenuItem.Click += kenarBulmaCannyToolStripMenuItem_Click;
            // 
            // filtrelerToolStripMenuItem
            // 
            filtrelerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saltPaperToolStripMenuItem, motionToolStripMenuItem, filtrelerToolStripMenuItem1 });
            filtrelerToolStripMenuItem.Name = "filtrelerToolStripMenuItem";
            filtrelerToolStripMenuItem.Size = new Size(73, 24);
            filtrelerToolStripMenuItem.Text = "Filtreler";
            // 
            // saltPaperToolStripMenuItem
            // 
            saltPaperToolStripMenuItem.Name = "saltPaperToolStripMenuItem";
            saltPaperToolStripMenuItem.Size = new Size(269, 26);
            saltPaperToolStripMenuItem.Text = "Salt&Paper - Mean - Median";
            saltPaperToolStripMenuItem.Click += saltPaperToolStripMenuItem_Click;
            // 
            // motionToolStripMenuItem
            // 
            motionToolStripMenuItem.Name = "motionToolStripMenuItem";
            motionToolStripMenuItem.Size = new Size(269, 26);
            motionToolStripMenuItem.Text = "Motion";
            motionToolStripMenuItem.Click += motionToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(23, 57);
            label1.Name = "label1";
            label1.Size = new Size(754, 80);
            label1.TabIndex = 1;
            label1.Text = "213301002 Muhammed Fatih İNCE";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(23, 137);
            label2.Name = "label2";
            label2.Size = new Size(754, 80);
            label2.TabIndex = 2;
            label2.Text = "213301119 Ramazan  Baranlı";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(23, 217);
            label3.Name = "label3";
            label3.Size = new Size(754, 80);
            label3.TabIndex = 3;
            label3.Text = "213301120 Okan GÜMÜŞ";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(23, 312);
            label4.Name = "label4";
            label4.Size = new Size(754, 80);
            label4.TabIndex = 4;
            label4.Text = "Grup No:5        Proje NO:2";
            // 
            // filtrelerToolStripMenuItem1
            // 
            filtrelerToolStripMenuItem1.Name = "filtrelerToolStripMenuItem1";
            filtrelerToolStripMenuItem1.Size = new Size(269, 26);
            filtrelerToolStripMenuItem1.Text = "Filtreler";
            // 
            // morfolojikİşlemlerToolStripMenuItem
            // 
            morfolojikİşlemlerToolStripMenuItem.Name = "morfolojikİşlemlerToolStripMenuItem";
            morfolojikİşlemlerToolStripMenuItem.Size = new Size(240, 26);
            morfolojikİşlemlerToolStripMenuItem.Text = "Morfolojik İşlemler";
            morfolojikİşlemlerToolStripMenuItem.Click += morfolojikİşlemlerToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem binaryToolStripMenuItem;
        private ToolStripMenuItem griToolStripMenuItem;
        private ToolStripMenuItem renkUzayıToolStripMenuItem;
        private ToolStripMenuItem biçimlendirmeToolStripMenuItem;
        private ToolStripMenuItem döndürmeToolStripMenuItem;
        private ToolStripMenuItem kırpmaToolStripMenuItem;
        private ToolStripMenuItem yakınlaştırmauzaklaştırmaToolStripMenuItem;
        private ToolStripMenuItem histogramToolStripMenuItem;
        private ToolStripMenuItem histogramToolStripMenuItem1;
        private ToolStripMenuItem aritmetikİşlemlerToolStripMenuItem;
        private ToolStripMenuItem çıkarmaToolStripMenuItem;
        private ToolStripMenuItem işlemlerToolStripMenuItem;
        private ToolStripMenuItem kontrastAzaltmaToolStripMenuItem;
        private ToolStripMenuItem konvolüsyüonMedianToolStripMenuItem;
        private ToolStripMenuItem çiftEşiklemeToolStripMenuItem;
        private ToolStripMenuItem kenarBulmaCannyToolStripMenuItem;
        private ToolStripMenuItem filtrelerToolStripMenuItem;
        private ToolStripMenuItem saltPaperToolStripMenuItem;
        private ToolStripMenuItem motionToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ToolStripMenuItem morfolojikİşlemlerToolStripMenuItem;
        private ToolStripMenuItem filtrelerToolStripMenuItem1;
    }
}
