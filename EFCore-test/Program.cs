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
            //    Salary = 1300,
            //    dept_id = 1
            //};

            //var newEmployee1 = new Employee
            //{
            //    Name = "ali",
            //    Salary = 1500,
            //    dept_id = 2
            //};

            //// Add the new Employee objects to the DbSet
            //dbContext.employees.Add(newEmployee);
            //dbContext.employees.Add(newEmployee1);

            //// Save the changes to the database
            //dbContext.SaveChanges();

            Console.WriteLine("Employees inserted successfully.");
            //Employee em1 = dbContext.employees.Where(x => x.Id == 1).FirstOrDefault();

            //if (em1 != null)
            //{
            //    Console.WriteLine("Employee found:");
            //    Console.WriteLine($"Name: {em1.Name}");
            //    Console.WriteLine($"Salary: {em1.Salary}");
            //}
            //else
            //{
            //    Console.WriteLine("Employee with ID 1 not found.");
            //}

            //Employee em2 = dbContext.employees.First(x => x.Id == 4);

            //if (em2 != null)
            //{
            //    dbContext.employees.Remove(em2);
            //    dbContext.SaveChanges();
            //    Console.WriteLine("Employee removed successfully.");
            //}
            //else
            //{
            //    Console.WriteLine("Employee with ID 4 or 3 not found.");
            //}
            //Employee emp3 = dbContext.employees.FirstOrDefault(x => x.Id == 1);
            //if (emp3 != null)
            //{
            //    emp3.Salary = 3000;
            //    dbContext.employees.Update(emp3);
            //    dbContext.SaveChanges();
            //}
            //else
            //{
            //    Console.WriteLine("user not found");
            //}


            // Create a new Department object
            var newDepartment1 = new Department
                {
                    Name = "IT",
                    Description = "IT computer department"
                };
            var newDepartment2 = new Department
            {
                Name = "engineering",
                Description = "engineering department"
            };

            // Add the new Department object to the DbSet
            //dbContext.departments.Add(newDepartment1);
            //dbContext.departments.Add(newDepartment2);

            //// Save the changes to the database
            //dbContext.SaveChanges();

            //    Console.WriteLine("Department inserted successfully.");

            var query = from employee in dbContext.employees
                        join department in dbContext.departments
                        on employee.dept_id equals department.id
                        select new
                        {
                            EmployeeName = employee.Name,
                            DepartmentName = department.Name
                        };
           

            foreach (var result in query)
            {
                Console.WriteLine($"Employee Name: {result.EmployeeName}, Department Name: {result.DepartmentName}");
            }

        }

    }
}