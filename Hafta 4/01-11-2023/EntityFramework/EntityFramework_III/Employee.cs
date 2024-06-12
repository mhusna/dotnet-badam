using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_III
{
    public class Employee
    {
        public int Employee_ID { get; set; }
        public int? Department_ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"{Employee_ID} - {First_Name} - {Last_Name} - {Salary} - {Department_ID}";
        }
    }
}
