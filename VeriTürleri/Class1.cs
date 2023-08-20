using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriTürleri
{
    public class veri { 
    static void Main(string[] args)
    {
            //8-bit integer
            Console.WriteLine(nameof(SByte));
            Console.WriteLine($"Alt Limit           :{SByte.MinValue,20}");
            Console.WriteLine($"Üst Limit           :{SByte.MaxValue,20}");
            Console.WriteLine($"Boyut               :{sizeof(SByte),20}");


            // Unsigned 8-Bit intager
            Console.WriteLine(nameof(Byte));
            Console.WriteLine($"Alt Limit           :{Byte.MinValue,20}");
            Console.WriteLine($"Üst Limit           :{Byte.MaxValue,20}");
            Console.WriteLine($"Boyut               :{sizeof(Byte),20}");

            
            // signed 16-Bit intager
            Console.WriteLine(nameof(Int16));
            Console.WriteLine($"Alt Limit           :{Int16.MinValue,20}");
            Console.WriteLine($"Üst Limit           :{Int16.MaxValue,20}");
            Console.WriteLine($"Boyut               :{sizeof(Int16),20}");

            // signed 32-Bit intager
            Console.WriteLine(nameof(Int32));
            Console.WriteLine($"Alt Limit           :{Int32.MinValue,20}");
            Console.WriteLine($"Üst Limit           :{Int32.MaxValue,20}");
            Console.WriteLine($"Boyut               :{sizeof(Int32),20}");

            // signed 64-Bit intager
            Console.WriteLine(nameof(Int32));
            Console.WriteLine($"Alt Limit           :{Int64.MinValue,20}");
            Console.WriteLine($"Üst Limit           :{Int64.MaxValue,20}");
            Console.WriteLine($"Boyut               :{sizeof(Int64),20}");

            Console.WriteLine(nameof(Double));
            Console.WriteLine($"Alt Limit           :{Double.MinValue,20}");
            Console.WriteLine($"Üst Limit           :{Double.MaxValue,20}");
            Console.WriteLine($"Boyut               :{sizeof(Double),20}");

            Console.ReadKey();
        }
    }
}
