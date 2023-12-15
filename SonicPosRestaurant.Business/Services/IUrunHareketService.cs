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
    public interface IUrunHareketService:IBaseService<UrunHareket>
    {
        IEnumerable<UrunHareket> UrunHareketListesiGetir(DateTime baslangicTarihi, DateTime bitisTarihi);
        List<EnCokSatanUrunlerDto> EnCokSatanUrunleriGetir();
    }
}
