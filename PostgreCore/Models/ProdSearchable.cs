using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PostgreCore.Models
{
    [Table(name:"ProdSearchable")]
    public class ProdSearchable
    {
        public int Id { get; set; }

        public string SearchColumn { get; set; }

    }
}
