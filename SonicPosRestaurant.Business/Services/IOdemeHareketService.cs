using SonicPosRestaurant.Business.Services.Base;
using SonicPosRestaurant.Entities.Dtos;
using SonicPosRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.Business.Services
{
    public interface IOdemeHareketService:IBaseService<OdemeHareket>
    {
        IEnumerable<OdemeHareket> OdemeHareketListesiGetir(DateTime baslangicTarihi, DateTime bitisTarihi);
        List<HaftalikKazancDto> HaftalikKazanciGetir();
        List<AylikKazancDto> AylikKazanciGetir();
        List<YillikKazancDto> YillikKazanciGetir();
    }
}
