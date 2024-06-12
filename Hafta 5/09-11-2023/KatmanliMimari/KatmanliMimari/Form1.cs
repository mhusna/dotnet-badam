namespace KatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void markalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMarkalar frmMarkalar = new FrmMarkalar();
            frmMarkalar.ShowDialog();
        }

        private void arabalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmArabalar frmArabalar = new FrmArabalar();
            frmArabalar.ShowDialog();

            // Marka selectedvalue değişince modeller ona göre gelsin.
        }
    }
}