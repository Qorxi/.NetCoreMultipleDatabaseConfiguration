using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PostgreCore.Models
{
    [Table(name: "Employee")]

    public class Employee
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public int Age { get; set; }
    }
}
