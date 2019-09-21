using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PostgreCore.DatabaseContexts
{
    public interface IDbContextChanges
    {
        void SaveContextChanges();
    }
}
