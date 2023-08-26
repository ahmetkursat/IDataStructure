using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableUygulaması_2
{



    public class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Başlık Giriniz");
            string baslik = Console.ReadLine();

            //küçültme
            baslik = baslik.ToLower();

            //Hashtable 
            var karakterseti = new Hashtable()
            {
                {'ç','c'},
                {'ı','i'},
                {'ö','o'},
                {'ü','u'},
                {' ','-'},
                {'\'','-'},
                {'ğ','g' },
                {'.' ,'-'},
                {'?','-' }
            };
            foreach (DictionaryEntry k in karakterseti)
            {
                baslik = baslik.Replace((char)k.Key, (char)k.Value);
            }

            Console.WriteLine(baslik);

            Console.ReadKey();
        }
    }
}
