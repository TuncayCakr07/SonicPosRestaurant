using SonicPosRestaurant.DataAccess.Dals.Base;
using SonicPosRestaurant.DataAccess.Interfaces;
using SonicPosRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.DataAccess.Dals
{
    public class OdemeHareketDal : Repository<OdemeHareket>, IOdemeHareketDal
    {
        public OdemeHareketDal(DbContext context) : base(context)
        {
        }
    }
}
