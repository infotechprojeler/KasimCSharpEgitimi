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
            cmbKategoriler.DataSource = urunDAL.VerileriYukle("select * from Kategoriler");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var urun = new Urun
            {
                Brand = txtUrunMarkasi.Text,
                Description = txtUrunOzellikleri.Text,
                IsActive = cbDurum.Checked,
                Name = txtUrunAdi.Text,
                Price = decimal.Parse(txtUrunFiyati.Text),
                Stock = Convert.ToInt32(txtStok.Text),
                KategoriId = Convert.ToInt32(cmbKategoriler.SelectedValue)
            };
            var sonuc = urunDAL.Add(urun);
            if (sonuc > 0)
            {
                dgvUrunler.DataSource = urunDAL.UrunleriGetir();
                MessageBox.Show("Kayıt Başarılı!");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız!");
            }
        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStok.Text = dgvUrunler.CurrentRow.Cells[5].Value.ToString();
            txtUrunAdi.Text = dgvUrunler.CurrentRow.Cells[1].Value.ToString();
            txtUrunFiyati.Text = dgvUrunler.CurrentRow.Cells[3].Value.ToString();
            txtUrunMarkasi.Text = dgvUrunler.CurrentRow.Cells[4].Value.ToString();
            txtUrunOzellikleri.Text = dgvUrunler.CurrentRow.Cells[2].Value.ToString();
            cbDurum.Checked = (bool)dgvUrunler.CurrentRow.Cells[6].Value;
            cmbKategoriler.SelectedValue = dgvUrunler.CurrentRow.Cells[7].Value;
            btnEkle.Enabled = false;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var urun = new Urun
            {
                Id = (int)dgvUrunler.CurrentRow.Cells[0].Value,
                Brand = txtUrunMarkasi.Text,
                Description = txtUrunOzellikleri.Text,
                IsActive = cbDurum.Checked,
                Name = txtUrunAdi.Text,
                Price = decimal.Parse(txtUrunFiyati.Text),
                Stock = Convert.ToInt32(txtStok.Text),
                KategoriId = Convert.ToInt32(cmbKategoriler.SelectedValue)
            };
            var sonuc = urunDAL.Update(urun);
            if (sonuc > 0)
            {
                dgvUrunler.DataSource = urunDAL.UrunleriGetir();
                MessageBox.Show("Kayıt Başarılı!");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = (int)dgvUrunler.CurrentRow.Cells[0].Value;
            var sonuc = urunDAL.Delete(id);
            if (sonuc > 0)
            {
                dgvUrunler.DataSource = urunDAL.UrunleriGetir();
                MessageBox.Show("Kayıt Silme Başarılı!");
            }
            else
            {
                MessageBox.Show("Kayıt Silme Başarısız!");
            }
        }
    }
}
