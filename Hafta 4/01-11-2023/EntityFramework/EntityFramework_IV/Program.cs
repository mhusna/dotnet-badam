using EntityFramework_IV.Models;

ModelContext context = new ModelContext();

foreach (var item in context.Employees)
{
    Console.WriteLine(item);
}