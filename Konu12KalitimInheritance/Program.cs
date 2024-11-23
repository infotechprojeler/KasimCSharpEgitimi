namespace Konu12KalitimInheritance
{
    class Arac
    {
        public string AracTuru;
        public void AracKornasi()
        {
            Console.WriteLine("Kornaya basıldı!");
        }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public int UretimYili { get; set; }
    }
    class Otomobil : Arac // Otomobil bir araçtır : ile arac icindekilere sahip olur
    {
        public string KasaTipi { get; set; }
    }
    class Tren : Arac
    {
        public string TrenTipi { get; set; }
        public string VagonSayisi { get; set; }
    }
    class Gemi : Arac
    {
        public string GemiTipi { get; set; }
        public int MotorSayisi { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalitim-Inheritance!");
            Arac arac = new Arac();
            arac.AracTuru = "Otomobil";
            Console.WriteLine("Araç Türü : " + arac.AracTuru);
            Otomobil otomobil = new Otomobil();
            otomobil.AracKornasi(); // AracKornasi metodu Otomobil sınıfında olmadığı halde : ile miras aldığımız için kullanabiliyoruz
            otomobil.Marka = "TOGG";
            otomobil.Model = "T10X";
            Console.WriteLine("Araç marka model : " + otomobil.Marka + " " + otomobil.Model);
            Kategori kategori = new Kategori();
            kategori.Name = "Elektronik";
            kategori.YanMenu = true;
            Console.WriteLine("Kategori Adı:");
            Console.WriteLine(kategori.Name);
            Console.WriteLine("Yan Menüde Gösterilsin mi?");
            Console.WriteLine(kategori.YanMenu);

            Urun urun = new()
            {
                Name = "Dizüstü PC",
                AnasayfadaGoster = true,
                CreateDate = DateTime.Now,
                Fiyat = 49900,
                KDV = 20,
                KategoriId = 1,
                Description = "İş Bilgisayarı"
            };

            Console.WriteLine("Ürün Bilgileri");
            Console.WriteLine(urun.Name);
            Console.WriteLine(urun.Fiyat + " ₺");
            Console.WriteLine(urun.Description);

            kategori.Ekle();
            urun.Ekle();

            Cizici[] birCizici = new Cizici[3];
            birCizici[0] = new DogruCiz();
            birCizici[1] = new DaireCiz();
            birCizici[2] = new Cizici();

            foreach (var c in birCizici)
                c.Ciz();
        }
    }
    // Polimorpizm - çok biçimlilik
    public class Cizici
    {
        public virtual void Ciz() // bu metotta virtual keyword ünün kullandık ki bu metodu ezebilelim
        {
            Console.WriteLine("Cizici metodu çalıştı");
        }
    }
    public class DogruCiz : Cizici
    {
        public override void Ciz()
        {
            Console.WriteLine("DogruCiz metodu çalıştı");
        }
    }
    public class DaireCiz : Cizici
    {
        public override void Ciz()
        {
            Console.WriteLine("DaireCiz metodu çalıştı");
        }
    }
}
