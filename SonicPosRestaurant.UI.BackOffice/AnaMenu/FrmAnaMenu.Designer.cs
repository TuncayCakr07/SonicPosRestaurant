namespace SonicPosRestaurant.UI.BackOffice.AnaMenu
{
    partial class FrmAnaMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaMenu));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnUrun = new DevExpress.XtraBars.BarButtonItem();
            this.btnMusteri = new DevExpress.XtraBars.BarButtonItem();
            this.btnMasa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGarson = new DevExpress.XtraBars.BarButtonItem();
            this.btnOdemeTur = new DevExpress.XtraBars.BarButtonItem();
            this.btnUrunHareket = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnOdemeHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.skinPaletteRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnKullanicilar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 37, 35, 37);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.BtnUrun,
            this.btnMusteri,
            this.btnMasa,
            this.btnGarson,
            this.btnOdemeTur,
            this.btnUrunHareket,
            this.barButtonItem2,
            this.btnOdemeHareketleri,
            this.barButtonItem4,
            this.skinPaletteRibbonGalleryBarItem1,
            this.barButtonItem1,
            this.btnKullanicilar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 385;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1312, 193);
            // 
            // BtnUrun
            // 
            this.BtnUrun.Caption = "Ürünler";
            this.BtnUrun.Id = 1;
            this.BtnUrun.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUrun.ImageOptions.Image")));
            this.BtnUrun.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnUrun.ImageOptions.LargeImage")));
            this.BtnUrun.Name = "BtnUrun";
            this.BtnUrun.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnUrun_ItemClick);
            // 
            // btnMusteri
            // 
            this.btnMusteri.Caption = "Müşteriler";
            this.btnMusteri.Id = 2;
            this.btnMusteri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteri.ImageOptions.Image")));
            this.btnMusteri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMusteri.ImageOptions.LargeImage")));
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnMasa
            // 
            this.btnMasa.Caption = "Masalar";
            this.btnMasa.Id = 3;
            this.btnMasa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMasa.ImageOptions.LargeImage")));
            this.btnMasa.Name = "btnMasa";
            this.btnMasa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMasa_ItemClick);
            // 
            // btnGarson
            // 
            this.btnGarson.Caption = "Personel ";
            this.btnGarson.Id = 4;
            this.btnGarson.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGarson.ImageOptions.LargeImage")));
            this.btnGarson.Name = "btnGarson";
            this.btnGarson.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGarson_ItemClick);
            // 
            // btnOdemeTur
            // 
            this.btnOdemeTur.Caption = "Ödeme Türleri";
            this.btnOdemeTur.Id = 5;
            this.btnOdemeTur.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnOdemeTur.ImageOptions.LargeImage")));
            this.btnOdemeTur.Name = "btnOdemeTur";
            this.btnOdemeTur.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOdemeTur_ItemClick);
            // 
            // btnUrunHareket
            // 
            this.btnUrunHareket.Caption = "Ürün Hareketleri";
            this.btnUrunHareket.Id = 6;
            this.btnUrunHareket.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUrunHareket.ImageOptions.LargeImage")));
            this.btnUrunHareket.Name = "btnUrunHareket";
            this.btnUrunHareket.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUrunHareket_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Adisyon Hareketleri";
            this.barButtonItem2.Id = 7;
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btnOdemeHareketleri
            // 
            this.btnOdemeHareketleri.Caption = "Ödeme Hareketleri";
            this.btnOdemeHareketleri.Id = 8;
            this.btnOdemeHareketleri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnOdemeHareketleri.ImageOptions.LargeImage")));
            this.btnOdemeHareketleri.Name = "btnOdemeHareketleri";
            this.btnOdemeHareketleri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOdemeHareketleri_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Hakkında ";
            this.barButtonItem4.Id = 9;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // skinPaletteRibbonGalleryBarItem1
            // 
            this.skinPaletteRibbonGalleryBarItem1.Caption = "Temalar";
            this.skinPaletteRibbonGalleryBarItem1.Id = 10;
            this.skinPaletteRibbonGalleryBarItem1.Name = "skinPaletteRibbonGalleryBarItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 13;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnKullanicilar
            // 
            this.btnKullanicilar.Caption = "Kullanıcılar";
            this.btnKullanicilar.Id = 12;
            this.btnKullanicilar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKullanicilar.ImageOptions.Image")));
            this.btnKullanicilar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKullanicilar.ImageOptions.LargeImage")));
            this.btnKullanicilar.Name = "btnKullanicilar";
            this.btnKullanicilar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKullanicilar_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Restaurant";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnUrun);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMusteri);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMasa);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGarson);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnOdemeTur);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Kayıtlar";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnUrunHareket);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnOdemeHareketleri);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Hareketler";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnKullanicilar);
            this.ribbonPageGroup3.ItemLinks.Add(this.skinPaletteRibbonGalleryBarItem1);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Diğer";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 756);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FrmAnaMenu.IconOptions.Image")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAnaMenu";
            this.Ribbon = this.ribbonControl1;
            this.Text = "SonicPos Cafe-Restaurant Otomasyonu-Ana Menü";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem BtnUrun;
        private DevExpress.XtraBars.BarButtonItem btnMusteri;
        private DevExpress.XtraBars.BarButtonItem btnMasa;
        private DevExpress.XtraBars.BarButtonItem btnGarson;
        private DevExpress.XtraBars.BarButtonItem btnOdemeTur;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnUrunHareket;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnOdemeHareketleri;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnKullanicilar;
    }
}

