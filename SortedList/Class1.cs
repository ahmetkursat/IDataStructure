using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListeler
{
    public class Class1
    {
        //Tanımlama 
        static void Main(string[] args)
        {
            var list = new SortedList()
            {
                { 1, "bir" },
                { 2, "iki" },
                { 3, "üç" },
                { 5,"beş" },
                 { 4,"dört" }
        };


            list.Add(8, "Sekiz");

            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key}" + $"{item.Value}");
            }

            Console.WriteLine("Listedeki Eleman Sayısı : {0}", list.Count);
            Console.WriteLine("Listenin Kapasitesi :{0}", list.Capacity);
            list.TrimToSize();
            Console.WriteLine("Listenin Kapasitesi::{0}", list.Capacity);

            

            //Erişme
            Console.WriteLine(list[4]);
            //Indexe Baglı OlARAK
            Console.WriteLine(list.GetByIndex(0));
            //getkey
            Console.WriteLine(list.GetKey(0));
            //liste sonundaki elemanın değeri
            Console.WriteLine(list.GetByIndex(list.Count-1));
            //liste sonundaki elemanın anahtarı
            Console.WriteLine(list.GetKey(list.Count - 1));

            var anahtar = list.Keys;
            Console.WriteLine(anahtar);
            
            if (list.ContainsKey(1))
            {
                list[1] = "One";
            }
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key}" + $"{item.Value}");
            }


            Console.ReadKey();
        }




    }
}
