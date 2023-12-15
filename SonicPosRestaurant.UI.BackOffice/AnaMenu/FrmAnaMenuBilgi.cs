﻿using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using SonicPosRestaurant.Business.Workers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicPosRestaurant.UI.BackOffice.AnaMenu
{
    public partial class FrmAnaMenuBilgi : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker=new RestaurantWorker();
        public FrmAnaMenuBilgi()
        {
            InitializeComponent();
            chartEnCokSatanUrunler.Series[0].DataSource = worker.UrunHareketService.EnCokSatanUrunleriGetir();
            chartEnCokSatanUrunler.Series[0].ArgumentDataMember = "UrunAdi";
            chartEnCokSatanUrunler.Series[0].ValueScaleType=ScaleType.Numerical;
            chartEnCokSatanUrunler.Series[0].ValueDataMembers.AddRange(new[] {"AdetToplam"});


            chartHaftalikKazanc.Series[0].DataSource= worker.OdemeHareketService.HaftalikKazanciGetir();
            chartHaftalikKazanc.Series[0].ArgumentDataMember = "Gun";
            chartHaftalikKazanc.Series[0].ValueDataMembers.AddRange(new[] { "ToplamKazanc" });

            chartAylikKazanc.Series[0].DataSource = worker.OdemeHareketService.AylikKazanciGetir();
            chartAylikKazanc.Series[0].ArgumentDataMember = "Tarih";
            chartAylikKazanc.Series[0].ValueDataMembers.AddRange(new[] { "ToplamKazanc" });

            chartYillikKazanc.Series[0].DataSource = worker.OdemeHareketService.YillikKazanciGetir();
            chartYillikKazanc.Series[0].ArgumentDataMember = "Ay";
            chartYillikKazanc.Series[0].ValueDataMembers.AddRange(new[] { "ToplamKazanc" });
        }
    }
}