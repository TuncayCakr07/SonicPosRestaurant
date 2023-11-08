using SonicPosRestaurant.Entities.Tables;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.DataAccess.Mappings
{
    public class MasaMap:EntityTypeConfiguration<Masa>
    {
        public MasaMap()
        {
            Property(c=>c.Adi).HasMaxLength(50);
            HasRequired(c => c.Adisyon); 

            ToTable("Masalar");
            Property(c => c.Adi).HasColumnName("Adi");
            Property(c => c.Dolu).HasColumnName("Dolu");
            Property(c => c.AdisyonId).HasColumnName("AdisyonId");
            Property(c => c.KonumId).HasColumnName("KonumId");
        }
    }
}
