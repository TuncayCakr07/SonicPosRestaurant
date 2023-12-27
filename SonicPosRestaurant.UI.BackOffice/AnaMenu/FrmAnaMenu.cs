using DevExpress.Data.Entity;
using SonicPosRestaurant.Core.Functions;
using SonicPosRestaurant.UI.BackOffice.Adisyon;
using SonicPosRestaurant.UI.BackOffice.Araclar;
using SonicPosRestaurant.UI.BackOffice.Garson;
using SonicPosRestaurant.UI.BackOffice.Kullanici;
using SonicPosRestaurant.UI.BackOffice.Masa;
using SonicPosRestaurant.UI.BackOffice.Musteri;
using SonicPosRestaurant.UI.BackOffice.OdemeTuru;
using SonicPosRestaurant.UI.BackOffice.Urun;
using SonicPosRestaurant.UI.BackOffice.UrunHareket;
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
            FrmAnaMenuBilgi formBilgi=new FrmAnaMenuBilgi();
            formBilgi.MdiParent = this;
            formBilgi.Show();
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

        private void btnOdemeTur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmOdemeTuru form= new FrmOdemeTuru();
            form.MdiParent= this;
            form.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAdisyonHareket form=new FrmAdisyonHareket();
            form.MdiParent= this;
            form.Show();
        }

        private void btnUrunHareket_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUrunHareket form = new FrmUrunHareket();
            form.MdiParent= this;
            form.Show();
        }

        private void btnOdemeHareketleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmOdemeHareketleri form=new FrmOdemeHareketleri();
            form.MdiParent= this;
            form.Show();
        }

        private void btnKullanicilar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKullanicilar form=new FrmKullanicilar();
            form.ShowDialog();
        }

        private void btnYardim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmYardim form=new FrmYardim();
            form.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmHakkinda form=new FrmHakkinda();
            form.ShowDialog();
        }

        private void btnYedekleme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmYedek form=new FrmYedek();
            form.ShowDialog();
        }
    }
}
