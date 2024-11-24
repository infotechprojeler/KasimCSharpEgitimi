
namespace Konu14InterfacesArayuzler
{
    internal class Urun : ISinifGereksinimleri, IVeritabaniIslemleri // bir classa aralarına , koyarak birden fazla interface implement edebiliriz. Altı kırmızı olunca üzerine gelip ampul üzerinden implement interface diyoruz hata gidiyor.
    {
        // interface den gelenler
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        // urun classına özel propertyler
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public int KategoriId { get; set; }

        public void Add(string urunAdi)
        {
            // ürün ekleme kodlarını buraya yazarız.
            Console.WriteLine(urunAdi + " Ürünü Eklendi");
        }

        public void Delete(int id)
        {
            Console.WriteLine("Ürün Silindi");
        }

        public void GetAll()
        {
            Console.WriteLine("Ürünler listelendi");
        }

        public void Update(int id)
        {
            Console.WriteLine("Ürün Güncellendi");
        }
    }
}
