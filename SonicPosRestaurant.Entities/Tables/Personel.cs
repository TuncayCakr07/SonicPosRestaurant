using SonicPosRestaurant.Entities.Enums;
using SonicPosRestaurant.Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.Entities.Tables
{
    public class Personel:EntityBase
    {
        public PersonelTipi PersonelTipi { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
