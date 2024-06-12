using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_I
{
    internal class Ferrari : object, Araba
    {
        public override void Sur()
        {
            Console.WriteLine("Ferrari Sür");
        }

        public override string ToString()
        {
            return "Ferrari bilgileri...";
        }
    }
}
