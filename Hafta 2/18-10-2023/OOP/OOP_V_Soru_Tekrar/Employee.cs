using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_V_Soru_Tekrar
{
    internal abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public abstract double Salary { get; }
        public abstract double Prim { get; }
        public int SellCount { get; set; }

        public abstract string GetInfo();
    }
}
