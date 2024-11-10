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
        static void Main(string[] args)
        {
            Console.WriteLine("Konu 09 Struct-Yapilar!");
        }
    }
}
