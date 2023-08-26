using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableUygulama
{
    public class Class1
    {
        static void Main(string[] args)
        {
            //Tanımlama
            var sehirler = new Hashtable();

            //Ekleme
            sehirler.Add(6,"Ankara");
            sehirler.Add(34, "İstanbul");
            sehirler.Add(55, "Samsun");
            sehirler.Add(53, "Rize");

            //Dolaşma

            foreach (DictionaryEntry item in sehirler)
            {
                Console.WriteLine($"{item.Key,-5},{item.Value}");
            }

            // Anahtarları Alma
            Console.WriteLine("Anahtarları Almak");
            var anahtarlar = sehirler.Keys;
            foreach (var key in anahtarlar)
            {
                Console.WriteLine(key);
            }

            //Değerler 
            Console.WriteLine("Değerler (Values)");

            ICollection degerler = sehirler.Values;
            foreach (var key in degerler)
            {
                Console.WriteLine(key);
            }

            //Elemana Erişim
            Console.WriteLine("Elemana Erişim");
            Console.WriteLine(sehirler[55]);

            //Eleman Kaldırma
            sehirler.Remove(55);
            
            foreach (DictionaryEntry item in sehirler)
            {
                Console.WriteLine($"{item.Key},{item.Value}");
            }

            Console.ReadKey();


        }
    }
}
