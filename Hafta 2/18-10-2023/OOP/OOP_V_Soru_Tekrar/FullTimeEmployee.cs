using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_V_Soru_Tekrar
{
    internal class FullTimeEmployee : Employee
    {
        public double NormalSalary { get; set; }

        public override double Salary
        {
            get
            {
                return NormalSalary + Prim;
            }
        }

        public override double Prim
        {
            get
            {
                if (SellCount > 0 && SellCount < 100_000)
                    return SellCount * 0.01;
                else if( SellCount >= 100_000 && SellCount < 250_000)
                    return SellCount * 0.02;
                else
                    return SellCount * 0.03;
            }
        }

        public override string GetInfo()
        {
            return $"{FirstName} {LastName} - {SellCount} - ({NormalSalary} + {Prim}): {Salary}";
        }
    }
}
