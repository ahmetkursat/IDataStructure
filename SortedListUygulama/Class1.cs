using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListUygulama
{
    public class Class1
    {
        static void Main(string[] args)
        {
            //Sorted List

            var kitapIcerigi = new SortedList();

            kitapIcerigi.Add(1, " Önsöz");
            kitapIcerigi.Add(50," Değişkenler");
            kitapIcerigi.Add(40, " Operatörler");
            kitapIcerigi.Add(60, " Döngüler");
            kitapIcerigi.Add(45, " İlişkisel Operatörler");

            foreach(DictionaryEntry entry in kitapIcerigi)
            {
                Console.WriteLine($"{entry.Key}"+$"{entry.Value}");
            }



            Console.ReadKey();
        }
    }
}
