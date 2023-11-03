using SonicPosRestaurant.Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.DataAccess.Functions
{
    public static class EntityBaseInfo
    {
        public static void Add(DbContext context) 
        {
            var a = context.ChangeTracker.Entries();
            foreach (var entry in context.ChangeTracker.Entries())
            {
                EntityBase changingEntity=(EntityBase)entry.Entity;
                switch (entry.State)
                {
                    case EntityState.Added:
                        if (changingEntity.Id==Guid.Empty)
                        {
                            changingEntity.Id = Guid.NewGuid();
                        }
                        changingEntity.EklenmeTarihi=DateTime.Now;
                        changingEntity.Ekleyen = "Tuncay Çakıroğlu";
                        break;

                        case EntityState.Modified:
                            changingEntity.DuzenlenmeTarihi = DateTime.Now;
                            changingEntity.Duzenleyen = "Tuncay Çakıroğlu";
                        break;
                }
            }
        }
    }
}
