using BLL;
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
    public partial class FrmMarkalar : Form
    {
        public FrmMarkalar()
        {
            InitializeComponent();
        }

        GaleriBLL galeriBLL = new GaleriBLL();
        private void FrmMarkalar_Load(object sender, EventArgs e)
        {
            dgvMarkalar.DataSource = galeriBLL.MarkaManager.Tumu().Select(x => new { x.MarkaID, x.MarkaAdi }).ToList();
        }
    }
}
