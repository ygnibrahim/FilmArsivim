namespace FilmArsivim
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpBoxFilmListesi = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHakkımızda = new System.Windows.Forms.Button();
            this.btnÇıkış = new System.Windows.Forms.Button();
            this.btnRenkDegistir = new System.Windows.Forms.Button();
            this.btnTamekran = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilmAD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBoxEkran = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBoxFilmListesi.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpBoxEkran.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 97);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "YEGEN SİNEMA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1106, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grpBoxFilmListesi
            // 
            this.grpBoxFilmListesi.Controls.Add(this.groupBox2);
            this.grpBoxFilmListesi.Controls.Add(this.btnKaydet);
            this.grpBoxFilmListesi.Controls.Add(this.txtLink);
            this.grpBoxFilmListesi.Controls.Add(this.label4);
            this.grpBoxFilmListesi.Controls.Add(this.txtKategori);
            this.grpBoxFilmListesi.Controls.Add(this.label3);
            this.grpBoxFilmListesi.Controls.Add(this.txtFilmAD);
            this.grpBoxFilmListesi.Controls.Add(this.label2);
            this.grpBoxFilmListesi.Location = new System.Drawing.Point(1, 153);
            this.grpBoxFilmListesi.Name = "grpBoxFilmListesi";
            this.grpBoxFilmListesi.Size = new System.Drawing.Size(272, 527);
            this.grpBoxFilmListesi.TabIndex = 1;
            this.grpBoxFilmListesi.TabStop = false;
            this.grpBoxFilmListesi.Text = "Yeni Film";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHakkımızda);
            this.groupBox2.Controls.Add(this.btnÇıkış);
            this.groupBox2.Controls.Add(this.btnRenkDegistir);
            this.groupBox2.Controls.Add(this.btnTamekran);
            this.groupBox2.Location = new System.Drawing.Point(12, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 210);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İslemler";
            // 
            // btnHakkımızda
            // 
            this.btnHakkımızda.Location = new System.Drawing.Point(18, 71);
            this.btnHakkımızda.Name = "btnHakkımızda";
            this.btnHakkımızda.Size = new System.Drawing.Size(219, 31);
            this.btnHakkımızda.TabIndex = 11;
            this.btnHakkımızda.Text = "Hakkımızda";
            this.btnHakkımızda.UseVisualStyleBackColor = true;
            this.btnHakkımızda.Click += new System.EventHandler(this.btnHakkımızda_Click);
            // 
            // btnÇıkış
            // 
            this.btnÇıkış.Location = new System.Drawing.Point(18, 163);
            this.btnÇıkış.Name = "btnÇıkış";
            this.btnÇıkış.Size = new System.Drawing.Size(219, 31);
            this.btnÇıkış.TabIndex = 10;
            this.btnÇıkış.Text = "ÇIKIŞ";
            this.btnÇıkış.UseVisualStyleBackColor = true;
            this.btnÇıkış.Click += new System.EventHandler(this.btnÇıkış_Click);
            // 
            // btnRenkDegistir
            // 
            this.btnRenkDegistir.Location = new System.Drawing.Point(18, 117);
            this.btnRenkDegistir.Name = "btnRenkDegistir";
            this.btnRenkDegistir.Size = new System.Drawing.Size(219, 31);
            this.btnRenkDegistir.TabIndex = 10;
            this.btnRenkDegistir.Text = "Renk Değiştir";
            this.btnRenkDegistir.UseVisualStyleBackColor = true;
            // 
            // btnTamekran
            // 
            this.btnTamekran.Location = new System.Drawing.Point(18, 25);
            this.btnTamekran.Name = "btnTamekran";
            this.btnTamekran.Size = new System.Drawing.Size(219, 31);
            this.btnTamekran.TabIndex = 9;
            this.btnTamekran.Text = "Tam Ekran";
            this.btnTamekran.UseVisualStyleBackColor = true;
            this.btnTamekran.Click += new System.EventHandler(this.btnTamekran_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(134, 235);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(115, 31);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(102, 179);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(147, 26);
            this.txtLink.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Link:";
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(102, 130);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(147, 26);
            this.txtKategori.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kategori:";
            // 
            // txtFilmAD
            // 
            this.txtFilmAD.Location = new System.Drawing.Point(102, 85);
            this.txtFilmAD.Name = "txtFilmAD";
            this.txtFilmAD.Size = new System.Drawing.Size(147, 26);
            this.txtFilmAD.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Film Ad:";
            // 
            // grpBoxEkran
            // 
            this.grpBoxEkran.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpBoxEkran.Controls.Add(this.webBrowser1);
            this.grpBoxEkran.Location = new System.Drawing.Point(627, 153);
            this.grpBoxEkran.Name = "grpBoxEkran";
            this.grpBoxEkran.Size = new System.Drawing.Size(638, 527);
            this.grpBoxEkran.TabIndex = 2;
            this.grpBoxEkran.TabStop = false;
            this.grpBoxEkran.Text = "Ekran";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 22);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(632, 502);
            this.webBrowser1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(320, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 527);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(275, 502);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1277, 692);
            this.Controls.Add(this.grpBoxEkran);
            this.Controls.Add(this.grpBoxFilmListesi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBoxFilmListesi.ResumeLayout(false);
            this.grpBoxFilmListesi.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.grpBoxEkran.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpBoxFilmListesi;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilmAD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpBoxEkran;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHakkımızda;
        private System.Windows.Forms.Button btnÇıkış;
        private System.Windows.Forms.Button btnRenkDegistir;
        private System.Windows.Forms.Button btnTamekran;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

