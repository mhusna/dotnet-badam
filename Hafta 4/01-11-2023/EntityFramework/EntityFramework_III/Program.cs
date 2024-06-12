using EntityFramework_III;
using Oracle.ManagedDataAccess.Client;
using System.Net;
using System.Security.Cryptography;

string connectionString = "User Id = hr; Password = HR; Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SID = oracl)))";

//OracleConnection connection = new OracleConnection(connectionString);
//connection.Open();

//OracleCommand command = new OracleCommand("Select * From Departments", connection);

//OracleDataReader dr = command.ExecuteReader();
//while (dr.Read())
//{
//	Console.WriteLine(dr[0] + " " + dr[1]);
//}

//connection.Close();

//-------------------------------------------------------------------------

EmployeeManager manager = new EmployeeManager(connectionString);
Yazdir(manager.GetAll());

void Yazdir(List<Employee> employees)
{
	foreach (Employee employee in employees)
		Console.WriteLine(employee);
}

//Console.WriteLine(manager.GetById(200));