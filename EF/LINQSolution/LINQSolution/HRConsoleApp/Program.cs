using HRConsoleApp.Context;
using HRConsoleApp.Repositories;
using HRConsoleApp.Repositories.Interfaces;


using (var context = new HRContext())
{
    IHRRepository repo = new HRRepository(context);
    var employees = repo.GetAll();
    foreach (var employee in employees)
    {
        Console.WriteLine(employee.FirstName + "  " + employee.LastName + "  " + employee.Contact);
    }
}