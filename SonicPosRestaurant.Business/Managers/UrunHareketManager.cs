using SonicPosRestaurant.Business.Managers.Base;
using SonicPosRestaurant.Business.Services;
using SonicPosRestaurant.DataAccess.UnitOfWork;
using SonicPosRestaurant.Entities.Dtos;
using SonicPosRestaurant.Entities.Enums;
using SonicPosRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.Business.Managers
{
    public class UrunHareketManager : BaseManager<UrunHareket>, IUrunHareketService
    {
        RestaurantUnitOfWork _uow;
        public UrunHareketManager(IUnitOfWork uow) : base(uow)
        {
            _uow =(RestaurantUnitOfWork)uow;
        }

        public List<EnCokSatanUrunlerDto> EnCokSatanUrunleriGetir()
        {
            return _uow.UrunDal.Select(null, c => new EnCokSatanUrunlerDto
            {
                UrunAdi = c.Adi,
                AdetToplam = c.UrunHareketleri.Where(f => f.UrunHareketTip == UrunHareketTip.Satis).Sum(f =>(decimal?) f.Miktar)??0
            }, c => c.UrunHareketleri).OrderBy(c=>c.AdetToplam).Take(20).ToList();
        }

        public IEnumerable<UrunHareket> UrunHareketListesiGetir(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
          return  _uow.UrunHareketDal.GetList(c => DbFunctions.TruncateTime(c.EklenmeTarihi) >= baslangicTarihi.Date && DbFunctions.TruncateTime(c.EklenmeTarihi) <= bitisTarihi.Date, c => c.Porsiyon, c => c.Urun,c=>c.Porsiyon.Birim);
        }
    }
}
