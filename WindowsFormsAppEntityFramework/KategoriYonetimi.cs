using ClassLibrary1;
using System;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace WindowsFormsAppEntityFramework
{
    public partial class KategoriYonetimi : Form
    {
        public KategoriYonetimi()
        {
            InitializeComponent();
        }

        DatabaseContext context = new DatabaseContext();

        private void KategoriYonetimi_Load(object sender, EventArgs e)
        {
            dgvKategoriler.DataSource = context.Categories.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            context.Categories.Add(new Category
            {
                CreateDate = DateTime.Now,
                Description = txtAciklama.Text,
                Name = txtKategoriAdi.Text,
            });
            var sonuc = context.SaveChanges();
            if (sonuc > 0)
            {
                dgvKategoriler.DataSource = context.Categories.ToList();
                MessageBox.Show("Kayıt Başarılı!");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız!");
            }
        }

        private void dgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtKategoriAdi.Text = dgvKategoriler.CurrentRow.Cells[1].Value.ToString();
            //txtAciklama.Text = dgvKategoriler.CurrentRow.Cells[2].Value.ToString();

            int id = Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value);
            var kayit = context.Categories.Find(id); // verilen id ile eşleşen kaydı veritabanından bulur.
            txtKategoriAdi.Text = kayit.Name;
            txtAciklama.Text = kayit.Description;

            btnEkle.Enabled = false;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value);
            var kayit = context.Categories.Find(id);

            kayit.Name = txtKategoriAdi.Text;
            kayit.Description = txtAciklama.Text;

            var sonuc = context.SaveChanges();
            if (sonuc > 0)
            {
                dgvKategoriler.DataSource = context.Categories.ToList();
                MessageBox.Show("Kayıt Başarılı!");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value);
            var kayit = context.Categories.Find(id);

            context.Categories.Remove(kayit); // üstte db den bulduğun kaydı sil

            var sonuc = context.SaveChanges(); // silme işlemini veritabanına işle
            if (sonuc > 0)
            {
                dgvKategoriler.DataSource = context.Categories.ToList();
                MessageBox.Show("Kayıt Silme Başarılı!");
            }
            else
            {
                MessageBox.Show("Kayıt Silme Başarısız!");
            }
        }
    }
}
