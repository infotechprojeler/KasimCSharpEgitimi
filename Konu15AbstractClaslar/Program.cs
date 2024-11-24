namespace Konu15AbstractClaslar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Claslar!");
            Console.WriteLine("Classlar ile Interfacelerin karışımı bir yapıları vardır. Hem class gibi kullanabiliriz hem interface gibi.");
            // Database database = new Database();// abstract sınıftan bu  şekilde new diyerek nesne üretemeyiz!
            Database sqlServer = new SqlServer(); // new Database();  Ancak kalıtım alan class tan nesne oluşturabiliriz
            sqlServer.Delete(18);
            sqlServer.Add();
            Database mysql = new MySql();
            mysql.Add();
            mysql.Update(25);
        }
    }
    abstract class Database
    {
        // abstract sınıflarda aşağıdaki gibi metot tanımlayabiliriz
        public void Add()
        {
            Console.WriteLine("Ekleme metodu çalıştı.");
        }
        public void GetAll()
        {
            Console.WriteLine("Listeleme metodu çalıştı.");
        }
        // abstract sınıflarda aşağıdaki gibi metot imzaları tanımlayabiliriz
        public abstract void Delete(int id);
        public abstract void Update(int id);
        public abstract void Get(int id);
    }
    class SqlServer : Database
    {
        public override void Delete(int id)
        {
            Console.WriteLine(id + " Numaralı Kayıt Silindi!");
        }

        public override void Get(int id)
        {
            Console.WriteLine(id + " Numaralı Kayıt Getirildi!");
        }

        public override void Update(int id)
        {
            Console.WriteLine(id + " Numaralı Kayıt Güncellendi!");
        }
    }
    class MySql : Database
    {
        public override void Delete(int id)
        {
            Console.WriteLine(id + " Numaralı Kayıt Silindi!");
        }

        public override void Get(int id)
        {
            Console.WriteLine(id + " Numaralı Kayıt Getirildi!");
        }

        public override void Update(int id)
        {
            Console.WriteLine(id + " Numaralı Kayıt Güncellendi!");
        }
    }
}
