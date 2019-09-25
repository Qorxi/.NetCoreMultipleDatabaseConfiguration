using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PostgreCore.DataBaseContexts;

namespace PostgreCore.Contexts.ContextManagment
{
    public class DatabaseContextManager
    {
        private static object readObject = new object();

        private static IDbContext _DatabaseManager;

        private static void Register(IDbContext manager)
        {
            _DatabaseManager = manager;
        }

        public static IDbContext GetDbManagerFactory()
        {
            lock (readObject)
            {
                if (_DatabaseManager == null)
                {
                    throw new Exception("Database manager configuration support class is not valid");
                }
                return _DatabaseManager;
            }
        }
    }
}
