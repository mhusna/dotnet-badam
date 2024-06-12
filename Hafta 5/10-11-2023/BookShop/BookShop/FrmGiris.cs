using BookShop.Data.Manager;
using BookShop.Models;

namespace BookShop
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            AdminManager manager = new AdminManager();
            Admin admin = manager.AdminBul(tbxEmail.Text, tbxSifre.Text);

            if(admin != null )
            {
                this.Hide();
                FrmMain frmMain = new FrmMain();
                frmMain.ShowDialog();
            }
            else
                MessageBox.Show("Mail veya şifre yanlış !", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}