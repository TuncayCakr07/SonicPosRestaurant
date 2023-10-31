using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.DataAccess.Contexts.Base
{
    public class BaseContext<TContext>:DbContext where TContext : DbContext,new()
    {
        private static string Connectionstring = "Tuncay";
        public BaseContext():base(Connectionstring)
        {
            
        }
        public BaseContext(string connectionString):base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false;
            Connectionstring = connectionString;
        }
    }
}
