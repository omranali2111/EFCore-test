using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_test
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public Department department { get; set; }

       [ForeignKey("department")]
        public int dept_id { get; set; }


    }
}
