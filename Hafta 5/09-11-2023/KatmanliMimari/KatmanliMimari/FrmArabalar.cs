using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatmanliMimari
{
    public partial class FrmArabalar : Form
    {
        public FrmArabalar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelDoldur();
        }

        GaleriBLL galeribbl = new GaleriBLL();
        private void FrmArabalar_Load(object sender, EventArgs e)
        {
            MarkaDoldur();
        }

        void MarkaDoldur()
        {
            comboBox1.DataSource = galeribbl.MarkaManager.Tumu();
            comboBox1.DisplayMember = "MarkaAdi";
            comboBox1.ValueMember = "MarkaID";

        }

        void ModelDoldur()
        {
            int? id = ((Marka)comboBox1.SelectedItem).MarkaID;
            if (id != null)
                comboBox2.DataSource = galeribbl.ModelManager.Tumu(x => x.MarkaID == id).ToList();
            else
                comboBox2.DataSource = galeribbl.ModelManager.Tumu().ToList();
            comboBox2.ValueMember = "ModelID";
            comboBox2.DisplayMember = "ModelAdi";
        }
    }
}
