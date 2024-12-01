using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEgitim
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string veritabanindakiKullaniciAdi = "Admin", sifre = "Adm123";

            if (txtKullaniciAdi.Text == veritabanindakiKullaniciAdi && txtSifre.Text == sifre)
            {
                groupBox1.Visible = false;
                gbUrunKayitFormu.Visible = true;
                MessageBox.Show("Hoşgeldin " + txtKullaniciAdi.Text);
            }
            else
            {
                MessageBox.Show("Giriş Başarısız!");
            }
        }
    }
}
