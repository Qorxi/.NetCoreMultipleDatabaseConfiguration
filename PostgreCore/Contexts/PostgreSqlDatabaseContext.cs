using Microsoft.EntityFrameworkCore;
using PostgreCore.DataBaseContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PostgreCore.Models;

namespace PostgreCore.Contexts
{
    public class PostgreSqlDatabaseContext : AppDbContext, IDbContext
    {
        public PostgreSqlDatabaseContext(DbContextOptions<PostgreSqlDatabaseContext> options) : base(options)
        {

        }

        protected sealed override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProdSearchable>().ToTable("ProdSearchable", "dictionaries");
        }

        public override void SaveContextChanges()
        {
            base.SaveChanges();
        }
    }
}
