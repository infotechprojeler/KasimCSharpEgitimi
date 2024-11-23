namespace Konu10StringSinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Sınıfı!");
            string degisken;
            char karakter;
            string metin = "String yan yana dizi formatında char yapısıdır.";
            Ornek();
        }
        static void Ornek()
        {
            string birMetin = "Ankara başkenttir";
            String birSayi = "123456789";
            System.String birTarih = "23-11-2024";
            string s = "Barış Manço";
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine($"s[{i}] {s[i]}"); // i nin değerini ve s değişkeninde i. indexteki değeri ekrana yaz
            }
            Console.WriteLine();
            foreach (char c in s)
            {
                Console.WriteLine(c); // s değişkenindeki her karakteri tek tek ekrana yaz
            }
            Console.WriteLine("birMetin veri tipi : " + birMetin.GetType()); // GetType metodu bize ilgili değişkenin veri tipini getirir.
            Console.WriteLine("birSayi veri tipi : " + birSayi.GetType());
            Console.WriteLine("birTarih veri tipi : " + birTarih.GetType());
        }
    }
}
