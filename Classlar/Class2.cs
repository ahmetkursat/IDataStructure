using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Classlar.Class1;

namespace Classlar
{
    public class Class2
    {
        static void Main(string[] args)
        {
            var student = new List<OgrenciSistemi>{
                new OgrenciSistemi("Ahmet", "yıldız", 36, 'A', 12, true),
                new OgrenciSistemi("Hanife","Yıldız",12,'A',23,false)
            };

            foreach (var item in student)
            {
                Console.WriteLine(item);
            }


        }
    }
}
