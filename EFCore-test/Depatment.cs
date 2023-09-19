using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_test
{
    internal class Depatment
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
