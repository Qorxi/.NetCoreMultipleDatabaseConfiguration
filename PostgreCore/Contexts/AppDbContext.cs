using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using PostgreCore.DataBaseContexts;
using PostgreCore.Models;

namespace PostgreCore.Contexts
{
    public abstract class AppDbContext : DbContext, PostgreCore.DataBaseContexts.IDBContext
    {
        protected AppDbContext(DbContextOptions options) : base(options)
        {
            this.DataBase = base.Database;
        }

        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<ProdSearchable> ProdSearchables { get; set; }

        public abstract void SaveContextChanges();

        public virtual DatabaseFacade DataBase { get; private set; }
    }
}
