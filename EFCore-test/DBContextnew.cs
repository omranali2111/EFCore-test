using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCore_test
{
    internal class DBContextnew:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            options.UseSqlServer("Data Source=(local);Initial Catalog=EFCore1; Integrated Security=true; TrustServerCertificate=True");
        }
       public DbSet<Employee> employees { get; set; }

    }
}
