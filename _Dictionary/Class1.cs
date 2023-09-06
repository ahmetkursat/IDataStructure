using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Dictionary
{
    public class Class1
    {
        static void Main(string[] args)
        {
            //Dictionary
            var telefonKodlari = new Dictionary<int, string>()
            {
                {332,"Konya" },
                {424,"Elazığ" },
                {466,"Artvin" }
            };

            //Ekleme
            telefonKodlari.Add(322, "Adana");
            telefonKodlari.Add(212,"İstanbul");
            telefonKodlari.Add(216, "İstanbul");

            //Erişim
            telefonKodlari[466] = "Artvin";

            //ContainKey
            if (!telefonKodlari.ContainsKey(312))
            {
                Console.WriteLine("Ankaranın Kod Bilgisi Tanımlı Değil");
                telefonKodlari.Add(312, "Ankara");
                Console.WriteLine("Yeni Kod Eklendi");
            };

            //ContainsValue

            if (!telefonKodlari.ContainsValue("Malatya"))
            {
                Console.WriteLine("\a Malatyanın kod bilgisi tanımlı değil");
                telefonKodlari.Add(512, "Malatya");
                Console.WriteLine("Yeni Kod Eklendi");
            };

            telefonKodlari.Remove(322);

            foreach (var item in telefonKodlari)
            {
                Console.WriteLine(item);
            }




            Console.ReadKey();

        }



    }
}
