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
        //[Column("id")]
        public int Id { get; set; }

        //[Column("name")]
        public String Name { get; set; }

        //[Column("age")]
        public int Age { get; set; }
    }
}
