using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicoCsharp
{
    public class Rectangulo
    {
        public int x1 { get; set; }
        public int y1 { get; set; }

        public int x2 { get; set; }
        public int y2 { get; set; }

        public int x3 { get; set; }
        public int y3 { get; set; }

        public int x4 { get; set; }
        public int y4 { get; set; }

        public int HallarArea()
        {
            int base1 = Math.Abs((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            int altura1 = Math.Abs;
           
            return base1*altura1;
        }

        public int HallarPerimetro( )
        {
            int base1 =;
            int altura1 =;

            return (base1 + altura1) ^ 2;

        }

    }
}
