using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppAdoNet
{
    public partial class UrunYonetimi : Form
    {
        public UrunYonetimi()
        {
            InitializeComponent();
        }
        UrunDAL urunDAL = new UrunDAL();
        private void UrunYonetimi_Load(object sender, EventArgs e)
        {
            dgvUrunler.DataSource = urunDAL.UrunleriGetir();
        }
    }
}
