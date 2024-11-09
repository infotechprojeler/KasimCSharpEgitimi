namespace Konu01Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Değişkenler"); // bu projeyi çalıştırmak için üst menüden play tuşu yanından projeyi seçtik.

            Console.WriteLine("Değişken tanımlama - Tam sayılar");
            // Değişken tanımlama - tam sayılar
            byte plakakodu = 34;
            short kisa = 123;
            int tamsayi = 1800;
            long uzunsayi = 123456;
            plakakodu = 18;
            Console.WriteLine("plaka kodu: " + plakakodu);

            Console.WriteLine();
            // Kesirli sayılar
            Console.WriteLine("Kesirli sayılar");
            float kesirliSayi = 4.5f;
            double kesirlidouble = 4.5;
            decimal urunFiyati = 5500;

            urunFiyati = 6600;

            Console.WriteLine("Ürün Fiyatı: " + urunFiyati);

            // Karakter
            char karakter = 'c'; // klavyedeki tüm karakterleri taşıyabilir. char veri tipi sadece 1 karakter alır ve tek tırnak içinde değer alır.

            // string veri tipi
            string metin = "klavyedeki tüm karakterleri yan yana yazılmış olarak taşıyabilir";

            Console.WriteLine();
            Console.WriteLine("metin: " + metin);

            // boolean veri tipi
            bool islemSonucu = false; // işlem başarılı mı başarısız mı 2 değer alabilir true-false

            Console.WriteLine("islemSonucu {0} ikinci parametre : {1}", islemSonucu, karakter);

            metin = "yeni metin";
            Console.WriteLine($"islemSonucu {islemSonucu} Metin yazısı : {metin}"); // değişkenleri metin içerisine bir önceki gibi parametreli göndermek yerine direk kullanabilmek için tırnak başına $ ekliyoruz

            // C# ta Sabit Tanımlama
            const int kdvMiktari = 18;
            const double dolarKuru = 34.18;
            const double euroKuru = 37.18;
            // kdvMiktari = 20; // sabitlerin değeri sonradan değiştirilemez!
            Console.WriteLine(kdvMiktari);

        }
    }
}
