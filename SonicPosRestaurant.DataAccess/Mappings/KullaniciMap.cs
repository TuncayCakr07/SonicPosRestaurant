using SonicPosRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.DataAccess.Mappings
{
    public class KullaniciMap:EntityTypeConfiguration<Kullanici>
    {
        public KullaniciMap()
        {
            Property(c => c.AdSoyad).HasMaxLength(80);
            Property(c => c.KullaniciAdi).HasMaxLength(30);
            Property(c => c.Parola).HasMaxLength(32);

            ToTable("Kullanicilar");
            Property(c => c.AdSoyad).HasColumnName("AdSoyad");
            Property(c => c.KullaniciAdi).HasColumnName("KullaniciAdi");
            Property(c => c.Parola).HasColumnName("Parola");
            Property(c => c.KullaniciRol).HasColumnName("KullaniciRol");
        }
    }
}
