using SonicPosRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.UserControls
{
    public class KullaniciKontrolEventArgs:EventArgs
    {
        public Kullanici Kullanici { get; set; }
    }
}
