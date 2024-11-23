namespace Konu09StructYapilar
{
    public struct yapi
    {
        public int sayi;
        public string metin;
        public void Metot()
        {
            Console.WriteLine("yapı içindeki metot çalıştı!");
        }
    }
    /*
     * struct - yapılar sınıfa benzer, sınıfların nesneleri bellekte heap alanında tutulurken yapılarınki stack alanında tutulur.
     * c# ta değişkenler referans ve değer tipli olarak 2 ye ayrılır.
     * stack de tutulan veriler işi bitince silinir
     * heap te tutulan veriler kendiliğinden silinmez gc ile silinir
     */

    internal class Program
    {
        struct Kimlik
        {
            // değişkenler
            public string Ad;
            public string Soyad;
            public int yas;
            public string dogumYeri;

            public struct Adres
            {
                // property ler
                public int Id { get; set; }
                public string Sehir { get; set; }
                public string Mahalle { get; set; }
                public string AcikAdres { get; set; }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Konu 09 Struct-Yapilar!");

            yapi ilkyapi = new yapi();
            ilkyapi.metin = "yapı metni";
            ilkyapi.sayi = 25;
            ilkyapi.Metot();

            Kimlik kimlik = new Kimlik();
            kimlik.Ad = "Duygu";
            kimlik.Soyad = "Kır";
            kimlik.yas = 20;

            Console.WriteLine($"Kişi Bilgileri : Ad {kimlik.Ad} - Soyad : {kimlik.Soyad}");

            Kimlik.Adres adres = new();
            adres.Sehir = "İstanbul";
            adres.Mahalle = "Örnek";

            Console.WriteLine(adres.Sehir);

        }
    }
}
