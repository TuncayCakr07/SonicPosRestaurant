using DevExpress.XtraEditors;
using SonicPosRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.UserControls
{
    public class ControlPorsiyonButton:SimpleButton
    {
        public Guid Id { get; set; }
        public string Adi { get; set; }
        public decimal Fiyat { get; set; }
        public decimal EkMalzemeCarpan { get; set; }
        public IEnumerable<EkMalzeme> EkMalzemeler { get; set; }
    }
}
