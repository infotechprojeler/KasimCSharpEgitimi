namespace Konu06Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diziler-Arrays!");
            int sayi = 10; // standart değişken tanımı
            int[] ogrenciler = new int[6]; // içerisinde 6 taneye kadar int tipinde değişken taşıyabilen dizi tanımlaması
            ogrenciler[0] = 100;
            ogrenciler[1] = 200;
            ogrenciler[2] = 300;
            ogrenciler[3] = 400;
            ogrenciler[4] = 500;
            ogrenciler[5] = 500; // dizi içerisindeki elemana aynı veri eklenebilir
            // ogrenciler[6] = 600; // bu kod hataya sebep olur
            Console.WriteLine("ogrenciler[1] : " + ogrenciler[1]); // dizideki bir veriye ulaşma
            Console.WriteLine("ogrenciler[4] : " + ogrenciler[4]); // dizideki bir veriye ulaşma
            Console.WriteLine("ogrenciler[5] : " + ogrenciler[5]); // dizideki bir veriye ulaşma

            string[] isimler = new string[6];
            isimler[0] = "Bahar";
            isimler[1] = "Büşra";
            isimler[2] = "Alp";
            isimler[3] = "Mehmet";
            isimler[4] = "Ömer";

            Console.WriteLine("isimler[2] : " + isimler[2]);
            isimler[2] = "Cem";
            Console.WriteLine("isimler[2] : " + isimler[2]);

            string[] kategoriler = { "Elektronik", "Bilgisayar", "Telefon", "Aksesuar", "Mobilya" };

            Console.WriteLine("kategoriler[2] : " + kategoriler[2]);
            kategoriler[2] = "Televizyon";
            Console.WriteLine("kategoriler[2] : " + kategoriler[2]);

            string[] urunler = { "ürün 1", "ürün 2", "ürün 3" };
            Console.WriteLine(urunler[1]);

        }
    }
}
