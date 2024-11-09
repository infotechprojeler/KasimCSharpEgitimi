namespace Konu05Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metotlar!");
            Console.WriteLine();

            ToplamaYap(); // metodu yazdıktan sonra burada çağırmazsak çalışmaz!

            //Console.WriteLine("Bir sayı giriniz:");
            //var sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Bir sayı daha giriniz:");
            //var sayi2 = Convert.ToInt32(Console.ReadLine());
            //ToplamaYap2(sayi1, sayi2);

            //Console.WriteLine();
            //var geridonendeger = ToplamaYap2(sayi1, sayi2, 10);
            //Console.WriteLine("geri donen değer: " + geridonendeger);

            //Console.WriteLine("geri donen değer 2: " + ToplamaYap2(sayi1, sayi2, 20));

            LoginKontrol();
        }
        static void ToplamaYap()
        {
            Console.WriteLine(10 + 8);
        }

        static void ToplamaYap2(int sayi1, int sayi2) // int sayi1, int sayi2 parametredir, dışarıdan veri kabulünü sağlar
        {
            Console.WriteLine("Sonuç : " + (sayi1 + sayi2));
        }

        // aşağıdaki metot geriye int türünde bir veri döndürür
        static int ToplamaYap2(int sayi1, int sayi2, int sayi3) // metot imzası(isim + parametreler)
        {
            Console.WriteLine();
            return sayi1 + sayi2 + sayi3; // return ile geriye sayıların toplamını döndürdük
        }

        static void LoginKontrol()
        {
            Console.WriteLine("Email adresinizi giriniz: ");
            var email = Console.ReadLine();
            Console.WriteLine("Şifreyi giriniz: ");
            var sifre = Console.ReadLine();
            var sonuc = UyeGirisi(email, sifre);
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrEmpty(sifre))
            {
                Console.WriteLine("Email ve Şifre Boş Bırakılamaz!");
            }
            else if (sonuc == true)
            {
                Console.WriteLine("Giriş Başarılı");
            }
            else
            {
                Console.WriteLine("Giriş Başarısız!");
            }
        }

        static bool UyeGirisi(string email, string sifre)
        {
            if (email == "info@siteadi.com" && sifre == "info@s18")
            {
                // burada uygulama login kodları yazılır.
                return true; // girilen değerler sistemdekiyle eşleşiyorsa geriye true değeri gönder
            }
            return false; // girilen değerler sistemdekiyle eşleşmiyorsa geriye false değeri gönder
        }

    }
}
