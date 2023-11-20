using DevExpress.XtraEditors;
using SonicPosRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.UserControls
{
    public class ControlKategoriButton:CheckButton
    {
        public Guid Id { get; set; }
        public IEnumerable<Urun> Urunler { get; set; }
    }
}
