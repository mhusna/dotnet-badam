namespace EF_III
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.lblUrunId = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblUrunFiyat = new System.Windows.Forms.Label();
            this.tbxUrunId = new System.Windows.Forms.TextBox();
            this.tbxUrunAdi = new System.Windows.Forms.TextBox();
            this.tbxUrunFiyat = new System.Windows.Forms.TextBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.pnlUpdateDelete = new System.Windows.Forms.Panel();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlUpdateDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Black;
            label1.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.ForestGreen;
            label1.Location = new System.Drawing.Point(307, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(346, 44);
            label1.TabIndex = 11;
            label1.Text = "Matrix Software";
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Location = new System.Drawing.Point(12, 161);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.Size = new System.Drawing.Size(803, 238);
            this.dgvUrunler.TabIndex = 0;
            // 
            // lblUrunId
            // 
            this.lblUrunId.AutoSize = true;
            this.lblUrunId.Location = new System.Drawing.Point(48, 19);
            this.lblUrunId.Name = "lblUrunId";
            this.lblUrunId.Size = new System.Drawing.Size(50, 15);
            this.lblUrunId.TabIndex = 1;
            this.lblUrunId.Text = "Ürün ID:";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(41, 48);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(57, 15);
            this.lblUrunAdi.TabIndex = 2;
            this.lblUrunAdi.Text = "Ürün Adı:";
            // 
            // lblUrunFiyat
            // 
            this.lblUrunFiyat.AutoSize = true;
            this.lblUrunFiyat.Location = new System.Drawing.Point(34, 77);
            this.lblUrunFiyat.Name = "lblUrunFiyat";
            this.lblUrunFiyat.Size = new System.Drawing.Size(64, 15);
            this.lblUrunFiyat.TabIndex = 3;
            this.lblUrunFiyat.Text = "Ürün Fiyat:";
            // 
            // tbxUrunId
            // 
            this.tbxUrunId.Location = new System.Drawing.Point(104, 16);
            this.tbxUrunId.Name = "tbxUrunId";
            this.tbxUrunId.Size = new System.Drawing.Size(121, 23);
            this.tbxUrunId.TabIndex = 4;
            // 
            // tbxUrunAdi
            // 
            this.tbxUrunAdi.Location = new System.Drawing.Point(104, 45);
            this.tbxUrunAdi.Name = "tbxUrunAdi";
            this.tbxUrunAdi.Size = new System.Drawing.Size(121, 23);
            this.tbxUrunAdi.TabIndex = 5;
            // 
            // tbxUrunFiyat
            // 
            this.tbxUrunFiyat.Location = new System.Drawing.Point(104, 74);
            this.tbxUrunFiyat.Name = "tbxUrunFiyat";
            this.tbxUrunFiyat.Size = new System.Drawing.Size(121, 23);
            this.tbxUrunFiyat.TabIndex = 6;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(15, 106);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(83, 15);
            this.lblKategori.TabIndex = 7;
            this.lblKategori.Text = "Ürün Kategori:";
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(104, 103);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(121, 23);
            this.cmbKategoriler.TabIndex = 8;
            this.cmbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cmbKategoriler_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(104, 132);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(121, 23);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(689, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(298, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "##############################";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(230, 15);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(35, 24);
            this.btnAra.TabIndex = 13;
            this.btnAra.Text = "?";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // pnlUpdateDelete
            // 
            this.pnlUpdateDelete.Controls.Add(this.btnSil);
            this.pnlUpdateDelete.Controls.Add(this.btnGuncelle);
            this.pnlUpdateDelete.Enabled = false;
            this.pnlUpdateDelete.Location = new System.Drawing.Point(242, 103);
            this.pnlUpdateDelete.Name = "pnlUpdateDelete";
            this.pnlUpdateDelete.Size = new System.Drawing.Size(187, 52);
            this.pnlUpdateDelete.TabIndex = 14;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(96, 13);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(15, 13);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EF_III.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(827, 411);
            this.Controls.Add(this.pnlUpdateDelete);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbKategoriler);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.tbxUrunFiyat);
            this.Controls.Add(this.tbxUrunAdi);
            this.Controls.Add(this.tbxUrunId);
            this.Controls.Add(this.lblUrunFiyat);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.lblUrunId);
            this.Controls.Add(this.dgvUrunler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlUpdateDelete.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvUrunler;
        private Label lblUrunId;
        private Label lblUrunAdi;
        private Label lblUrunFiyat;
        private TextBox tbxUrunId;
        private TextBox tbxUrunAdi;
        private TextBox tbxUrunFiyat;
        private Label lblKategori;
        private ComboBox cmbKategoriler;
        private Button btnEkle;
        private PictureBox pictureBox1;
        private Label label2;
        private Button btnAra;
        private Panel pnlUpdateDelete;
        private Button btnSil;
        private Button btnGuncelle;
    }
}