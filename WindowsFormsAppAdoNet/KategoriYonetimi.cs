using System;
using System.Data; // Ado net crud kütüphanesi
using System.Data.SqlClient; // Ado net crud kütüphanesi
using System.Windows.Forms;

namespace WindowsFormsAppAdoNet
{
    public partial class KategoriYonetimi : Form
    {
        public KategoriYonetimi()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("server=.; database=AdoNetDb; trusted_connection=true;"); // veritabanına bağlanmamızı sağlayan nesne

        void BaglantiyiAc()
        {
            if (conn.State == ConnectionState.Closed) // eğer sql bağlantımız kapalıysa
            {
                conn.Open(); // bağlantıyı aç
            }
        }

        void BaglantiyiKapat()
        {
            if (conn.State == ConnectionState.Open) // eğer sql bağlantımız açıksa
            {
                conn.Close(); // bağlantıyı kapat
            }
        }

        DataTable VerileriYukle()
        {
            BaglantiyiAc();
            DataTable dt = new DataTable(); // verileri çekip yükleyeceğimiz nesne
            SqlCommand cmd = new SqlCommand("select * from Kategoriler", conn); // sql sorgumuzu göndereceğimiz nesne
            SqlDataReader dr = cmd.ExecuteReader(); // cmd nesnesindeki sql sorgusunu conn nesnesindeki db de çalıştır
            dt.Load(dr); // sql den okuduğun verileri dt nesnesine yükle
            dr.Close(); // veri okuyucuyu kapat
            cmd.Dispose(); // cmd nesnesini yoket
            BaglantiyiKapat();
            return dt;
        }

        private void KategoriYonetimi_Load(object sender, EventArgs e)
        {
           dgvKategoriler.DataSource = VerileriYukle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtKategoriAdi.Text))
            {
                // eğer kategori adı girilmişse ekleme yap
                var kategori = new Kategori
                {
                    CreateDate = DateTime.Now,
                    Name = txtKategoriAdi.Text
                };
                BaglantiyiAc();
                SqlCommand sqlCommand = new SqlCommand("insert into Kategoriler (Name, CreateDate) values (@Name, @CreateDate)", conn);
                sqlCommand.Parameters.AddWithValue("@Name", kategori.Name);
                sqlCommand.Parameters.AddWithValue("@CreateDate", kategori.CreateDate);
                var sonuc = sqlCommand.ExecuteNonQuery(); // ExecuteNonQuery metodu sql deki execute işlemini yapar ve bize sql den gelen etkilenen kayıt sayısını getirir.
                if (sonuc > 0) // eğer sonuc 0 dan büyükse ekleme işlemi başarılıdır
                {
                    sqlCommand.Dispose();
                    dgvKategoriler.DataSource = VerileriYukle();
                    MessageBox.Show("Kayıt Başarılı!");
                }
                BaglantiyiKapat();
            }
            else
            {
                MessageBox.Show("Kategori Adı Boş Geçilemez!");
            }
        }

        private void dgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKategoriAdi.Text = dgvKategoriler.CurrentRow.Cells[1].Value.ToString();
            btnEkle.Enabled = false;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtKategoriAdi.Text))
            {
                // eğer kategori adı girilmişse ekleme yap
                var kategori = new Kategori
                {
                    Name = txtKategoriAdi.Text,
                    Id = Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value)
                };
                BaglantiyiAc();
                SqlCommand sqlCommand = new SqlCommand("update Kategoriler set Name=  @Name where Id=@id", conn);
                sqlCommand.Parameters.AddWithValue("@Name", kategori.Name);
                sqlCommand.Parameters.AddWithValue("@id", kategori.Id);
                var sonuc = sqlCommand.ExecuteNonQuery(); // ExecuteNonQuery metodu sql deki execute işlemini yapar ve bize sql den gelen etkilenen kayıt sayısını getirir.
                if (sonuc > 0) // eğer sonuc 0 dan büyükse ekleme işlemi başarılıdır
                {
                    sqlCommand.Dispose();
                    dgvKategoriler.DataSource = VerileriYukle();
                    MessageBox.Show("Kayıt Başarılı!");
                }
                BaglantiyiKapat();
            }
            else
            {
                MessageBox.Show("Kategori Adı Boş Geçilemez!");
            }
        }

        private void KategoriYonetimi_MouseClick(object sender, MouseEventArgs e)
        {
            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            BaglantiyiAc();
            SqlCommand sqlCommand = new SqlCommand("delete from Kategoriler where Id=@id", conn);
            sqlCommand.Parameters.AddWithValue("@id", Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value));
            var sonuc = sqlCommand.ExecuteNonQuery();
            if (sonuc > 0)
            {
                sqlCommand.Dispose();
                dgvKategoriler.DataSource = VerileriYukle();
                MessageBox.Show("Kayıt Silme Başarılı!");
            }
            BaglantiyiKapat();
        }
    }
}
