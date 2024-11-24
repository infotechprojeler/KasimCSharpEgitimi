namespace Konu14InterfacesArayuzler
{
    interface OrnekArayuz
    {
        // örnek arayüz tanımlaması
        public int Id { get; set; }
    }

    interface ISinifGereksinimleri
    {
        // bu arayüzü kullanacak class lar aşağıdaki özellikleri içermek zorundadır!
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interfaces-Arayuzler!");
            Urun urun = new Urun();
            Console.WriteLine("Ürün Adı Giriniz:");
            var urunadi = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(urunadi))
            {
                urun.Name = urunadi;
                urun.Add(urun.Name);
            }
            else
                Console.WriteLine("Ürün Adı Boş Geçilemez!");

            Console.WriteLine();
            Console.WriteLine("Kategori Adı Giriniz:");
            var kategoriadi = Console.ReadLine();
            Kategori kategori = new Kategori();
            KategoriDBIslemleri kategoriDBIslemleri = new();
            if (!string.IsNullOrWhiteSpace(kategoriadi))
            {
                kategori.Name = kategoriadi;
                kategoriDBIslemleri.Add(kategori.Name);
            }
            else
                Console.WriteLine("Kategori Adı Boş Geçilemez!");
        }
    }
}
