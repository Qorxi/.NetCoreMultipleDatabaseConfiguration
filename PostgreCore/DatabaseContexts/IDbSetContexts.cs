using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PostgreCore.Models;

namespace PostgreCore.DatabaseContexts
{
    public interface IDbSetContexts
    {
        DbSet<Employee> Employees { get; set; }

        DbSet<ProdSearchable> ProdSearchables { get; set; }
    }
}
