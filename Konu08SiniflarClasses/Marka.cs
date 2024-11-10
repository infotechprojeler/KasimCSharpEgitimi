
namespace Konu08SiniflarClasses
{
    internal class Marka
    {
        public Marka() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now; // bir property e bu şekilde başlangıç değeri atayıp eğer veri gönderilmemişse bu değeri kulanmasını sağlayabiliriz.
        public static string StatikOzellik = "static işaretli özelliği clasadi.ozellikadi şeklinde direk çağırabiliriz. Statik olmayanlar ise dinamiktir.";
    }
}
