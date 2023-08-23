using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    public class Class1
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[] { 5, 3, 8, 10, 2 };
            var numbers = Array.CreateInstance(typeof(int), 5);
            ArrayList arrayList = new ArrayList(sayilar);
            //numbers.SetValue(5, 0);
            //numbers.SetValue(3, 1);
            //numbers.SetValue(8, 2);
            //numbers.SetValue(10,3);
            //numbers.SetValue(2, 4);
            sayilar.CopyTo(numbers, 0);
            for (int i = 0; i< numbers.Length; i++)
            {
                Console.WriteLine(numbers.GetValue(i) + $"{arrayList[i],3}");
            }

            arrayList.Sort();
            Array.Sort(numbers);
            Array.Sort(sayilar);
            Array.Clear(sayilar, 2, 4);
            var x = Array.IndexOf(numbers,7);
            Console.WriteLine(x); 


        }

        
    }
}
