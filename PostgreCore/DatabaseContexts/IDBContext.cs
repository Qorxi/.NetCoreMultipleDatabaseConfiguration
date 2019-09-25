using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using PostgreCore.DatabaseContexts;
using PostgreCore.Models;

namespace PostgreCore.DataBaseContexts
{
    public partial interface IDbContext : IDbSetContexts, IDbContextChanges
    {
         DatabaseFacade DataBase { get;}
    }
}
