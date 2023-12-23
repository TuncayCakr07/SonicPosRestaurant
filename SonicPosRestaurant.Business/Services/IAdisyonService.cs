using SonicPosRestaurant.Business.Services.Base;
using SonicPosRestaurant.Entities.Dtos;
using SonicPosRestaurant.Entities.Dtos.Mutfak;
using SonicPosRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.Business.Services
{
    public interface IAdisyonService:IBaseService<Adisyon>
    {
        AdisyonToplamDto AdisyonToplamGetir();
        List<AdisyonHareketDto> AdisyonHareketGetir(DateTime tarih1,DateTime tarih2);
        List<MutfakAdisyonHareketDto> MutfakAdisyonHareketGetir(Guid[] adisyonListe);
        List<MutfakUrunHareketDto> MutfakUrunHareketGetir(Expression<Func<UrunHareket,bool>> filter=null);
        List<MutfakEkMalzemeDto> MutfakEkMalzemeHareketGetir(Guid urunHareketId);
    }
}
