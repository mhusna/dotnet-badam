using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_V_Soru_Tekrar
{
    internal class PartTimeEmployee : Employee
    {
        public int WorkHour { get; set; }
        public double PerHourSalary { get; set; }
        public override double Salary
        {
            get
            {
                return (WorkHour * PerHourSalary) + Prim;
            }
        }

        public override double Prim
        {
            get
            {
                return SellCount * 0.01;
            }
        }

        public override string GetInfo()
        {
            return $"{FirstName} {LastName} - ({WorkHour} * {PerHourSalary}) + {Prim}: {Salary}";
        }
    }
}
