using System.Xml.Linq;

namespace Konu14InterfacesArayuzler
{
    internal class KategoriDBIslemleri : IVeritabaniIslemleri
    {
        public void Add(string name)
        {
            Console.WriteLine(name + " Kategorisi Eklendi!");
        }

        public void Delete(int id)
        {
            Console.WriteLine(id + " Numaralı Kategori Silindi!");
        }

        public void GetAll()
        {
            Console.WriteLine("Kategoriler getirildi");
        }

        public void Update(int id)
        {
            Console.WriteLine(id + " Numaralı Kategori Güncellendi!");
        }
    }
}
