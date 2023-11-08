using SonicPosRestaurant.Business.Managers.Base;
using SonicPosRestaurant.Business.Services;
using SonicPosRestaurant.DataAccess.UnitOfWork;
using SonicPosRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.Business.Managers
{
    public class UrunHareketManager : BaseManager<UrunHareket>, IUrunHareketService
    {
        public UrunHareketManager(IUnitOfWork uow) : base(uow)
        {
        }
    }
}
