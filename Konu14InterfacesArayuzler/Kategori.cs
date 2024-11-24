namespace Konu14InterfacesArayuzler
{
    internal class Kategori : ISinifGereksinimleri
    {
        // interface den gelenler
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        // kategoriye özel alanlar
        public bool UstMenudeGoster { get; set; }
        public bool YanMenudeGoster { get; set; }
    }
}
