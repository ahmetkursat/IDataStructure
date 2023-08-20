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

            Ogrencı ogrencı = new Ogrencı();
            ogrencı.Numara = 10;
            ogrencı.Adi = "Ahmet";
            ogrencı.Soyadi = string.Empty;
            ogrencı.Cinsiyet = true;

            Console.WriteLine($"{ogrencı.Numara}+{ogrencı.Adi}+{ogrencı.Cinsiyet}");

            //Alternatif Kullanım

            var ogr2 = new Ogrencı()
            {
                Numara = 20,
                Adi = string.Empty,
                Soyadi = string.Empty,
                Cinsiyet = true

            };
            //2 alternatif kullanım 
            var ogr3 = new Ogrencı(30, "ahmet", "yıldız", true);
            var ogr4 = new Ogrencı(40, "amıde", "dasds");
            Console.WriteLine(ogr2);
            Console.WriteLine($"{ogr4.Numara}+{ogr4.Adi}+{ogr4.Cinsiyet}");


          



        Console.ReadKey();
        }
    }
}
