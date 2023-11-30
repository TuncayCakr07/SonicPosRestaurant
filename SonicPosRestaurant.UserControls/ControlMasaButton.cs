using DevExpress.XtraEditors;
using SonicPosRestaurant.Entities.Enums;
using SonicPosRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.UserControls
{
    public class ControlMasaButton:SimpleButton
    {
        private MasaDurum _masaDurum;
        public ControlMasaButton()
        {
            MasaDurum = MasaDurum.Bos;
        }
        public MasaDurum MasaDurum 
        { get {return _masaDurum;}
            set
            {
              _masaDurum = value;
                switch (_masaDurum)
                {
                    case MasaDurum.Bos:
                        Appearance.BackColor = Color.GreenYellow;
                        break;
                    case MasaDurum.Dolu:
                        Appearance.BackColor = Color.OrangeRed;
                        break;
                    case MasaDurum.Rezervasyon:
                        Appearance.BackColor = Color.DodgerBlue;
                        break;
                    default:
                        break;
                }
            } }
        public Guid AdisyonId { get; set; }
        public Guid MasaId { get; set; }

    }
}
