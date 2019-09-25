using PostgreCore.DatabaseContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostgreCore.Contexts.ContextManagment
{
    public class DbSetContextManager
    {
        private static object readObject = new object();

        private static IDbSetContexts _DatabaseContextList;

        private DbSetContextManager() { }


        public static void Register(IDbSetContexts manager)
        {
            _DatabaseContextList = manager;
        }

        public static IDbSetContexts GetDbSetContextFactory()
        {
            lock (readObject)
            {
                if (_DatabaseContextList == null)
                {
                    throw new Exception("Database manager configuration support class is not valid");
                }
                return _DatabaseContextList;
            }
        }
    }
}
