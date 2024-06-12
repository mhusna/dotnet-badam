using EF_III.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EF_III
{
    public partial class Form1 : Form
    {
        ModelContext context = new ModelContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GridDoldur();
            CmbDoldur();
            ShowHide(true);
        }

        private void GridDoldur()
        {
            dgvUrunler.DataSource = context.Urunlers
                                           .Include(x => x.Kategori)
                                           .Select(x => new { x.UrunId, x.UrunAdi, x.Fiyat, Kategori = x.Kategori.KategoriAdi })
                                           .ToList();
        }

        private void CmbDoldur()
        {
            cmbKategoriler.DataSource = context.Kategorilers.ToList();
            cmbKategoriler.ValueMember = "KategoriID";
            cmbKategoriler.DisplayMember = "KategoriAdi";
        }

        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbKategoriler.SelectedValue.ToString());
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urunler urun = UrunAl();

            context.Urunlers.Add(urun);
            context.SaveChanges();

            GridDoldur();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (tbxUrunId.Text == "")
                MessageBox.Show("Boş geçemezsiniz..");

            Urunler urun = Ara(int.Parse(tbxUrunId.Text));
            if (urun == null)
                MessageBox.Show("Aradığınız kayıt bulunamadı.");
            else
            {
                ShowHide(false);
                VerileriKontrollereDoldur(urun);
            }
        }

        private Urunler Ara(int urunID)
        {
            Urunler urun = context.Urunlers.Find(urunID);
            context.Entry(urun).State = EntityState.Detached;
            return urun;
            //return context.Urunlers.FirstOrDefault(x => x.UrunId == int.Parse(tbxUrunId.Text));
        }

        private void VerileriKontrollereDoldur(Urunler urun)
        {
            tbxUrunAdi.Text = urun.UrunAdi;
            tbxUrunFiyat.Text = urun.Fiyat.ToString();
            cmbKategoriler.SelectedValue = urun.KategoriId;
        }

        private void ShowHide(bool value)
        {
            btnEkle.Enabled = value;
            pnlUpdateDelete.Enabled = !value;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Urunler urun = UrunAl();
            context.Entry(urun).State = EntityState.Modified;
            context.SaveChanges();
            GridDoldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Kaydı silmek istiyor musunuz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialogResult == DialogResult.Yes)
            {
                context.Urunlers.Remove(UrunAl());
                context.SaveChanges();
                GridDoldur();
            }
        }

        private Urunler UrunAl()
        {
            Urunler urun = new Urunler();
            urun.UrunId = int.Parse(tbxUrunId.Text);
            urun.UrunAdi = tbxUrunAdi.Text;
            urun.Fiyat = double.Parse(tbxUrunFiyat.Text);
            urun.KategoriId = int.Parse(cmbKategoriler.SelectedValue.ToString());

            return urun;
        }
    }
}