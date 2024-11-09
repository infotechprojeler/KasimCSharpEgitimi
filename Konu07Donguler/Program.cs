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
        }
    }
}
