﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.Entities.Enums
{
    public enum AdisyonDurum
    {
        [Description("Açık")]
        Acik,
        [Description("Kapalı")]
        Kapali,
        [Description("İptal")]
        Iptal
    }
}
