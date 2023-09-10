using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSet
{
    public class Class1
    {
        static void Main(string[] args)
        {
            var A = new SortedSet<int>(RastgeleSayiüret(10));
            var B = new SortedSet<int>(RastgeleSayiüret(10));

            Console.WriteLine();
            Console.WriteLine("A kümesi");
            foreach (int s  in A)
            {
                Console.WriteLine($"{s,5}");
            }

            Console.WriteLine("B kümesi");
            foreach (int s in B)
            {
                Console.WriteLine($"{s,5}");
            }

            ////UNİON BİRLEŞİM

            //A.UnionWith(B);
            //Console.WriteLine();
            //Console.WriteLine("A ve B kümesinin Birleşimi");
            //foreach (var  s in A)
            //{
            //    Console.WriteLine($"{s}");

            //}

            //kesişim

            //A.IntersectWith(B);
            //Console.WriteLine();
            //Console.WriteLine("A ve B kümesinin kesişimi");
            //foreach (var s in A)
            //{
            //    Console.WriteLine($"{s}");

            //}

            //SADECE A ELEMANI
            //A.ExceptWith(B);
            //Console.WriteLine();
            //Console.WriteLine("A Elemanları");
            //foreach (var s in A)
            //{
            //    Console.WriteLine($"{s}");

            //}


            ////SADECE B ELEMANI
            //B.ExceptWith(A);
            //Console.WriteLine();
            //Console.WriteLine("B Elemanları");
            //foreach (var s in B)
            //{
            //    Console.WriteLine($"{s}");

            //}

            //SİMETRİK ELEMANLAR KESİŞİMİN OLMADIGI 
            A.SymmetricExceptWith(B);
            Console.WriteLine();
            Console.WriteLine("A ve B Simetrikleri");
            foreach (var s in A)
            {
                Console.WriteLine($"{s}");

            }

            Console.ReadKey();
        }

        static List<int> RastgeleSayiüret(int n)
        {
            var list = new List<int>();
            var r = new Random();

            for (int i = 0; i < n; i++)
            {
                list.Add(r.Next(0,10));
            }
            return list;
        }

        private static void BenzersizSayi()
        {
            var sayilar = new List<int>();

            var r = new Random();


            Console.WriteLine();
            for (int i = 0; i < 100; i++)
            {
                sayilar.Add(r.Next(0, 10));
                Console.Write($"{sayilar[i],-5}");
            }

            Console.WriteLine();

            // Listedeki benzersiz elemanları bulmak

            var benzersizSayiListesi = new SortedSet<int>(sayilar);

            Console.WriteLine("Benzersiz Sayıların Listesi");

            foreach (int a in benzersizSayiListesi)
            {
                Console.Write($"{a,-3}");
            }

            Console.ReadKey();
        }

        private static void sortedsetuygulama()
        {
            //tanımlama
            var list = new SortedSet<string>();
            //ekleme
            if (list.Add("Ahmet"))
            {
                Console.WriteLine("AHMET EKLENDİ");
            }
            else
            {
                Console.WriteLine("Ekleme Başarısız");
            }

            Console.WriteLine("{0}", list.Add("Mehmet") == true ? "Mehmet Eklendi" : "Ekleme başarısız");

            list.Add("Şule");
            list.Add("Neslihan");
            list.Add("Fahrettin");
            list.Add("Fatih");

            //Eleman Cıkarma
            list.Remove("Şule");
            list.RemoveWhere(deger => deger.Contains("a")); //küçük a ifadelerini siler
            list.RemoveWhere(deger => deger.StartsWith("f")); //f başlayanifadelerini siler
            list.RemoveWhere(deger => deger.EndsWith("f")); //f biten ifadelerini siler


            //eleman sayısı

            list.Count();

            Console.WriteLine("İsimler Listesi");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
