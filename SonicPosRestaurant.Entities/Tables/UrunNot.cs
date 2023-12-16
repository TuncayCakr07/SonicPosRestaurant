using SonicPosRestaurant.Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.Entities.Tables
{
    public class UrunNot:EntityBase
    {
        public Guid UrunId { get; set; }
        public string Notu { get; set; }
        public virtual Urun Urun { get; set; }
    }
}
