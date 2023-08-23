using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    public struct Nokta
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"{X},{Y}";
        }

        public Nokta(int x ,int y)
        {
            X = x ;
            Y = y ;
        }

        public void SetOrigin()
        {
            this.X = 0;
            this.Y = 0;
        }

        public void Degistir()
        {
            var gecici = this.X;
            X = Y;
            Y = gecici;
        }
    }
}
