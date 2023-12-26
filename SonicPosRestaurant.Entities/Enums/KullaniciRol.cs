using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.Entities.Enums
{
    public enum KullaniciRol
    {
        [Description("Admin Kullanıcısı")]
        Admin,
        [Description("Personel Kullanıcısı")]
        Personel,
        [Description("Garson Kullanıcısı")]
        Garson,
        [Description("Mutfak Kullanıcısı")]
        Mutfak
    }
}
