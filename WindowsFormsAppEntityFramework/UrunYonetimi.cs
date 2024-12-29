using ClassLibrary1;
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
    public partial class UrunYonetimi : Form
    {
        public UrunYonetimi()
        {
            InitializeComponent();
        }

        DatabaseContext database = new DatabaseContext();

        private void UrunYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        void Yukle()
        {
            //dgvUrunler.DataSource = database.Products.ToList();
            dgvUrunler.DataSource = database.Products.Select(p => new
            {
                p.Id,
                p.Name,
                p.Price,
                p.Description,
                p.CreateDate,
                p.Brand,
                p.Stock,
                Kategori = p.Category.Name
            }).ToList();
            cmbKategoriler.DataSource = database.Categories.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            database.Products.Add(new ClassLibrary1.Product
            {
                Brand = txtUrunMarkasi.Text,
                CategoryId = (int)cmbKategoriler.SelectedValue,
                CreateDate = DateTime.Now,
                Name = txtUrunAdi.Text,
                Description = txtUrunOzellikleri.Text,
                IsActive = cbDurum.Checked,
                Price = Convert.ToDecimal(txtUrunFiyati.Text),
                Stock = Convert.ToInt32(txtStok.Text)
            });
            try
            {
                var sonuc = database.SaveChanges();
                if (sonuc > 0)
                {
                    //dgvUrunler.DataSource = database.Products.ToList();
                    Yukle();
                    MessageBox.Show("Kayıt Başarılı!");
                }
                else
                    MessageBox.Show("Kayıt Başarısız!");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }

        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvUrunler.CurrentRow.Cells[0].Value);
                var kayit = database.Products.Find(id);

                txtStok.Text = kayit.Stock.ToString();
                txtUrunAdi.Text = kayit.Name;
                txtUrunFiyati.Text = kayit.Price.ToString();
                txtUrunMarkasi.Text = kayit.Brand;
                txtUrunOzellikleri.Text = kayit.Description;
                cbDurum.Checked = kayit.IsActive;
                cmbKategoriler.SelectedValue = kayit.CategoryId;

                btnEkle.Enabled = false;
                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvUrunler.CurrentRow.Cells[0].Value);
            var kayit = database.Products.Find(id);

            kayit.Name = txtUrunAdi.Text;
            kayit.Brand = txtUrunMarkasi.Text;
            kayit.Description = txtUrunOzellikleri.Text;
            kayit.CategoryId = (int)cmbKategoriler.SelectedValue;
            kayit.IsActive = cbDurum.Checked;
            kayit.Stock = Convert.ToInt32(txtStok.Text);
            kayit.Price = Convert.ToDecimal(txtUrunFiyati.Text);

            try
            {
                var sonuc = database.SaveChanges();
                if (sonuc > 0)
                {
                    //dgvUrunler.DataSource = database.Products.ToList();
                    Yukle();
                    MessageBox.Show("Kayıt Başarılı!");
                }
                else
                    MessageBox.Show("Kayıt Başarısız!");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvUrunler.CurrentRow.Cells[0].Value);
            var kayit = database.Products.Find(id);

            database.Products.Remove(kayit);

            try
            {
                var sonuc = database.SaveChanges();
                if (sonuc > 0)
                {
                    //dgvUrunler.DataSource = database.Products.ToList();
                    Yukle();
                    MessageBox.Show("Kayıt Silme Başarılı!");
                }
                else
                    MessageBox.Show("Kayıt Silme Başarısız!");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dgvUrunler.DataSource = database.Products.Where(p => p.Name.Contains(txtAra.Text) || p.Description.Contains(txtAra.Text)).ToList();
        }
    }
}
