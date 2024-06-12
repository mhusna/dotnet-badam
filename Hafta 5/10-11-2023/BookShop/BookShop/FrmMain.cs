using BookShop.Data.Manager;
using BookShop.Models;
using BookShop.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        AdminManager adminManager = new AdminManager();
        KitapManager kitapManager = new KitapManager();
        YayinEviManager yayineviManager = new YayinEviManager();

        private void adminİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            pnlAdminGuncelleSil.Enabled = false;
            pnlKitapGuncelleSil.Enabled = false;

            dgvAdminler.DataSource = adminManager.Listele();
            dgvKitaplar.DataSource = kitapManager.Listele();

            cmbYayinEvi.DataSource = yayineviManager.Listele();
            cmbYayinEvi.ValueMember = "YayinEviID";
            cmbYayinEvi.DisplayMember = "Ad";

            KitaplarGridDoldur();

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Admin? admin = adminManager.Bul(int.Parse(tbxAdminID.Text));

            if (admin != null)
            {
                tbxAdminAdi.Text = admin.Ad;
                tbxAdminSoyad.Text = admin.Soyad;
                tbxAdminMail.Text = admin.MailAdresi;
                tbxAdminSifre.Text = admin.Sifre;

                pnlAdminGuncelleSil.Enabled = true;
            }
            else
                MessageBox.Show("Kullanıcı Bulunamadı !", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            do
            {
                BilgiAl(admin);
                SifreKontrol(admin);
            }
            while (!SifreKontrol(admin));

            adminManager.Ekle(admin);
            MessageBox.Show("Admin Eklendi !");
            dgvAdminler.DataSource = adminManager.Listele();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Parent.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Admin admin = adminManager.Bul(int.Parse(tbxAdminID.Text));
            do
            {
                BilgiAl(admin);
                SifreKontrol(admin);
            }
            while (!SifreKontrol(admin));

            adminManager.Guncelle(admin);
            MessageBox.Show("Admin Guncellendi !");
            dgvAdminler.DataSource = adminManager.Listele();
        }

        public bool SifreKontrol(Admin admin)
        {
            if (admin.Sifre.Length < 8)
            {
                MessageBox.Show("8 karakterden uzun bir şifre girin !");
                return false;
            }
            else if (!admin.Sifre.Any(char.IsUpper))
            {
                MessageBox.Show("En az 1 tane büyük karakter içermeli !");
                return false;
            }
            else
            {
                admin.Sifre = admin.Sifre;
                return true;
            }
        }

        public void BilgiAl(Admin admin)
        {
            admin.Ad = tbxAdminAdi.Text;
            admin.Soyad = tbxAdminSoyad.Text;
            admin.MailAdresi = tbxAdminMail.Text;
            admin.Sifre = tbxAdminSifre.Text;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnKitapAra_Click(object sender, EventArgs e)
        {
            Kitap kitap = kitapManager.Bul(int.Parse(tbxKitapID.Text));

            tbxKitapAdi.Text = kitap.KitapAdi;

            if (kitap.SatisDurum == KitapDurum.Satista)
                radSatista.Checked = true;
            else
                radDurdurulmus.Checked = true;

            tbxFiyat.Text = kitap.Fiyat.ToString();
            cmbYayinEvi.SelectedValue = kitap.YayinEviID;
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap
            {
                KitapAdi = tbxKitapAdi.Text,
                Fiyat = double.Parse(tbxFiyat.Text),
                YayinEviID = ((YayinEvi)cmbYayinEvi.SelectedItem).YayinEviID
            };

            if (radSatista.Checked)
                kitap.SatisDurum = KitapDurum.Satista;
            else
                kitap.SatisDurum = KitapDurum.SatisDurdurulmus;

            kitapManager.Ekle(kitap);
            KitaplarGridDoldur();
        }

        public void KitaplarGridDoldur()
        {
            dgvKitaplar.DataSource = kitapManager.YayinEvleriyleGetir().Select(x => new { x.KitapID, x.KitapAdi, x.Fiyat, x.YayinEvi.Ad }).ToList();
        }
    }
}
