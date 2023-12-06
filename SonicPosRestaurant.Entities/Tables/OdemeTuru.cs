using SonicPosRestaurant.Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.Entities.Tables
{
    public class OdemeTuru:EntityBase
    {
        public string Adi { get; set; }
        public Guid OdemeTurId { get; set; }
        public Tanim OdemeTur { get; set; }
        public virtual ICollection<OdemeHareket> OdemeHareketleri { get; set; }
    }
}
