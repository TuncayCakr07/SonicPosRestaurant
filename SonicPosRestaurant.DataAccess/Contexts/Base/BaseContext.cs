using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.DataAccess.Contexts.Base
{
    public class BaseContext<TContext> : DbContext where TContext : DbContext, new()
    {
        private static string Connectionstring = "Data Source=(localdb)\\Tuncay;Initial Catalog=SonicPOS-Restaurant;Integrated Security=True";

        public BaseContext() : base(Connectionstring)
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public BaseContext(string connectionString) : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false;
        }
    }
}
