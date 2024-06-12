using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_VI
{
    internal struct Nokta
    {
        public int X { get; set; }
        public int Y { get; set; }

        /*
        public Nokta()
        {
            C# 11'den sonra destekleniyor.
        }
        */

        public Nokta()
        {
            X = 0;
            Y = 0;
        }

        public Nokta(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public string Point()
        {
            return $"P({X},{Y})";
        }
    }
}
