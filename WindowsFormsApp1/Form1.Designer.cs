namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.csvKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csvAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.jsonKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.xmlKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Marka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Seri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Yil = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yakıt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vites = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.km = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.renk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.şehir = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.garanti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.durumu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kimden = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1178, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csvKaydetToolStripMenuItem,
            this.csvAçToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(59, 24);
            this.toolStripDropDownButton1.Text = "Csv";
            // 
            // csvKaydetToolStripMenuItem
            // 
            this.csvKaydetToolStripMenuItem.Name = "csvKaydetToolStripMenuItem";
            this.csvKaydetToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.csvKaydetToolStripMenuItem.Text = "Csv Kaydet";
            this.csvKaydetToolStripMenuItem.Click += new System.EventHandler(this.csvKaydetToolStripMenuItem_Click);
            // 
            // csvAçToolStripMenuItem
            // 
            this.csvAçToolStripMenuItem.Name = "csvAçToolStripMenuItem";
            this.csvAçToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.csvAçToolStripMenuItem.Text = "Csv Aç";
            this.csvAçToolStripMenuItem.Click += new System.EventHandler(this.csvAçToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jsonKaydetToolStripMenuItem,
            this.jsonAçToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(63, 24);
            this.toolStripDropDownButton2.Text = "Json";
            // 
            // jsonKaydetToolStripMenuItem
            // 
            this.jsonKaydetToolStripMenuItem.Name = "jsonKaydetToolStripMenuItem";
            this.jsonKaydetToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.jsonKaydetToolStripMenuItem.Text = "Json Kaydet";
            this.jsonKaydetToolStripMenuItem.Click += new System.EventHandler(this.jsonKaydetToolStripMenuItem_Click);
            // 
            // jsonAçToolStripMenuItem
            // 
            this.jsonAçToolStripMenuItem.Name = "jsonAçToolStripMenuItem";
            this.jsonAçToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.jsonAçToolStripMenuItem.Text = "Json Aç";
            this.jsonAçToolStripMenuItem.Click += new System.EventHandler(this.jsonAçToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xmlKaydetToolStripMenuItem,
            this.xmlAçToolStripMenuItem});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(61, 24);
            this.toolStripDropDownButton3.Text = "Xml";
            // 
            // xmlKaydetToolStripMenuItem
            // 
            this.xmlKaydetToolStripMenuItem.Name = "xmlKaydetToolStripMenuItem";
            this.xmlKaydetToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.xmlKaydetToolStripMenuItem.Text = "Xml Kaydet";
            this.xmlKaydetToolStripMenuItem.Click += new System.EventHandler(this.xmlKaydetToolStripMenuItem_Click);
            // 
            // xmlAçToolStripMenuItem
            // 
            this.xmlAçToolStripMenuItem.Name = "xmlAçToolStripMenuItem";
            this.xmlAçToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.xmlAçToolStripMenuItem.Text = "Xml Aç";
            this.xmlAçToolStripMenuItem.Click += new System.EventHandler(this.xmlAçToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Marka,
            this.Seri,
            this.Model,
            this.Yil,
            this.yakıt,
            this.Vites,
            this.km,
            this.renk,
            this.şehir,
            this.garanti,
            this.durumu,
            this.kimden});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 36);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(836, 502);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Marka
            // 
            this.Marka.Text = "Marka";
            this.Marka.Width = 50;
            // 
            // Seri
            // 
            this.Seri.Text = "Seri";
            this.Seri.Width = 50;
            // 
            // Model
            // 
            this.Model.Text = "Model";
            this.Model.Width = 50;
            // 
            // Yil
            // 
            this.Yil.Text = "Yil";
            this.Yil.Width = 50;
            // 
            // yakıt
            // 
            this.yakıt.Text = "yakıt";
            this.yakıt.Width = 50;
            // 
            // Vites
            // 
            this.Vites.Text = "Vites";
            this.Vites.Width = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(844, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(331, 271);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resim";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(844, 345);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ek Bilgi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(844, 364);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(321, 174);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(799, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Araba Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1042, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Araba Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(913, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Araba Düzenle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // km
            // 
            this.km.Text = "km";
            this.km.Width = 50;
            // 
            // renk
            // 
            this.renk.Text = "renk";
            this.renk.Width = 50;
            // 
            // şehir
            // 
            this.şehir.Text = "şehir";
            // 
            // garanti
            // 
            this.garanti.Text = "garanti";
            // 
            // durumu
            // 
            this.durumu.Text = "durumu";
            // 
            // kimden
            // 
            this.kimden.Text = "kimden";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 554);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem csvKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem csvAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem jsonKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jsonAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem xmlKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xmlAçToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColumnHeader Marka;
        private System.Windows.Forms.ColumnHeader Seri;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Yil;
        private System.Windows.Forms.ColumnHeader yakıt;
        private System.Windows.Forms.ColumnHeader Vites;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader km;
        private System.Windows.Forms.ColumnHeader renk;
        private System.Windows.Forms.ColumnHeader şehir;
        private System.Windows.Forms.ColumnHeader garanti;
        private System.Windows.Forms.ColumnHeader durumu;
        private System.Windows.Forms.ColumnHeader kimden;
    }
}

