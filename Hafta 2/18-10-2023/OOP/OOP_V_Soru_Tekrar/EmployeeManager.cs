using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_V_Soru_Tekrar
{
    internal static class EmployeeManager
    {
        static ArrayList employees = new ArrayList();

        public static void InsertEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public static ArrayList ListEmployees()
        {
            return employees;
        }
    }
}
