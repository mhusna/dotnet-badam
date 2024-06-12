using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_III
{
    public class EmployeeManager
    {
        private static OracleConnection _connection;
        private string _connectionString;
        private static OracleCommand _oracleCommand;

        public EmployeeManager(string connectionString)
        {
            _connectionString = connectionString;
            _connection = new OracleConnection(_connectionString);
        }

        public List<Employee> GetAll()
        {
            _connection.Open();

            _oracleCommand = new OracleCommand("Select employee_id, first_name, last_name, Salary, department_id From Employees", _connection);
            OracleDataReader dr = _oracleCommand.ExecuteReader();

            List<Employee> employees = new List<Employee>();

            while (dr.Read())
            {
                Employee employee = new Employee();

                employee.Employee_ID = dr.GetInt32(0);
                employee.First_Name = dr.GetString(1);
                employee.Last_Name = dr["Last_Name"].ToString();
                employee.Salary = dr.GetDouble(3);
                employee.Department_ID = dr.IsDBNull(4) ? null : dr.GetInt16(4);
                //employee.Department_ID = dr.GetInt32(4);
                //employee.Department_ID = (int?)dr[4];

                employees.Add(employee);
            }

            _oracleCommand = null;
            _connection.Close();

            return employees;
        }

        public Employee GetById(int id)
        {
            _connection.Open();
            _oracleCommand = new OracleCommand("Select employee_id, first_name, last_name, salary, department_id From Employees where employee_id = :id", _connection);
            _oracleCommand.Parameters.Add(":id", id);
            OracleDataReader dr = _oracleCommand.ExecuteReader();
            Employee employee = new Employee();

            employee.Employee_ID = -1;
            dr.Read();
            if (dr.HasRows)
            {
                employee.Employee_ID = dr.GetInt32(0);
                employee.First_Name = dr.GetString(1);
                employee.Last_Name = dr["Last_Name"].ToString();
                employee.Salary = dr.GetDouble(3);
                employee.Department_ID = dr.IsDBNull(4) ? null : dr.GetInt16(4);
            }

            _oracleCommand = null;
            _connection.Close();

            return employee;
        }
    }
}
