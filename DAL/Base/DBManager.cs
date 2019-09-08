using Azami.Framework.DAL;

namespace Atarbashi.DAL.Base
{
    public class DBManager : DbContextManager
    {
        public DBManager() : base("name=ConnectionString") { }
    }
}
