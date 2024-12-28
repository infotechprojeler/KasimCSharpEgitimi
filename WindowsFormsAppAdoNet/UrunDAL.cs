using System;
using System.Collections.Generic;
using System.Data; // Ado net crud kütüphanesi
using System.Data.SqlClient; // Ado net crud kütüphanesi

namespace WindowsFormsAppAdoNet
{
    internal class UrunDAL
    {
        SqlConnection conn = new SqlConnection("server=.; database=AdoNetDb; trusted_connection=true;"); // veritabanına bağlanmamızı sağlayan nesne

        void BaglantiyiAc()
        {
            if (conn.State == ConnectionState.Closed) // eğer sql bağlantımız kapalıysa
            {
                conn.Open(); // bağlantıyı aç
            }
        }
        public List<Urun> UrunleriGetir()
        {
            List<Urun> urunler = new List<Urun>(); // boş liste oluştur
            BaglantiyiAc(); // db bağlantısını aç
            SqlCommand sqlCommand = new SqlCommand("select * from Urunler", conn);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Urun urun = new Urun()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = Convert.ToString(reader["Name"]),
                    Brand = Convert.ToString(reader["Brand"]),
                    Description = Convert.ToString(reader["Description"]),
                    Price = Convert.ToDecimal(reader["Price"]),
                    Stock = Convert.ToInt32(reader["Stock"]),
                    IsActive = reader.GetBoolean(5),
                    KategoriId = Convert.ToInt32(reader["KategoriId"])
                };
                urunler.Add(urun);
            }
            reader.Close();
            sqlCommand.Dispose();
            conn.Close();
            return urunler;
        }
        public int Add(Urun urun) // bu metot dışarıdan bir urun nesnesi alacak
        {
            BaglantiyiAc();
            int islemSonucu = 0; // işlem sonunda db ye eklenirse geriye bu degisken üzerinden sonucu döndüreceğiz
            SqlCommand sqlCommand = new SqlCommand("insert into Urunler (Name, Description, Price, Stock, IsActive, Brand, KategoriId) values (@Name, @Description, @Price, @Stock, @IsActive, @Brand, @KategoriId)", conn); // kayıt ekleme komutlarımız
            sqlCommand.Parameters.AddWithValue("@Name", urun.Name);
            sqlCommand.Parameters.AddWithValue("@Description", urun.Description);
            sqlCommand.Parameters.AddWithValue("@Price", urun.Price);
            sqlCommand.Parameters.AddWithValue("@Stock", urun.Stock);
            sqlCommand.Parameters.AddWithValue("@IsActive", urun.IsActive);
            sqlCommand.Parameters.AddWithValue("@Brand", urun.Brand);
            sqlCommand.Parameters.AddWithValue("@KategoriId", urun.KategoriId);
            islemSonucu = sqlCommand.ExecuteNonQuery();
            sqlCommand.Dispose();
            conn.Close();
            return islemSonucu;
        }
        public int Update(Urun urun) // bu metot dışarıdan bir urun nesnesi alacak
        {
            BaglantiyiAc();
            int islemSonucu = 0; // işlem sonunda db ye eklenirse geriye bu degisken üzerinden sonucu döndüreceğiz
            SqlCommand sqlCommand = new SqlCommand("update Urunler set Name=@Name, Description=@Description, Price=@Price, Stock=@Stock, IsActive=@IsActive, Brand=@Brand, KategoriId=@KategoriId where Id=@id", conn); // kayıt ekleme komutlarımız
            sqlCommand.Parameters.AddWithValue("@Name", urun.Name);
            sqlCommand.Parameters.AddWithValue("@Description", urun.Description);
            sqlCommand.Parameters.AddWithValue("@Price", urun.Price);
            sqlCommand.Parameters.AddWithValue("@Stock", urun.Stock);
            sqlCommand.Parameters.AddWithValue("@IsActive", urun.IsActive);
            sqlCommand.Parameters.AddWithValue("@Brand", urun.Brand);
            sqlCommand.Parameters.AddWithValue("@id", urun.Id);
            sqlCommand.Parameters.AddWithValue("@KategoriId", urun.KategoriId);
            islemSonucu = sqlCommand.ExecuteNonQuery();
            sqlCommand.Dispose();
            conn.Close();
            return islemSonucu;
        }
        public int Delete(int id)
        {
            BaglantiyiAc();
            int islemSonucu = 0; // işlem sonunda db ye eklenirse geriye bu degisken üzerinden sonucu döndüreceğiz
            SqlCommand sqlCommand = new SqlCommand("delete from Urunler where Id=@id", conn); // kayıt ekleme komutlarımız            
            sqlCommand.Parameters.AddWithValue("@id", id);
            islemSonucu = sqlCommand.ExecuteNonQuery();
            sqlCommand.Dispose();
            conn.Close();
            return islemSonucu;
        }
        internal DataTable VerileriYukle(string sql)
        {
            BaglantiyiAc();
            DataTable dt = new DataTable(); // verileri çekip yükleyeceğimiz nesne
            SqlCommand cmd = new SqlCommand(sql, conn); // sql sorgumuzu göndereceğimiz nesne
            SqlDataReader dr = cmd.ExecuteReader(); // cmd nesnesindeki sql sorgusunu conn nesnesindeki db de çalıştır
            dt.Load(dr); // sql den okuduğun verileri dt nesnesine yükle
            dr.Close(); // veri okuyucuyu kapat
            cmd.Dispose(); // cmd nesnesini yoket
            conn.Close();
            return dt;
        }
    }
}
