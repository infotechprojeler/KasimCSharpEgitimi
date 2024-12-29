using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kategoriYonetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KategoriYonetimi kategoriYonetimi = new KategoriYonetimi();
            kategoriYonetimi.ShowDialog();
        }

        private void urunYonetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunYonetimi urunYonetimi = new UrunYonetimi();
            urunYonetimi.ShowDialog();
        }
        DatabaseContext databaseContext = new DatabaseContext();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            var kullanici = databaseContext.Users.Where(x => x.UserName == txtKullaniciAdi.Text && x.Password == txtSifre.Text).FirstOrDefault();

            if (kullanici != null)
            {
                groupBox1.Visible = false;
                menuStrip1.Visible = true;
            }
            else
                MessageBox.Show("Giriş Başarısız!");
        }

        private void kullanıcıYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciYonetimi kullaniciYonetimi = new KullaniciYonetimi();
            kullaniciYonetimi.ShowDialog();
        }
    }
}
