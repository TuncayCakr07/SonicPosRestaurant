﻿using SonicPosRestaurant.Business.Services.Base;
using SonicPosRestaurant.Entities.Dtos;
using SonicPosRestaurant.Entities.Dtos.Mutfak;
using SonicPosRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.Business.Services
{
    public interface IAdisyonService:IBaseService<Adisyon>
    {
        AdisyonToplamDto AdisyonToplamGetir();
        List<AdisyonHareketDto> AdisyonHareketGetir(DateTime tarih1,DateTime tarih2);
        List<MutfakAdisyonHareketDto> MutfakAdisyonHareketGetir();
        List<MutfakUrunHareketDto> MutfakUrunHareketGetir(Guid adisyonId);
        List<MutfakEkMalzemeDto> MutfakEkMalzemeHareketGetir(Guid urunHareketId);
    }
}
