namespace Konu14InterfacesArayuzler
{
    // proje içerisine harici interface oluşturma;
    // Konu14InterfacesArayuzler projesine sağ tıkla > açılan menüden add > class deyip açılan pencereden 3. sıradaki interface i seç > I ile başlayan bir isim ver ve add.
    internal interface IVeritabaniIslemleri
    {
        // bu arayüzü kullanacak class lar aşağıdaki metotları içermek zorundadır!
        // CRUD metot imzaları
        void Add(string name); // ekle
        void Update(int id); // güncelle
        void Delete(int id); // sil
        void GetAll(); // listele
        // interface lerde metotlar açıkça yazılmaz, sadece geri dönüş tipi, adı ve parametresi belirtilir.
    }
}
