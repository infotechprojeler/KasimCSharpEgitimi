namespace Konu17HataYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hata Yönetimi!");
            Console.WriteLine("Fiyat Giriniz:");
            var sayi = Console.ReadLine();

            // KdvHesapla(double.Parse(sayi)); // burada eğer kullanıcı sayısal olmayan değer girerse uygulama çöküyor ve hata veriyor. Çökmeyi engellemek için try yazıp 2 kere tab a basıyoruz

            try
            {
                // buraya yazacağımız kodlar çalıştırılmak istenince deneme yapılır çalışırsa sistem yola devam eder, çalışmazsa aşağıdaki catch bloğuna geçer kod.
                KdvHesapla(double.Parse(sayi));
            }
            catch (Exception hata) // Exception sınıfı bize oluşan hatayı detaylarıyla birlikte verir bizim sadece bir isim vermemiz lazım.
            {
                // burası hata yakalama bloğudur, oluşan hatayı yakalayıp yönetebiliriz.
                // throw; // bu kod yine hata fırlatmaya sebep olur
                Console.WriteLine("Geçersiz Değer Girdiniz!");
                Console.WriteLine("Lütfen sadece sayısal değer giriniz!");
                var fiyat = Console.ReadLine();
                KdvHesapla(double.Parse(fiyat));

                Console.WriteLine();
                Console.WriteLine("Oluşan Hata:");
                Console.WriteLine(hata); // hata nesnesi üzerinden oluşan hatayı yakalayıp işlem yapabiliriz.
                // burada oluşan hata bilgilerini kendimize mail olarak gönderebiliriz

                Console.WriteLine();

                Console.WriteLine("hata.Message:");
                Console.WriteLine(hata.Message);
            }
            finally
            {
                Console.WriteLine("finally bloğu çalıştı!");
                // burada try catch bloğu çalıştıktan sonra her seferinde yapmak istediğimiz işlemleri yapabiliriz.
                Console.WriteLine("Fiyat giriniz:");
                var fiyat2 = Console.ReadLine();
                KdvHesapla(double.Parse(fiyat2));
            }

        }
        static void KdvHesapla(double fiyat)
        {
            Console.WriteLine("Fiyat: " + fiyat);
            Console.WriteLine("Kdv: " + (fiyat * 0.20));
            Console.WriteLine("Kdv dahil toplam tutar: " + (fiyat +(fiyat * 0.20)));
        }
    }
}
