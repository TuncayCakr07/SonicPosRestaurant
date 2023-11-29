using DevExpress.Data.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Layout;
using SonicPosRestaurant.Business.Workers;
using SonicPosRestaurant.Core.Extensions;
using SonicPosRestaurant.Entities.Dtos;
using SonicPosRestaurant.Entities.Enums;
using SonicPosRestaurant.Entities.Tables;
using SonicPosRestaurant.UserControls;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SonicPosRestaurant.UI.FrontOffice
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {

        enum KeyPadIslem
        {
            Yok,
            FiyatDegistir,
            Iade,
            Ikram,
            Bol,
            Indirim
        }

        RestaurantWorker worker=new RestaurantWorker();
        UrunHareket urunHareketEntity;
        private KeyPadIslem keyPadIslem=KeyPadIslem.Yok;
        public FrmMain()
        {
            InitializeComponent();
            KategoriButtonOlustur();
            gridControl1.DataSource = worker.UrunHareketService.BindingList();
            MasaButonOlustur();
        }

        void MasaButonOlustur()
        {
            foreach (var konum in worker.TanimService.GetList(c=>c.TanimTipi==TanimTip.Konum))
            {
                ControlKonumButton button = new ControlKonumButton
                {
                    Name=konum.Id.ToString(),   
                    Text=konum.Adi,
                    Height=88,
                    Width=150,
                    GroupIndex=1,
                    Masalar=worker.MasaService.GetList(c=>c.KonumId==konum.Id)
                };
                button.CheckedChanged += KonumSecim;
                flowKonum.Controls.Add(button);
            }
        }

        private void KonumSecim(object sender, EventArgs e)
        {
            ControlKonumButton button=(ControlKonumButton)sender;
            flowMasalar.Controls.Clear();
            foreach (var masa in button.Masalar)
            {
                SimpleButton masaButton = new SimpleButton
                {
                    Name=masa.Id.ToString(),
                    Text = masa.Adi,
                    Height=150,
                    Width=150,
                };
                flowMasalar.Controls.Add(masaButton);   
            }
        }

        void MiktarArttir(int sayi)
        {
            UrunHareket row=(UrunHareket)layoutView1.GetFocusedRow();
            if (row==null)
            {
                return;
            }
            if (sayi<0 && row.Miktar<=1)
            {
                return;
            }
            row.Miktar += sayi;
            layoutView1.RefreshData();
        }

        private void KategoriButtonOlustur()
        {
            foreach (var Kategori in worker.TanimService.Select(filter:c=> c.TanimTipi==TanimTip.UrunGrup,selector:c=>new KategoriDto { Id=c.Id,Adi=c.Adi}).ToList())
            {
                ControlKategoriButton button = new ControlKategoriButton
                {
                    Name = Kategori.Id.ToString(),
                    Text = Kategori.Adi,
                    Id = Kategori.Id,
                    Urunler = worker.UrunService.GetList(c => c.UrunGrupId == Kategori.Id,c=>c.Porsiyonlar,c=>c.EkMalzemeler),
                    GroupIndex = 1,
                    Height = 80,
                    Font = new Font("Century Gothic ",12,FontStyle.Bold),
                    Width = flowKategori.Width - 6
                };
                button.CheckedChanged += KategoriSecim;
                flowKategori.Controls.Add(button);
            }
        }

        private void KategoriSecim(object sender, EventArgs e)
        {
            flowKategoriUrunleri.Controls.Clear();
            ControlKategoriButton button = (ControlKategoriButton)sender;

            foreach (var item in button.Urunler)
            {
                ControlKategoriUrun urunButton = new ControlKategoriUrun
                {
                    Name = item.Id.ToString(),
                    UrunAdi = item.Adi,
                    Id=item.Id,
                    UrunImage = item.Fotograf.ByteArrayToImage(),
                    Height = 220,
                    Width = 300,
                    Aciklama = item.Aciklama,
                    Porsiyonlar = item.Porsiyonlar,
                    EkMalzemeler=item.EkMalzemeler,
                    
                };
                urunButton.ButtonClick += UrunClick;
                flowKategoriUrunleri.Controls.Add(urunButton);
            }

        }

        private void UrunClick(object sender, EventArgs e)
        {

            ControlKategoriUrun button=(ControlKategoriUrun)sender;
            if (!button.Porsiyonlar.Any())
            {
                MessageBox.Show("Bu Ürüne Ait Atanmış Bir Porsiyon Bilgisi Bulunamadı!");
                return;
            }
            btnKategoriyeDon.Visible = true;
            flowPorsiyon.Controls.Clear();
            urunHareketEntity = new UrunHareket();
            Adisyon entity = new Adisyon();
            entity.Id = Guid.NewGuid();
            worker.AdisyonService.Add(entity);
            urunHareketEntity.AdisyonId = entity.Id;
            urunHareketEntity.Id=Guid.NewGuid();
            urunHareketEntity.UrunId = button.Id;
            urunHareketEntity.Miktar = txtMiktar.Value;
            urunHareketEntity.UrunHareketTip = UrunHareketTip.Satis;
            navigationKategori.SelectedPage = PageUrunPorsiyon;
            foreach (var porsiyon in button.Porsiyonlar)
            {
                flowPorsiyon.Controls.Clear();
                ControlPorsiyonButton porsiyonButton = new ControlPorsiyonButton
                {
                  Name=porsiyon.Id.ToString(),
                  Text=porsiyon.Adi+System.Environment.NewLine+porsiyon.Fiyat.ToString("C2"),
                  Fiyat=porsiyon.Fiyat,
                  EkMalzemeCarpan=porsiyon.EkMalzemeCarpan,
                  Id=porsiyon.Id,
                  Height=200,
                  Width=200,
                  Font = new Font("Century Gothic ", 12, FontStyle.Bold),
                  EkMalzemeler=button.EkMalzemeler,
                };
                porsiyonButton.Click += PorsiyonClick;
                flowPorsiyon.Controls.Add(porsiyonButton);
            }
            if (button.Porsiyonlar.Count()==1)
            {
                ControlPorsiyonButton buttonPorsiyon = (ControlPorsiyonButton)flowPorsiyon.Controls[0];
                buttonPorsiyon.PerformClick();           
            }
        }

        private void PorsiyonClick(object sender, EventArgs e)
        {
            flowEkMalzeme.Controls.Clear();
            ControlPorsiyonButton button= (ControlPorsiyonButton)sender;

            urunHareketEntity.PorsiyonId = button.Id;
            urunHareketEntity.BirimFiyat = button.Fiyat;
            txtPorsiyonTutar.Value = button.Fiyat;
            if (!button.EkMalzemeler.Any())
            {
                UrunHareketEkle();
                navigationKategori.SelectedPage = PagesKategoriUrunler;
                return;
            }
            EkMalzemeButonOlustur(button.EkMalzemeCarpan,button.EkMalzemeler);

        }
        void EkMalzemeButonOlustur(decimal EkMalzemeCarpan,IEnumerable<EkMalzeme>EkMalzemeList)
        {


            foreach (var malzeme in EkMalzemeList)
            {
                ControlEkMalzemeButton MalzemeButton = new ControlEkMalzemeButton
                {
                    Name = malzeme.Id.ToString(),
                    Text = malzeme.Adi + System.Environment.NewLine + (malzeme.Fiyat * EkMalzemeCarpan).ToString("C2"),
                    Height = 200,
                    Width = 200,
                    Font = new Font("Century Gothic ", 12, FontStyle.Bold),
                    Id = malzeme.Id,
                    Fiyat = malzeme.Fiyat * EkMalzemeCarpan
                };
                MalzemeButton.CheckedChanged += MalzemeCheckChanged;
                flowEkMalzeme.Controls.Add(MalzemeButton);
            }
            navigationKategori.SelectedPage = PageEkMalzeme;

 
        }

        private void MalzemeCheckChanged(object sender, EventArgs e)
        {
            EkMalzemeHesapla();
        }

        private void btnEkMalzemeOnay_Click(object sender, EventArgs e)
        {
            foreach (ControlEkMalzemeButton button in flowEkMalzeme.Controls)
            {
                if (button.Checked)
                {
            
                    worker.EkMalzemeHareketService.AddOrUpdate(new EkMalzemeHareket
                    {
                        Id=Guid.NewGuid(),
                        UrunHareketId=urunHareketEntity.Id,
                        EkMalzemeId=button.Id,
                        Fiyat=button.Fiyat
                    });
                }
                else
                {
                    worker.EkMalzemeHareketService.EntityStateChange(c => c.UrunHareketId == urunHareketEntity.Id && c.EkMalzemeId == button.Id, EntityState.Deleted);
                }
            }
            EkMalzemeHesapla();
            urunHareketEntity.BirimFiyat = txtToplamTutar.Value;
            UrunHareketEkle();
            navigationKategori.SelectedPage = PagesKategoriUrunler;
        }
        void UrunHareketEkle()
        {
            btnKategoriyeDon.Visible = false;
            worker.UrunHareketService.AddOrUpdate(urunHareketEntity);
            worker.UrunService.Load(c => c.Id == urunHareketEntity.UrunId);
            worker.PorsiyonService.Load(c => c.Id == urunHareketEntity.PorsiyonId);
            Guid Id = urunHareketEntity.Porsiyon.BirimId;
            worker.TanimService.Load(c => c.Id == Id);
            layoutView1.RefreshData();
        }
        void EkMalzemeHesapla()
        {
            txtEkMalzemeTutar.Value = 0;
            foreach (ControlEkMalzemeButton button in flowEkMalzeme.Controls)
            {
                if (button.Checked)
                {
                    txtEkMalzemeTutar.Value += button.Fiyat;
                }
            }
            txtToplamTutar.Value = txtPorsiyonTutar.Value + txtEkMalzemeTutar.Value;

        }

        private void layoutView1_CustomCardStyle(object sender, DevExpress.XtraGrid.Views.Layout.Events.LayoutViewCardStyleEventArgs e)
        {
            LayoutView view = (LayoutView)sender;
            UrunHareket row = (UrunHareket)view.GetRow(e.RowHandle);
            if (view.FocusedRowHandle==e.RowHandle)
            {
                e.Appearance.BackColor = Color.DarkOliveGreen;
                return;
            }
            switch (row.UrunHareketTip)
            {
                case UrunHareketTip.Satis:
                    e.Appearance.BackColor= Color.Olive;
                    break;
                case UrunHareketTip.Iptal:
                    e.Appearance.BackColor = Color.Tomato;
                    break;
                case UrunHareketTip.Ikram:
                    e.Appearance.BackColor = Color.Maroon;
                    break;
            }
        }

        private void KeyPadSend(object sender, EventArgs e)
        {
            SimpleButton button= (SimpleButton)sender;
            txtMiktar.Focus();
            SendKeys.Send(button.Text);
        }

        private void btnKategoriyeDon_Click(object sender, EventArgs e)
        {
            navigationKategori.SelectedPage = PagesKategoriUrunler;
            btnKategoriyeDon.Visible = false;
        }

        private void btnMiktarArttir_Click(object sender, EventArgs e)
        {
            MiktarArttir(1);
        }

        private void btnFiyatDegistir_Click(object sender, EventArgs e)
        {
            if (layoutView1.GetFocusedRow()==null)
            {
                return;
            }
            keyPadIslem = KeyPadIslem.FiyatDegistir;
            txtMiktar.Text = null;
            txtMiktar.Properties.NullValuePrompt = "Lütfen Yeni Fiyat Giriniz!";
        }

        private void btnKeypadOk_Click(object sender, EventArgs e)
        {
            UrunHareket hareketEntity = (UrunHareket)layoutView1.GetFocusedRow();
            switch (keyPadIslem)
            {
                case KeyPadIslem.FiyatDegistir:
                    hareketEntity.BirimFiyat = txtMiktar.Value;
                    layoutView1.RefreshData();
                    break;
                case KeyPadIslem.Iade:
                    if (hareketEntity.Miktar==txtMiktar.Value)
                    {
                        hareketEntity.UrunHareketTip = UrunHareketTip.Iptal;
                    }
                    else if (hareketEntity.Miktar < txtMiktar.Value)
                    {
                        MessageBox.Show($"{hareketEntity.Miktar} Miktarından Daha Fazla İade Yapılamaz!","Uyarı!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        UrunHareket yeniEntity = hareketEntity.Clone();
                        yeniEntity.Id =Guid.NewGuid();
                        yeniEntity.UrunHareketTip = UrunHareketTip.Iptal;
                        yeniEntity.Miktar= txtMiktar.Value;
                        worker.UrunHareketService.Add(yeniEntity);
                        hareketEntity.Miktar -= txtMiktar.Value;
                    }
                    layoutView1.RefreshData();
                    break;
                case KeyPadIslem.Ikram:
                    if (hareketEntity.Miktar==txtMiktar.Value)
                    {
                        hareketEntity.UrunHareketTip = UrunHareketTip.Ikram;
                    }
                    else if (hareketEntity.Miktar < txtMiktar.Value)
                    {
                        MessageBox.Show($"{hareketEntity.Miktar} Miktarından Daha Fazla ikram Yapılamaz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        UrunHareket yeniEntity=hareketEntity.Clone();
                        yeniEntity.Id =Guid.NewGuid();
                        yeniEntity.UrunHareketTip = UrunHareketTip.Ikram;
                        yeniEntity.Miktar=txtMiktar.Value;
                        worker.UrunHareketService.AddOrUpdate(yeniEntity);
                        hareketEntity.Miktar -= txtMiktar.Value;
                    }
                    layoutView1.RefreshData();
                    break;
                case KeyPadIslem.Bol:
                    if (hareketEntity.Miktar == txtMiktar.Value)
                    {
                        MessageBox.Show("Miktar Alanıyla Yeni Girilen Alan Eşit Olamaz!");
                    }
                    else
                    {
                        UrunHareket yeniEntity = hareketEntity.Clone();
                        yeniEntity.Id = Guid.NewGuid();
                        yeniEntity.Miktar = txtMiktar.Value;
                        worker.UrunHareketService.AddOrUpdate(yeniEntity);
                        hareketEntity.Miktar -= txtMiktar.Value;
                    }
                    layoutView1.RefreshData();
                    break;
                case KeyPadIslem.Indirim:
                    if (txtMiktar.Value<0 || txtMiktar.Value>100)
                    {
                        MessageBox.Show("Girdiğiniz İndirim Oranı 0 İle 100 Arasında Olmalıdır.!","Uyarı!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        return;
                    }
                    hareketEntity.Indirim= txtMiktar.Value;
                    layoutView1.RefreshData();
                    break;
            }
            keyPadIslem = KeyPadIslem.Yok;
        }

        private void btnIkram_Click(object sender, EventArgs e)
        {
            if (layoutView1.GetFocusedRow() == null) return;
            UrunHareket hareketEntity = (UrunHareket)layoutView1.GetFocusedRow();
            if (hareketEntity.Miktar==1)
            {
                hareketEntity.UrunHareketTip = UrunHareketTip.Ikram;
                layoutView1.RefreshData();
            }
            else
            {
                keyPadIslem = KeyPadIslem.Ikram;
                txtMiktar.Text = null;
                txtMiktar.Properties.NullValuePrompt = "Lüften İkram Edilecek Miktarı Giriniz!";
            }
        }


        private void btnEkMalzeme_Click(object sender, EventArgs e)
        {
            if (layoutView1.GetFocusedRow()==null)
            {
                return;
            }
            flowEkMalzeme.Controls.Clear();
            urunHareketEntity = (UrunHareket)layoutView1.GetFocusedRow();
            Porsiyon porsiyonEntity = worker.PorsiyonService.Get(c => c.Id == urunHareketEntity.PorsiyonId);
            IEnumerable<EkMalzeme> ekMalzemeList = worker.EkMalzemeService.GetList(c => c.UrunId == urunHareketEntity.UrunId);
            EkMalzemeButonOlustur(porsiyonEntity.EkMalzemeCarpan, ekMalzemeList);
            List<EkMalzemeHareket> HareketList=worker.EkMalzemeHareketService.BindingList().ToList();
            foreach (var hareket in HareketList.Where(c=>c.UrunHareketId==urunHareketEntity.Id).ToList())
            {
                ControlEkMalzemeButton button = (ControlEkMalzemeButton)flowEkMalzeme.Controls.Find(hareket.EkMalzemeId.ToString(),true)[0];
                button.Checked = true;
            }
  
        }

        private void btnIndirim_Click(object sender, EventArgs e)
        {
            UrunHareket entity= (UrunHareket)layoutView1.GetFocusedRow();
            if (entity==null)
            {
                return;
            }
            keyPadIslem = KeyPadIslem.Indirim;
            txtMiktar.Text = null;
            txtMiktar.Properties.NullValuePrompt = "Lütfen İndirim Oranını Giriniz!";
        }

        private void btnIade_Click(object sender, EventArgs e)
        {
            if (layoutView1.GetFocusedRow() == null) return;
            UrunHareket hareketEntity = (UrunHareket)layoutView1.GetFocusedRow();

            if (hareketEntity.UrunHareketTip == UrunHareketTip.Iptal)
            {
                layoutView1.RefreshData();
                MessageBox.Show("Seçtiğiniz Ürünün Durumu Zaten İade Edilmiş!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (hareketEntity.Miktar == 1)
            {
                hareketEntity.UrunHareketTip = UrunHareketTip.Iptal;
                layoutView1.RefreshData();
            }
            else
            {
                keyPadIslem = KeyPadIslem.Iade;
                txtMiktar.Properties.NullValuePrompt = "Lütfen İade Edilecek Miktarı Giriniz!";
            }
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            if (layoutView1.GetFocusedRow() == null) return;
            UrunHareket hareketEntity = (UrunHareket)layoutView1.GetFocusedRow();
            if (hareketEntity.Miktar == 1)
            {
                MessageBox.Show("Miktarınız Bölünmeye Uygun Değildir!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                keyPadIslem = KeyPadIslem.Bol;
                txtMiktar.Properties.NullValuePrompt = "Lütfen Bölünecek Miktarı Giriniz!";
            }
        }

        private void btnMiktarAzalt_Click(object sender, EventArgs e)
        {
            MiktarArttir(-1);
        }
    }
}
