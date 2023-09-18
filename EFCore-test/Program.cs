using EFCore_test;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        using (var dbContext = new DBContextnew())
        {
            var newEmployee = new Employee
            {
                Name = "omran",
                Salary = 1300
            };
            var newEmployee1 = new Employee
            {
                Name = "ali",
                Salary = 1500
            };

            // Add the new Employee object to the DbSet
            dbContext.employees.Add(newEmployee);
            dbContext.employees.Add(newEmployee1);

            // Save the changes to the database
            dbContext.SaveChanges();

          
        }

    }
}