using EFCore_test;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        using (var dbContext = new DBContextnew())
        {
            //var newEmployee = new Employee
            //{
            //    Name = "omran",
            //    Salary = 1300
            //};
            //var newEmployee1 = new Employee
            //{
            //    Name = "ali",
            //    Salary = 1500
            //};

            // Add the new Employee object to the DbSet
            //dbContext.employees.Add(newEmployee);
            //dbContext.employees.Add(newEmployee1);

            // Save the changes to the database
            //dbContext.SaveChanges();

            Employee em1 = dbContext.employees.Where(x => x.Id == 1).FirstOrDefault();

            if (em1 != null)
            {
                Console.WriteLine("Employee found:");
                Console.WriteLine($"Name: {em1.Name}");
                Console.WriteLine($"Salary: {em1.Salary}");
            }
            else
            {
                Console.WriteLine("Employee with ID 1 not found.");
            }

            Employee em2 = dbContext.employees.First(x => x.Id == 4);

            if (em2 != null)
            {
                dbContext.employees.Remove(em2);
                dbContext.SaveChanges();
                Console.WriteLine("Employee removed successfully.");
            }
            else
            {
                Console.WriteLine("Employee with ID 4 or 3 not found.");
            }

            dbContext.SaveChanges();

        }

    }
}