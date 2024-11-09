namespace Konu04KosulYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Koşul Yapıları!");
            /*Console.WriteLine("Lütfen bir sayı giriniz!");
            var sayi = int.Parse(Console.ReadLine()); // Console.ReadLine() metodu ekrandaki satırdaki girilen veriyi okur
            if (sayi > 0)
            {
                Console.WriteLine("Girilen sayı pozitif");
            }
            else if (sayi == 0)
            {
                Console.WriteLine("Girilen sayı 0");
            }
            else
            {
                Console.WriteLine("Girilen sayı negatif");
            }

            Console.WriteLine("Kullanıcı adınızı giriniz!");
            string kullanici = Console.ReadLine();
            Console.WriteLine("Şifrenizi giriniz!");
            string sifre = Console.ReadLine();
            if (kullanici == "admin" && sifre == "123")
            {
                Console.WriteLine("Giriş Başarılı!");
            }
            else
            {
                Console.WriteLine("Giriş Başarısız!");
            }*/
            Console.WriteLine("switch case kullanımı");
            int ay = DateTime.Now.Month;
            switch (ay) // switch yaz tab a bas
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Mevsim Kış");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Mevsim İlkbahar");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Mevsim Yaz");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Mevsim Sonbahar");
                    break;
                default:
                    Console.WriteLine("Hata Oluştu!");
                    break;
            }
        }
    }
}
