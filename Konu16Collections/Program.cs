using System.Collections;// ArrayList i kullanabilmemizi sağlayan kütüphane
using System.Collections.Specialized; // StringCollection kütüphanesi

namespace Konu16Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collections, Koleksiyonlar!");
            // Ornek1();
            // Ornek2();
            // Ornek3();
            // Ornek4();
            // Ornek5();
            // Ornek6();
            // Ornek7();
            // Ornek8();
            ListKullanimi();
        }
        static void Ornek1()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1); // Add metodu parametre olarak obje alır
            arrayList.Add(2);
            arrayList.Add(3);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("ArrayList deki ilk eleman : " + arrayList[0]);
        }
        static void Ornek2()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("İstanbul"); // Add metodu parametre olarak obje alır
            arrayList.Add("Ankara");
            arrayList.Add("İzmir");
            arrayList.Add("Antalya");
            arrayList.Add("Muş");
            arrayList.Add("Çankırı");

            Console.WriteLine("");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("ArrayList deki ilk eleman : " + arrayList[0]);

            Console.WriteLine("");
            Console.WriteLine("ArrayList de Sıralama Yapabiliriz:");
            arrayList.Sort(); // Sıralama metodu
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Tersten Sıralama:");
            arrayList.Reverse();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
        static void Ornek3()
        {
            int tamSayi = 18;
            double kesirliSayi = 15.25;
            ArrayList arrayList = new ArrayList();
            arrayList.Add(tamSayi);
            arrayList.Add(kesirliSayi);
            arrayList.Add("Ankara");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("arrayListi for döngüsüyle kullanma:");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
        }
        static void Ornek4()
        {
            StringCollection strings = new StringCollection();
            // strings.Add(15); bu listeye sadece string veri eklenebilir
            strings.Add("ankara");
            strings.Add("istanbul");
            strings.Add("izmir");
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
        }
        static void Ornek5()
        {
            StringDictionary dictionary = new StringDictionary();
            Console.WriteLine("key value şeklinde 2 değer tutmak istersek kullanabiliriz");
            dictionary.Add("06", "ankara");
            dictionary.Add("34", "istanbul");
            dictionary.Add("35", "izmir");
            Console.WriteLine("StringDictionary");
            Console.WriteLine(dictionary["34"]);

            Console.WriteLine();
            Console.WriteLine("StringDictionary values");
            foreach (var item in dictionary.Values)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("StringDictionary Keys");
            foreach (var item in dictionary.Keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("StringDictionary");
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
        }
        static void Ornek6()
        {
            Stack stack = new Stack(); // stack sınıfı programlamada lifo kuyruğa son giren ilk çıkar kuralıyla çalışır.
            // stack.add(); burada add metodu ile ekleme yapılmaz
            stack.Push("İstanbul");
            stack.Push("Ankara");
            stack.Push("İzmir");
            stack.Push(34); // obje aldığı için her veri tipini ekleyebiliriz
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop()); // stack yığın yapısında nesneler üst üste konmuş gibidir ve çekmeye en üsttekinden başlanır.
            }
        }
        static void Ornek7()
        {
            Queue queue = new Queue(); // Queue sınıfı programlamada Fifo sistemiyle çalışır-ilk giren ilk çıkar
            queue.Enqueue("İstanbul");
            queue.Enqueue("Ankara");
            queue.Enqueue("İzmir");
            queue.Enqueue(18);
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
        static void Ornek8()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            Console.WriteLine("Dictionary sınıfı da key value ile çalışır ve key value nin veri tipinin ne olması gerektiğini kendimiz belirleyebiliriz.");
            dictionary.Add("book", "Kitap");
            dictionary.Add("34", "İstanbul");
            dictionary.Add("06", "Ankara");
            Console.WriteLine(dictionary["book"]);
            Console.WriteLine();
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Dictionary<int, string> dictionary2 = new();
            dictionary2.Add(1, "Adana");
            dictionary2.Add(6, "Ankara");
            dictionary2.Add(34, "İstanbul");
            foreach (var item in dictionary2)
            {
                Console.WriteLine(item.Key);
            }

            Console.WriteLine();

            foreach (var item in dictionary2)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine();

            foreach (var item in dictionary2)
            {
                Console.WriteLine(item.Key + "-" + item.Value);
            }
        }
        static void ListKullanimi()
        {
            Console.WriteLine("Listeler");
            List<string> sehirler = new List<string>();
            sehirler.Add("İstanbul");
            sehirler.Add("Ankara");
            sehirler.Add("İzmir");
            foreach (var item in sehirler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            List<User> users = new(); // boş bir kullanıcı listesi
            users.Add(new User()
            {
                Id = 1,
                Name = "Duygu",
                Password = "Hacker123",
            });
            users.Add(new User()
            {
                Id = 2,
                Name = "Busra",
                Password = "Busra987"
            });
            Console.WriteLine("Kullanıcılar:");
            foreach (var item in users)
                Console.WriteLine(item.Name);

            List<User> kullanicilar = new List<User>()
            {
                new() {
                    Id = 3,
                    Name = "Alp",
                    Password = "Alp369"
                },new User
                {
                    Id = 4,
                    Name = "Murat Yılmaz",
                    Password = "Murat2534"
                }
            };
            kullanicilar.Add(new User()
            {
                Id = 5,
                Name = "Bahar",
                Password = "14789"
            });

            Console.WriteLine();

            Console.WriteLine("Kullanıcılar 2:");
            foreach (var item in kullanicilar)
                Console.WriteLine(item.Name);

            kullanicilar.AddRange(users); // kullanicilar isimli listeye users isimli listedeki elemanları ekle

            Console.WriteLine();

            Console.WriteLine("Kullanıcılar 3:");
            foreach (var item in kullanicilar)
                Console.WriteLine(item.Name);

            var yeniKullanici = new User()
            {
                Id = 6,
                Name = "Ege"
            };

            Console.WriteLine();

            Console.WriteLine("Listede yeniKullanici var mı?");
            Console.WriteLine(kullanicilar.Contains(yeniKullanici));

            kullanicilar.Add(yeniKullanici);

            Console.WriteLine("Listede yeniKullanici var mı?");
            Console.WriteLine(kullanicilar.Contains(yeniKullanici));

            Console.WriteLine();

            foreach (var item in kullanicilar)
                Console.WriteLine(item.Name);

            kullanicilar.Insert(0, yeniKullanici); // Insert metodu listedeki belirtilen indexe kaydı ekler

            Console.WriteLine();

            foreach (var item in kullanicilar)
                Console.WriteLine(item.Name);
        }
    }
}
