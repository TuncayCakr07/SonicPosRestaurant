﻿using DevExpress.Data.Entity;
using SonicPosRestaurant.Core.Functions;
using SonicPosRestaurant.UI.BackOffice.Garson;
using SonicPosRestaurant.UI.BackOffice.Masa;
using SonicPosRestaurant.UI.BackOffice.Musteri;
using SonicPosRestaurant.UI.BackOffice.Urun;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConnectionStringInfo = SonicPosRestaurant.Core.Functions.ConnectionStringInfo;

namespace SonicPosRestaurant.UI.BackOffice.AnaMenu
{
    public partial class FrmAnaMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
            if (!ConnectionStringInfo.Check())
            {
                FrmSetupConnection form= new FrmSetupConnection();
                form.ShowDialog();
            }
        }
        private void BtnUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUrun frm=new FrmUrun();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMusteri form= new FrmMusteri();
            form.MdiParent= this;
            form.Show();
        }

        private void btnMasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMasa form=new FrmMasa();
            form.MdiParent = this;
            form.Show();
        }

        private void btnGarson_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmGarson form= new FrmGarson();
            form.MdiParent= this;
            form.Show();
        }
    }
}
