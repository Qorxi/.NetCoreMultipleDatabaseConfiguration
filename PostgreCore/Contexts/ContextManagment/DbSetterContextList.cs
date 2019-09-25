using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PostgreCore.Models;

namespace PostgreCore.DatabaseContexts
{
    public partial class DbSetterContextList : IDbSetContexts
    {
        public DbSetterContextList()
        {

        }

        // Factory method
        public static IDbSetContexts GetInstance()
        {
            return new DbSetterContextList();
        }

        public DbSet<Employee> Employees { get ; set ; }
        public DbSet<ProdSearchable> ProdSearchables { get ; set ; }
    }
}
