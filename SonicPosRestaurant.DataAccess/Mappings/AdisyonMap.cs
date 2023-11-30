using SonicPosRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.DataAccess.Mappings
{
    public class AdisyonMap:EntityTypeConfiguration<Adisyon>
    {
        public AdisyonMap()
        {
            Property(c => c.Indirim).HasPrecision(5, 2);
            Property(c=>c.Tutar).HasPrecision(10, 2);

            ToTable("Adisyonlar");
            Property(c => c.Tutar).HasColumnName("Tutar");
            Property(c => c.Indirim).HasColumnName("Indirim");
            Property(c => c.GarsonId).HasColumnName("GarsonId");
            Property(c => c.MasaId).HasColumnName("MasaId");
            Property(c => c.AdisyonAcik).HasColumnName("AdisyonAcik");
        }
    }
}
