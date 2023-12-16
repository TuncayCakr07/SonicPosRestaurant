using SonicPosRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.DataAccess.Mappings
{
    public class UrunNotMap:EntityTypeConfiguration<UrunNot>
    {
        public UrunNotMap()
        {
            Property(c=>c.Notu).HasMaxLength(255);

            ToTable("UrunNotlari");
            Property(c => c.Notu).HasColumnName("Notu");
            Property(c => c.UrunId).HasColumnName("UrunId");
        }
    }
}
