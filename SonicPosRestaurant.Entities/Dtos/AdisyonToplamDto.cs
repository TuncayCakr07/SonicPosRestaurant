﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.Entities.Dtos
{
    public class AdisyonToplamDto
    {
        public decimal ToplamTutar { get; set; }
        public decimal IndirimTutar { get; set; }
        public decimal OdenecekTutar 
        { 
            get{  return ToplamTutar - IndirimTutar;} 
        }
    }
}
