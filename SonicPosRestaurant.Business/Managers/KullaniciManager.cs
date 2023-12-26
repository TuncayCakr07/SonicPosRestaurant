using SonicPosRestaurant.Business.Managers.Base;
using SonicPosRestaurant.Business.Services;
using SonicPosRestaurant.DataAccess.UnitOfWork;
using SonicPosRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.Business.Managers
{
    public class KullaniciManager : BaseManager<Kullanici>, IKullaniciService
    {
        RestaurantUnitOfWork _uow;
        public KullaniciManager(IUnitOfWork uow) : base(uow)
        {
            _uow =(RestaurantUnitOfWork) uow;
        }

        public Kullanici KullaniciKontrol(string kullaniciAdi, string parola)
        {
           return _uow.KullaniciDal.Get(c=>c.KullaniciAdi==kullaniciAdi && c.Parola==parola);
        }
    }
}
