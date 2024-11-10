namespace Konu07Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu 07 Donguler!");

            Console.WriteLine("1-For Döngüsü");
            for (int i = 0; i < 10; i++) // döngü tanımlaması
            {
                Console.WriteLine("i nin değeri : " + i); // her döndüğünde o anki değeri ekrana yaz
            }

            Console.WriteLine();
            Console.WriteLine("2-While Döngüsü");
            int j = 0; // değişken döngü dışında tanımlanır
            while (j < 10) // şartımız - j 10 dan küçük olduğu sürece dön
            {
                Console.WriteLine("j nin değeri : " + j); // j nin değerini yazdır
                j++; // döngü her çalıştığında j yi 1 artır ki sonsuz döngüye girmesin uygulama
            }

            Console.WriteLine();
            Console.WriteLine("3-Do While Döngüsü");
            int toplamUrun = 0; // değişken tanımladık
            do
            {
                Console.WriteLine("Ürünlerimiz");
                Console.WriteLine("Elektronik kategorisinde uygun fiyatlar.");
                Console.WriteLine("toplamın değeri : " + toplamUrun);
            }
            while (toplamUrun > 0);


            Console.WriteLine();
            Console.WriteLine("4-Foreach Döngüsü");
            string[] kategoriler = { "Elektronik", "Bilgisayar", "Telefon", "Aksesuar", "Mobilya" };
            foreach (var kategori in kategoriler) // dizi formatındaki yapılarda kullanılır
            {
                Console.WriteLine("kategori adı : " + kategori); // dizideki her bir elemanda dönülür
            }
            Console.WriteLine();

            Console.WriteLine("Kategorilerin iç içe kullanımı");

            string[] urunler = { "ürün 1", "ürün 2", "ürün 3" };

            foreach (var kategori in kategoriler) // dizi formatındaki yapılarda kullanılır
            {
                Console.WriteLine("kategori adı : " + kategori);
                foreach (var urun in urunler)
                {
                    Console.WriteLine("\tÜrün adı : " + urun);
                }
            }
        }
    }
}
