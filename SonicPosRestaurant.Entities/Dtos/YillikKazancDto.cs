using SonicPosRestaurant.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.Entities.Dtos
{
    public class YillikKazancDto
    {
        public Aylar Ay { get; set; }
        public decimal ToplamKazanc { get; set; }
    }
}
