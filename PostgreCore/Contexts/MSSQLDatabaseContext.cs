using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PostgreCore.Contexts
{
    public sealed class MSSQLDatabaseContext : AppDbContext
    {
        public MSSQLDatabaseContext(DbContextOptions<MSSQLDatabaseContext> options) : base(options)
        {

        }

        public override void SaveContextChanges()
        {
            base.SaveChanges();
        }
    }
}
