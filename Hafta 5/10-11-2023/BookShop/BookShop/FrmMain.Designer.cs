namespace BookShop
{
    partial class FrmMain
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
            tabMenu = new TabControl();
            tabAdmin = new TabPage();
            pnlAdminGuncelleSil = new Panel();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnAra = new Button();
            dgvAdminler = new DataGridView();
            btnEkle = new Button();
            tbxAdminSifre = new TextBox();
            tbxAdminMail = new TextBox();
            tbxAdminSoyad = new TextBox();
            tbxAdminAdi = new TextBox();
            tbxAdminID = new TextBox();
            lblSifre = new Label();
            lblMailAdresi = new Label();
            lblAdminSoyad = new Label();
            lblAdminAd = new Label();
            lblAdminID = new Label();
            tabKitap = new TabPage();
            radDurdurulmus = new RadioButton();
            radSatista = new RadioButton();
            cmbYayinEvi = new ComboBox();
            lblYayinEvi = new Label();
            dgvKitaplar = new DataGridView();
            pnlKitapGuncelleSil = new Panel();
            btnKitapSil = new Button();
            btnKitapGuncelle = new Button();
            btnKitapAra = new Button();
            btnKitapEkle = new Button();
            tbxFiyat = new TextBox();
            tbxKitapAdi = new TextBox();
            tbxKitapID = new TextBox();
            lblSatisDurum = new Label();
            lblFiyat = new Label();
            lblKitapAdi = new Label();
            lblKitapID = new Label();
            tabYayinEvi = new TabPage();
            tabRaporlar = new TabPage();
            tabMenu.SuspendLayout();
            tabAdmin.SuspendLayout();
            pnlAdminGuncelleSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdminler).BeginInit();
            tabKitap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).BeginInit();
            pnlKitapGuncelleSil.SuspendLayout();
            SuspendLayout();
            // 
            // tabMenu
            // 
            tabMenu.Controls.Add(tabAdmin);
            tabMenu.Controls.Add(tabKitap);
            tabMenu.Controls.Add(tabYayinEvi);
            tabMenu.Controls.Add(tabRaporlar);
            tabMenu.Location = new Point(1, 1);
            tabMenu.Name = "tabMenu";
            tabMenu.SelectedIndex = 0;
            tabMenu.Size = new Size(793, 386);
            tabMenu.TabIndex = 1;
            // 
            // tabAdmin
            // 
            tabAdmin.Controls.Add(pnlAdminGuncelleSil);
            tabAdmin.Controls.Add(btnAra);
            tabAdmin.Controls.Add(dgvAdminler);
            tabAdmin.Controls.Add(btnEkle);
            tabAdmin.Controls.Add(tbxAdminSifre);
            tabAdmin.Controls.Add(tbxAdminMail);
            tabAdmin.Controls.Add(tbxAdminSoyad);
            tabAdmin.Controls.Add(tbxAdminAdi);
            tabAdmin.Controls.Add(tbxAdminID);
            tabAdmin.Controls.Add(lblSifre);
            tabAdmin.Controls.Add(lblMailAdresi);
            tabAdmin.Controls.Add(lblAdminSoyad);
            tabAdmin.Controls.Add(lblAdminAd);
            tabAdmin.Controls.Add(lblAdminID);
            tabAdmin.Location = new Point(4, 24);
            tabAdmin.Name = "tabAdmin";
            tabAdmin.Padding = new Padding(3);
            tabAdmin.Size = new Size(785, 358);
            tabAdmin.TabIndex = 0;
            tabAdmin.Text = "Admin İşlemleri";
            tabAdmin.UseVisualStyleBackColor = true;
            // 
            // pnlAdminGuncelleSil
            // 
            pnlAdminGuncelleSil.Controls.Add(btnSil);
            pnlAdminGuncelleSil.Controls.Add(btnGuncelle);
            pnlAdminGuncelleSil.Location = new Point(281, 117);
            pnlAdminGuncelleSil.Name = "pnlAdminGuncelleSil";
            pnlAdminGuncelleSil.Size = new Size(200, 32);
            pnlAdminGuncelleSil.TabIndex = 15;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(109, 8);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 14;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(16, 8);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 23);
            btnGuncelle.TabIndex = 13;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(224, 10);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(51, 23);
            btnAra.TabIndex = 12;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // dgvAdminler
            // 
            dgvAdminler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAdminler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdminler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdminler.Location = new Point(6, 155);
            dgvAdminler.Name = "dgvAdminler";
            dgvAdminler.RowTemplate.Height = 25;
            dgvAdminler.Size = new Size(773, 200);
            dgvAdminler.TabIndex = 11;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(224, 125);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(51, 23);
            btnEkle.TabIndex = 10;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // tbxAdminSifre
            // 
            tbxAdminSifre.Location = new Point(93, 126);
            tbxAdminSifre.Name = "tbxAdminSifre";
            tbxAdminSifre.Size = new Size(125, 23);
            tbxAdminSifre.TabIndex = 9;
            // 
            // tbxAdminMail
            // 
            tbxAdminMail.Location = new Point(93, 97);
            tbxAdminMail.Name = "tbxAdminMail";
            tbxAdminMail.Size = new Size(125, 23);
            tbxAdminMail.TabIndex = 8;
            // 
            // tbxAdminSoyad
            // 
            tbxAdminSoyad.Location = new Point(93, 68);
            tbxAdminSoyad.Name = "tbxAdminSoyad";
            tbxAdminSoyad.Size = new Size(125, 23);
            tbxAdminSoyad.TabIndex = 7;
            // 
            // tbxAdminAdi
            // 
            tbxAdminAdi.Location = new Point(93, 39);
            tbxAdminAdi.Name = "tbxAdminAdi";
            tbxAdminAdi.Size = new Size(125, 23);
            tbxAdminAdi.TabIndex = 6;
            // 
            // tbxAdminID
            // 
            tbxAdminID.Location = new Point(93, 10);
            tbxAdminID.Name = "tbxAdminID";
            tbxAdminID.Size = new Size(125, 23);
            tbxAdminID.TabIndex = 5;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(54, 129);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(33, 15);
            lblSifre.TabIndex = 4;
            lblSifre.Text = "Şifre:";
            // 
            // lblMailAdresi
            // 
            lblMailAdresi.AutoSize = true;
            lblMailAdresi.Location = new Point(18, 100);
            lblMailAdresi.Name = "lblMailAdresi";
            lblMailAdresi.Size = new Size(69, 15);
            lblMailAdresi.TabIndex = 3;
            lblMailAdresi.Text = "Mail Adresi:";
            // 
            // lblAdminSoyad
            // 
            lblAdminSoyad.AutoSize = true;
            lblAdminSoyad.Location = new Point(45, 71);
            lblAdminSoyad.Name = "lblAdminSoyad";
            lblAdminSoyad.Size = new Size(42, 15);
            lblAdminSoyad.TabIndex = 2;
            lblAdminSoyad.Text = "Soyad:";
            // 
            // lblAdminAd
            // 
            lblAdminAd.AutoSize = true;
            lblAdminAd.Location = new Point(62, 42);
            lblAdminAd.Name = "lblAdminAd";
            lblAdminAd.Size = new Size(25, 15);
            lblAdminAd.TabIndex = 1;
            lblAdminAd.Text = "Ad:";
            // 
            // lblAdminID
            // 
            lblAdminID.AutoSize = true;
            lblAdminID.Location = new Point(27, 13);
            lblAdminID.Name = "lblAdminID";
            lblAdminID.Size = new Size(60, 15);
            lblAdminID.TabIndex = 0;
            lblAdminID.Text = "Admin ID:";
            // 
            // tabKitap
            // 
            tabKitap.Controls.Add(radDurdurulmus);
            tabKitap.Controls.Add(radSatista);
            tabKitap.Controls.Add(cmbYayinEvi);
            tabKitap.Controls.Add(lblYayinEvi);
            tabKitap.Controls.Add(dgvKitaplar);
            tabKitap.Controls.Add(pnlKitapGuncelleSil);
            tabKitap.Controls.Add(btnKitapAra);
            tabKitap.Controls.Add(btnKitapEkle);
            tabKitap.Controls.Add(tbxFiyat);
            tabKitap.Controls.Add(tbxKitapAdi);
            tabKitap.Controls.Add(tbxKitapID);
            tabKitap.Controls.Add(lblSatisDurum);
            tabKitap.Controls.Add(lblFiyat);
            tabKitap.Controls.Add(lblKitapAdi);
            tabKitap.Controls.Add(lblKitapID);
            tabKitap.Location = new Point(4, 24);
            tabKitap.Name = "tabKitap";
            tabKitap.Padding = new Padding(3);
            tabKitap.Size = new Size(785, 358);
            tabKitap.TabIndex = 1;
            tabKitap.Text = "Kitap İşlemleri";
            tabKitap.UseVisualStyleBackColor = true;
            // 
            // radDurdurulmus
            // 
            radDurdurulmus.AutoSize = true;
            radDurdurulmus.Location = new Point(151, 72);
            radDurdurulmus.Name = "radDurdurulmus";
            radDurdurulmus.Size = new Size(125, 19);
            radDurdurulmus.TabIndex = 22;
            radDurdurulmus.TabStop = true;
            radDurdurulmus.Text = "Satışı Durdurulmuş";
            radDurdurulmus.UseVisualStyleBackColor = true;
            // 
            // radSatista
            // 
            radSatista.AutoSize = true;
            radSatista.Location = new Point(86, 72);
            radSatista.Name = "radSatista";
            radSatista.Size = new Size(59, 19);
            radSatista.TabIndex = 21;
            radSatista.TabStop = true;
            radSatista.Text = "Satışta";
            radSatista.UseVisualStyleBackColor = true;
            // 
            // cmbYayinEvi
            // 
            cmbYayinEvi.FormattingEnabled = true;
            cmbYayinEvi.Location = new Point(86, 126);
            cmbYayinEvi.Name = "cmbYayinEvi";
            cmbYayinEvi.Size = new Size(117, 23);
            cmbYayinEvi.TabIndex = 20;
            // 
            // lblYayinEvi
            // 
            lblYayinEvi.AutoSize = true;
            lblYayinEvi.Location = new Point(24, 129);
            lblYayinEvi.Name = "lblYayinEvi";
            lblYayinEvi.Size = new Size(56, 15);
            lblYayinEvi.TabIndex = 19;
            lblYayinEvi.Text = "Yayın Evi:";
            // 
            // dgvKitaplar
            // 
            dgvKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKitaplar.Location = new Point(7, 155);
            dgvKitaplar.Name = "dgvKitaplar";
            dgvKitaplar.RowTemplate.Height = 25;
            dgvKitaplar.Size = new Size(772, 196);
            dgvKitaplar.TabIndex = 17;
            // 
            // pnlKitapGuncelleSil
            // 
            pnlKitapGuncelleSil.Controls.Add(btnKitapSil);
            pnlKitapGuncelleSil.Controls.Add(btnKitapGuncelle);
            pnlKitapGuncelleSil.Location = new Point(266, 123);
            pnlKitapGuncelleSil.Name = "pnlKitapGuncelleSil";
            pnlKitapGuncelleSil.Size = new Size(165, 25);
            pnlKitapGuncelleSil.TabIndex = 16;
            // 
            // btnKitapSil
            // 
            btnKitapSil.Location = new Point(84, 1);
            btnKitapSil.Name = "btnKitapSil";
            btnKitapSil.Size = new Size(75, 23);
            btnKitapSil.TabIndex = 14;
            btnKitapSil.Text = "Sil";
            btnKitapSil.UseVisualStyleBackColor = true;
            // 
            // btnKitapGuncelle
            // 
            btnKitapGuncelle.Location = new Point(3, 0);
            btnKitapGuncelle.Name = "btnKitapGuncelle";
            btnKitapGuncelle.Size = new Size(75, 23);
            btnKitapGuncelle.TabIndex = 13;
            btnKitapGuncelle.Text = "Guncelle";
            btnKitapGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnKitapAra
            // 
            btnKitapAra.Location = new Point(209, 10);
            btnKitapAra.Name = "btnKitapAra";
            btnKitapAra.Size = new Size(51, 23);
            btnKitapAra.TabIndex = 14;
            btnKitapAra.Text = "Ara";
            btnKitapAra.UseVisualStyleBackColor = true;
            btnKitapAra.Click += btnKitapAra_Click;
            // 
            // btnKitapEkle
            // 
            btnKitapEkle.Location = new Point(209, 125);
            btnKitapEkle.Name = "btnKitapEkle";
            btnKitapEkle.Size = new Size(51, 23);
            btnKitapEkle.TabIndex = 13;
            btnKitapEkle.Text = "Ekle";
            btnKitapEkle.UseVisualStyleBackColor = true;
            btnKitapEkle.Click += btnKitapEkle_Click;
            // 
            // tbxFiyat
            // 
            tbxFiyat.Location = new Point(86, 97);
            tbxFiyat.Name = "tbxFiyat";
            tbxFiyat.Size = new Size(117, 23);
            tbxFiyat.TabIndex = 7;
            // 
            // tbxKitapAdi
            // 
            tbxKitapAdi.Location = new Point(86, 39);
            tbxKitapAdi.Name = "tbxKitapAdi";
            tbxKitapAdi.Size = new Size(117, 23);
            tbxKitapAdi.TabIndex = 5;
            // 
            // tbxKitapID
            // 
            tbxKitapID.Location = new Point(86, 10);
            tbxKitapID.Name = "tbxKitapID";
            tbxKitapID.Size = new Size(117, 23);
            tbxKitapID.TabIndex = 4;
            // 
            // lblSatisDurum
            // 
            lblSatisDurum.AutoSize = true;
            lblSatisDurum.Location = new Point(6, 71);
            lblSatisDurum.Name = "lblSatisDurum";
            lblSatisDurum.Size = new Size(74, 15);
            lblSatisDurum.TabIndex = 3;
            lblSatisDurum.Text = "Satış Durum:";
            // 
            // lblFiyat
            // 
            lblFiyat.AutoSize = true;
            lblFiyat.Location = new Point(45, 100);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new Size(35, 15);
            lblFiyat.TabIndex = 2;
            lblFiyat.Text = "Fiyat:";
            // 
            // lblKitapAdi
            // 
            lblKitapAdi.AutoSize = true;
            lblKitapAdi.Location = new Point(22, 42);
            lblKitapAdi.Name = "lblKitapAdi";
            lblKitapAdi.Size = new Size(58, 15);
            lblKitapAdi.TabIndex = 1;
            lblKitapAdi.Text = "Kitap Adı:";
            // 
            // lblKitapID
            // 
            lblKitapID.AutoSize = true;
            lblKitapID.Location = new Point(29, 13);
            lblKitapID.Name = "lblKitapID";
            lblKitapID.Size = new Size(51, 15);
            lblKitapID.TabIndex = 0;
            lblKitapID.Text = "Kitap ID:";
            // 
            // tabYayinEvi
            // 
            tabYayinEvi.Location = new Point(4, 24);
            tabYayinEvi.Name = "tabYayinEvi";
            tabYayinEvi.Padding = new Padding(3);
            tabYayinEvi.Size = new Size(785, 358);
            tabYayinEvi.TabIndex = 2;
            tabYayinEvi.Text = "Yayın Evi İşlemleri";
            tabYayinEvi.UseVisualStyleBackColor = true;
            // 
            // tabRaporlar
            // 
            tabRaporlar.Location = new Point(4, 24);
            tabRaporlar.Name = "tabRaporlar";
            tabRaporlar.Padding = new Padding(3);
            tabRaporlar.Size = new Size(785, 358);
            tabRaporlar.TabIndex = 3;
            tabRaporlar.Text = "Raporlar";
            tabRaporlar.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 388);
            Controls.Add(tabMenu);
            Name = "FrmMain";
            Text = "FrmMain";
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            tabMenu.ResumeLayout(false);
            tabAdmin.ResumeLayout(false);
            tabAdmin.PerformLayout();
            pnlAdminGuncelleSil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAdminler).EndInit();
            tabKitap.ResumeLayout(false);
            tabKitap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).EndInit();
            pnlKitapGuncelleSil.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabMenu;
        private TabPage tabAdmin;
        private TabPage tabKitap;
        private TabPage tabYayinEvi;
        private TabPage tabRaporlar;
        private Label lblAdminID;
        private Label lblAdminSoyad;
        private Label lblAdminAd;
        private TextBox tbxAdminSifre;
        private TextBox tbxAdminMail;
        private TextBox tbxAdminSoyad;
        private TextBox tbxAdminAdi;
        private TextBox tbxAdminID;
        private Label lblSifre;
        private Label lblMailAdresi;
        private Button btnEkle;
        private DataGridView dgvAdminler;
        private Button btnAra;
        private Panel pnlAdminGuncelleSil;
        private Button btnSil;
        private Button btnGuncelle;
        private Label lblSatisDurum;
        private Label lblFiyat;
        private Label lblKitapAdi;
        private Label lblKitapID;
        private TextBox tbxFiyat;
        private TextBox tbxKitapAdi;
        private TextBox tbxKitapID;
        private Button btnKitapAra;
        private Button btnKitapEkle;
        private Panel pnlKitapGuncelleSil;
        private Button btnKitapSil;
        private Button btnKitapGuncelle;
        private DataGridView dgvKitaplar;
        private ComboBox cmbYayinEvi;
        private Label lblYayinEvi;
        private RadioButton radDurdurulmus;
        private RadioButton radSatista;
    }
}