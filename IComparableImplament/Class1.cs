using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace IComparableImplament
{
    public interface ISehir
    {
        void Tanıt();
        void NufusBilgisiGetir(int plakano);
    }
    public class sehir : ISehir,IComparable<sehir>
    {
        public sehir(int plakaNo ,string sehirAdi)
        {
            PlakaNo = plakaNo;
            SehirAdi = sehirAdi;

        }
        public int PlakaNo { get; set; }

        public string SehirAdi { get; set; }

        public int CompareTo(sehir? other)
        {
            if (this.PlakaNo < other.PlakaNo)
            {
                return -1;
            }else if(this.PlakaNo == other.PlakaNo)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public void NufusBilgisiGetir(int plakano)
        {
            throw new NotImplementedException();
        }

        public void Tanıt()
        {
            throw new NotImplementedException();
        }

        public override string? ToString()
        {
            return $"{PlakaNo}"+$"{SehirAdi}";
        }
    }

    public class Class1
    {
        static void Main(string[] args)
        {
            //List
            var sayilar = new List<int>()
            {
                53,40,14,2,3,12,15
            };
            sayilar.Sort();
            sayilar.ForEach(s => Console.WriteLine(s));

            //Sehir Listesi

            var sehirler = new List<sehir>()
            {
                new sehir(6,"Ankara"),
                new sehir(34,"İstanbul"),
                new sehir(55,"Samsun"),
                new sehir(23,"Elazığ")
            };
            sehirler.Add(new sehir(1, "Adana"));
            sehirler.Sort();

            sehirler.ForEach(s => Console.WriteLine(s));

            


            Console.ReadKey();
        }
    }
}
