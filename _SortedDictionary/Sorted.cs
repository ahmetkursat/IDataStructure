using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _SortedDictionary
{
    public class Sorted
    {
        static void Main(string[] args)
        {

            var kitapIndex = new SortedDictionary<string, List<int>>()
            {
                {"HTLM",new List<int>(){8,10,12} },
                {"css",new List<int>(){70,80,90} },
                {"jquery",new List<int>(){3,5,15} },
                {"sql",new List<int>(){70,80} },
                

            };

            kitapIndex.Add("FTP", new List<int>() { 3, 5, 7 });
            kitapIndex.Add("Asp.net", new List<int>() { 50, 60 });

            foreach (var item in kitapIndex)
            {
                Console.WriteLine(item.Key);
                foreach (int s in item.Value){
                    Console.WriteLine($"\t > {s}");
                        }

            }



            Console.ReadKey();

        }
    }
}
