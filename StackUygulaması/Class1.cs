using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUygulaması
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Sayı Giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());

            var sayiYigini = new Stack<int>();

            while (sayi > 0) {

                int k = sayi % 10;
                sayiYigini.Push(k);
                sayi = sayi / 10;
            }

            int i = 0;
            int n = sayiYigini.Count() -1 ;

            foreach (var s in sayiYigini)
            {
                Console.WriteLine($"{s} x ${Math.Pow(10,n-i)}  = ${s*Math.Pow(10,n-i)}");
                i++;
            }




            Console.ReadKey();
        }
    }
}
