namespace Konu08SiniflarClasses
{
    class Ev
    {
        internal string sokakAdi; // internal = erişim belirteci
        internal int kapiNo;
        string mahalle;
    }
    /*
        Erişim belirteçleri:
        Sınıflar ve sınıf öğelerine erişimi kısıtlamak için kullanılır.
    Public    : Erişim kısıtı yoktur her yerden erişilebilir
    Protected : Ait olduğu sınıftan ve o sınıftan türetilen sınıflardan erişilebilir
    internal  : Etkin projeye ait sınıflardan erişilebilir
    private   : yalnız bulunduğu sınıftan erişilebilir

    1 öğe sadece 1 erişim belirteci alabilir!
    namespace erişim belirteci almaz public tir
     */
    public class deneme // public - her yerden erişilebilen class
    {
        public string urunAdi = "klavye"; // public - her yerden erişilebilen değişken
        protected class test
        {
            string urunAdi; // erişim belirteci vermezsek varsayılan private olur
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sınıflar - Classes!");

            Ev ev = new Ev(); // yukardaki ev sınıfından ev isminde bir somut nesne oluşturduk
            ev.sokakAdi = "papatya sokak"; // erişim belirteci tanımlayıp ev sınıfındaki değişkenlere veri atayabildik
            ev.kapiNo = 18;
            // ev.mahalle = // erişim belirteci vermediğimiz için gelmiyor
            Console.WriteLine("Sokak adı : " + ev.sokakAdi);
            Console.WriteLine("Kapı numarası : " + ev.kapiNo);

            Console.WriteLine();

            Ev yazlik = new Ev();
            yazlik.sokakAdi = "Deniz sk.";
            yazlik.kapiNo = 1;

            Console.WriteLine("yazlik sokak Adi: " + yazlik.sokakAdi);
            Console.WriteLine("yazlik kapi No: " + yazlik.kapiNo);

            Console.WriteLine();

            Ev koyEvi = new() // Ev sınıfından bu şekilde de nesne oluşturabiliriz
            {
                kapiNo = 1, // bu tanımlamada değişkenler arası virgül ile ayrılır
                sokakAdi = "Yeşil bahçe sokak"
            };
            Console.WriteLine("koyEvi \n Bilgileri : ");
            Console.WriteLine(koyEvi.sokakAdi);
            Console.WriteLine(koyEvi.kapiNo);

            Kategori kategori = new Kategori();
            kategori.Adi = "Elektronik";

            Console.WriteLine();
            Console.WriteLine("Kategori Adı:");
            Console.WriteLine(kategori.Adi);

            Console.WriteLine();
            Kullanici kullanici = new Kullanici() // yöntem 1
            {
                Adi = "Eylul",
                KullaniciAdi = "eylul09",
                Sifre = "Eylul0009"
            };
            Kullanici kullanici2 = new() // yöntem 2
            {
                Adi = "Beyza",
                KullaniciAdi = "beyza02",
                Sifre = "Byz002",
                Email = "beyza@google.com"
            };
            Console.WriteLine();
            Console.WriteLine("kullanici 1 bilgileri:");
            Console.WriteLine($"KullaniciAdi: {kullanici.KullaniciAdi}");

            Console.WriteLine();

            Araba araba = new()
            {
                Id = 1,
                KasaTipi = "SUV",
                Marka = "TOGG",
                Model = "T10X",
                Renk = "Bordo",
                VitesTipi = "Otomatik",
                YakitTipi = "Alentrik"
            };
            Console.WriteLine(kullanici.Adi + " Araç Bilgisi:");
            Console.WriteLine($"{araba.Marka} {araba.Model} {araba.Renk} {araba.KasaTipi}");

            Console.WriteLine();

            SiniftaMetotKullanimi siniftaMetotKullanimi = new();

            // sayılar ekrandan alınabilir
            Console.WriteLine("ToplamaYap: " + siniftaMetotKullanimi.ToplamaYap(10, 8));

            Console.WriteLine("LoginKontrol: " + siniftaMetotKullanimi.LoginKontrol("Admin", "Beyza002"));

            Console.WriteLine("Statik Özellik:");
            Console.WriteLine(Marka.StatikOzellik);

            Marka.StatikOzellik = "Marka Statik Ozellik";

            Console.WriteLine("Statik Özellik 2:");
            Console.WriteLine(Marka.StatikOzellik);
            var marka = new Marka() { 
                Id = 1,
                Name = "Monster",
                IsActive = true,
            };
            if (marka.IsActive) // bu kod marka.IsActive == true kontrolü yapar
            {
                Console.WriteLine("marka: " + marka.Name);
            }
            var urun = new Urun()
            {
                Id = 2,
                Marka = marka,
                Name = "Abra a18 Notebook",
                Description = "Game pc",
                Price = 49900,
            };
            Console.WriteLine("Ürün Detayı:");
            Console.WriteLine(urun.Marka.Name + " " + urun.Name);
            Console.WriteLine("Fiyat: " + urun.Price + " TL");
        }
    }
}
