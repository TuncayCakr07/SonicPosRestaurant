using SonicPosRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.DataAccess.Mappings
{
    public class PersonelMap:EntityTypeConfiguration<Personel>
    {
        public PersonelMap()
        {
            Property(c=>c.Adi).HasMaxLength(50);
            Property(c=>c.Soyadi).HasMaxLength(50);

            ToTable("Personeller");
            Property(c => c.Adi).HasColumnName("Adi");
            Property(c => c.Soyadi).HasColumnName("Soyadi");
            Property(c => c.PersonelTipi).HasColumnName("PersonelTipi");
        }
    }
}
