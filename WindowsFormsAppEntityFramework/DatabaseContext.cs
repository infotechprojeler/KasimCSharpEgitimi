using ClassLibrary1;
using System.Data.Entity; // entity framework kütüphanesi

namespace WindowsFormsAppEntityFramework
{
    internal class DatabaseContext : DbContext // DbContext sınıfı entity framework kütüphanesinden gelir
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; } // DbSet ler entity frameworkte veritabanı tablolarını ifade eder. Her bir dbset  veritabanındaki bir tabloya karşılık gelir.
    }
}
