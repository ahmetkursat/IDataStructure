using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{


    public class Class1
    {
        static void Main(string[] args)
        {
            //Normal Kullanım

            //Ogrencı ogrencı = new Ogrencı();
            //ogrencı.Numara = 10;
            //ogrencı.Adi = "Ahmet";
            //ogrencı.Soyadi = string.Empty;
            //ogrencı.Cinsiyet = true;

            //Console.WriteLine($"{ogrencı.Numara}+{ogrencı.Adi}+{ogrencı.Cinsiyet}");

            //Alternatif Kullanım

            //var ogr2 = new Ogrencı()
            //{
            //    Numara = 20,
            //    Adi = string.Empty,
            //    Soyadi = string.Empty,
            //    Cinsiyet = true

            //};
            //2 alternatif kullanım 
            //Console.WriteLine(ogr2);
            //Console.WriteLine($"{ogr4.Numara}+{ogr4.Adi}+{ogr4.Cinsiyet}");

            var ogrenciListesi = new List<Ogrencı>(){
                new Ogrencı(50,"seyit","makarna",true),
                new Ogrencı(20,"string.Empty","string.Empty",false),
                new Ogrencı(30, "ahmet", "yıldız", true),
                new Ogrencı(40, "amıde", "dasds")
            };


            foreach (var list in ogrenciListesi)
            {
                Console.WriteLine(list);
            }

            ogrenciListesi.ForEach(list  => Console.WriteLine(list));

            var N1 = new Nokta(3,5);
            Console.WriteLine(N1);
            N1.Degistir();
            Console.WriteLine(N1);

            var N2 = N1;
            Console.WriteLine(N2);
            N2.X = -1 * N2.X;

            Console.WriteLine(N1);
            Console.WriteLine(N2);


            Console.ReadLine();
        }
    }
}
