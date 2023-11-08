using SonicPosRestaurant.Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.Entities.Tables
{
    public class Adisyon:EntityBase
    {
        public decimal Indirim { get; set; }
        public decimal Tutar { get; set; }
        public Guid? MasaId { get; set; }
        public virtual Masa Masa { get; set; }
        public Guid GarsonId { get; set; }
        public virtual Garson Garson { get; set; }
        public virtual ICollection<UrunHareket> UrunHareketleri{ get; set; }
    }
}
