using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Queue
{
    public class Class1
    {
        static void Main(string[] args)
        {
            kuyruktemeller();

            var sesliHarfler = new List<char>()
            {
                'a','e','ı','i','u','ü','o','ö'
            };


            ConsoleKeyInfo secim;
            var kuyruk = new Queue<char>();



            foreach (char k in sesliHarfler)
            {
                Console.WriteLine();
                Console.Write($"{k,-5} kuyruga eklensinmi? [e/h]" );
                secim = Console.ReadKey();
                Console.WriteLine();
                if(secim.Key == ConsoleKey.E)
                {
                    kuyruk.Enqueue(k);
                    Console.WriteLine($"\n{k,-5} kuyruga eklendi");
                }


            }



            Console.ReadKey();


        }

        private static void kuyruktemeller()
        {
            //tanımlama
            var karakerKuyrugu = new Queue<char>();
            //Ekleme
            karakerKuyrugu.Enqueue('a');
            karakerKuyrugu.Enqueue('b');

            Console.WriteLine($"Elemnan sayisi : {karakerKuyrugu.Count}");

            //Diziye atama

            var dizi = karakerKuyrugu.ToArray();

            //Çıkarma 
            Console.WriteLine($"Kuyrugun başındaki eleman : {karakerKuyrugu.Peek}");
            Console.WriteLine($"{karakerKuyrugu.Dequeue()} : kuyruktan cıkarıldı");
            Console.WriteLine($"Eleman Sayısı {karakerKuyrugu.Count}");
            Console.WriteLine($"Kuyrugun basındakı eleman : {karakerKuyrugu.Peek()}");
        }



    }
}
