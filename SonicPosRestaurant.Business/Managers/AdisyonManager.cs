using SonicPosRestaurant.Business.Managers.Base;
using SonicPosRestaurant.Business.Services;
using SonicPosRestaurant.DataAccess.UnitOfWork;
using SonicPosRestaurant.Entities.Dtos;
using SonicPosRestaurant.Entities.Enums;
using SonicPosRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.Business.Managers
{
    public class AdisyonManager : BaseManager<Adisyon>, IAdisyonService
    {
        private RestaurantUnitOfWork _uow;
        public AdisyonManager(IUnitOfWork uow) : base(uow)
        {
            _uow = (RestaurantUnitOfWork)uow;
        }

        public AdisyonToplamDto AdisyonToplamGetir()
        {
          return _uow.AdisyonDal.BindingList().Select(c=>new AdisyonToplamDto
          {
              ToplamTutar=c.UrunHareketleri.Where(f=>f.UrunHareketTip==UrunHareketTip.Satis).Sum(f=>f.ToplamTutar),
              IndirimTutar=c.UrunHareketleri.Where(f=>f.UrunHareketTip==UrunHareketTip.Satis).Sum(f=>f.ToplamTutar/100*f.Indirim),
          }).FirstOrDefault();
        }
    }
}
