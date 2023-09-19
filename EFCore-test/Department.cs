using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_test
{
    internal class Department
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Employee> Employees { get; set; }

       

    }
}
