using DevExpress.Data.Helpers;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraPrinting.Native;
using SonicPosRestaurant.Business.Workers;
using SonicPosRestaurant.Core.Extensions;
using SonicPosRestaurant.Core.Monitors;
using SonicPosRestaurant.Entities.Dtos;
using SonicPosRestaurant.Entities.Enums;
using SonicPosRestaurant.Entities.Tables;
using SonicPosRestaurant.UserControls;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraEditors.RoundedSkinPanel;

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
            Indirim,
            OdemeBol
        }

        RestaurantWorker worker = new RestaurantWorker();
        UrunHareket urunHareketEntity;
        private Adisyon secilenAdisyon;
        private Masa secilenMasa;
        private KeyPadIslem keyPadIslem = KeyPadIslem.Yok;
        private SqlMonitor<UrunHareket> urunHareketMonitor = new SqlMonitor<UrunHareket>("UrunHareketleri", c => c.SiparisDurum == SiparisDurum.ServiseHazir,TableDependency.SqlClient.Base.Enums.DmlTriggerType.All);
        public FrmMain()
        {
            InitializeComponent();
            KategoriButtonOlustur();
            MasaButonOlustur();
            SiparisButtonOlustur();
            MusteriButtonOlustur();
            OdemeTuruButtonOlustur();
            urunHareketMonitor.OnChange += UrunHareketChanged;
            controlKullaniciGiris1.KapatButton += KullaniciGirisKapat;
            controlKullaniciGiris1.KullaniciKontrolEvent += KullaniciGirisButonu;
        }

        private void KullaniciGirisButonu(object sender, KullaniciKontrolEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (e.Kullanici == null)
                {
                    MessageBox.Show("Girilen Kullanıcı Bilgileri Hatalıdır!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Kullanıcı Girişi Başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    navigationMain.SelectedPage = PageMasalar;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void KullaniciGirisKapat()
        {
           Application.Exit();
        }

        private void UrunHareketChanged()
        {
            Invoke((MethodInvoker)delegate
            {
                controlBadgeButton1.Count++;
                gridControlBildirim.DataSource = worker.AdisyonService.MutfakUrunHareketGetir(c => c.SiparisDurum == SiparisDurum.ServiseHazir && DbFunctions.TruncateTime(c.EklenmeTarihi)==DateTime.Now.Date);
            });
        }

        void OdemeTuruButtonOlustur()
        {
            foreach (var odemeTuru in worker.OdemeTuruService.GetList(null))
            {
                ControlOdemeTuruButton button = new ControlOdemeTuruButton
                {
                    Name = odemeTuru.Id.ToString(),
                    Text = odemeTuru.Adi,
                    OdemeTuruId = odemeTuru.Id,
                    Height = 75,
                    Width = 125,
                    Font = new Font("Century Gothic ", 10, FontStyle.Bold),
                    Appearance = { TextOptions = { WordWrap = WordWrap.Wrap } }
                };
                button.Click += OdemeButtonClick;
                flowOdemeTurleri.Controls.Add(button);
            }
        }

        private void OdemeButtonClick(object sender, EventArgs e)
        {
            ControlOdemeTuruButton button = (ControlOdemeTuruButton)sender;
            if (txtKalanTutar.Value == 0)
            {
                return;
            }
            if (txtOdemeTutari.Value <= 0)
            {
                return;
            }
            worker.OdemeTuruService.Load(c => c.Id == button.OdemeTuruId);
            worker.OdemeHareketService.AddOrUpdate(new OdemeHareket
            {
                AdisyonId = secilenAdisyon.Id,
                OdemeTuruId = button.OdemeTuruId,
                Tutar = txtOdemeTutari.Value,
            });
            UrunHareketToplamGetir();
            txtOdemeTutari.Value = 0;
            if (txtKalanTutar.Value<0)
            {
              lblMesaj.Visible = true;
              lblMesaj.Text=($"Müşteriye Ödenecek Para Üstü{Math.Abs(txtKalanTutar.Value).ToString("C2")}'dir.");
            }
        }

        void MusteriButtonOlustur()
        {
            foreach (var musteri in worker.MusteriService.GetList(null))
            {
                ControlMusteriButton button = new ControlMusteriButton
                {
                    Name = musteri.Id.ToString(),
                    Adi = musteri.Adi,
                    Soyadi = musteri.Soyadi,
                    MusteriId = musteri.Id,
                    MusteriTip = musteri.MusteriTip,
                    Height = 150,
                    Width = 150,
                    Font = new Font("Century Gothic ", 10, FontStyle.Bold)
                };
                button.Load();
                button.Click += MusteriSec;
                flowMusteri.Controls.Add(button);
            }
        }

        private void MusteriSec(object sender, EventArgs e)
        {
            ControlMusteriButton button = (ControlMusteriButton)sender;
            btnMusteri.MusteriId = button.MusteriId;
            btnMusteri.Adi = button.Adi;
            btnMusteri.Soyadi = button.Soyadi;
            btnMusteri.MusteriTip = button.MusteriTip;
            btnMusteri.Load();
            navigationKategori.SelectedPage = PagesKategoriUrunler;
        }

        void GarsonButtonOlustur(PersonelTipi personelTipi)
        {
            foreach (var garson in worker.GarsonService.GetList(c=>c.PersonelTipi==personelTipi))
            {
                flowGarson.Controls.Clear();
                ControlGarsonCheckButton button = new ControlGarsonCheckButton
                {
                    Name = garson.Id.ToString(),
                    Text = $"{garson.Adi} {garson.Soyadi}",
                    Height = 150,
                    Width = 150,
                    Font = new Font("Century Gothic ", 12, FontStyle.Bold),
                    GroupIndex = 1,
                    GarsonId = garson.Id,
                    Adi = garson.Adi,
                    Soyadi = garson.Soyadi,
                };
                button.CheckedChanged += GarsonSecim;
                flowGarson.Controls.Add(button);
            }
        }

        private void GarsonSecim(object sender, EventArgs e)
        {
            ControlGarsonCheckButton button = (ControlGarsonCheckButton)sender;
            btnGarsonSecim.Adi = button.Adi;
            btnGarsonSecim.Soyadi = button.Soyadi;
            btnGarsonSecim.GarsonId = button.GarsonId;
            secilenAdisyon.GarsonId = button.GarsonId;
            navigationKategori.SelectedPage = PagesKategoriUrunler;
        }

        void MasaButonOlustur()
        {
            foreach (var konum in worker.TanimService.GetList(c => c.TanimTipi == TanimTip.Konum))
            {
                ControlKonumButton button = new ControlKonumButton
                {
                    Name = konum.Id.ToString(),
                    Text = konum.Adi,
                    Height = 88,
                    Width = 150,
                    GroupIndex = 1,
                    Font = new Font("Century Gothic ", 12, FontStyle.Bold),
                    Masalar = worker.MasaService.GetList(c => c.KonumId == konum.Id)
                };
                button.CheckedChanged += KonumSecim;
                flowKonum.Controls.Add(button);
            }
        }

        void SiparisButtonOlustur()
        {
            foreach (var siparis in worker.AdisyonService.GetList(c => c.AdisyonTipi == AdisyonTipi.Siparis && c.AdisyonDurum == AdisyonDurum.Acik))
            {
                ControlSiparisButton siparisbutton = new ControlSiparisButton
                {
                    Name = siparis.Id.ToString(),
                    AdisyonId = siparis.Id,
                    Width = 200,
                    Height = 150,
                    Text = "Sipariş",
                    Font = new Font("Century Gothic", 12, FontStyle.Bold),
                };
                siparisbutton.Click += SiparisSec;
                flowSiparis.Controls.Add(siparisbutton);
            }
        }

        private void KonumSecim(object sender, EventArgs e)
        {
            ControlKonumButton button = (ControlKonumButton)sender;
            flowMasalar.Controls.Clear();
            foreach (var masa in button.Masalar)
            {
                ControlMasaButton masaButton = new ControlMasaButton
                {
                    Name = masa.Id.ToString(),
                    Text = masa.Adi + System.Environment.NewLine + masa.Kapasite.ToString() + " " + "Kişilik",
                    Height = 150,
                    Width = 150,
                    Font = new Font("Century Gothic ", 12, FontStyle.Bold),
                    MasaId = masa.Id,
                };
                masaButton.Click += MasaSec;
                flowMasalar.Controls.Add(masaButton);
            }
            foreach (var adisyon in worker.AdisyonService.GetList(c => c.AdisyonDurum==AdisyonDurum.Acik))
            {
                ControlMasaButton buttonMasa = flowMasalar.Controls.Cast<ControlMasaButton>().SingleOrDefault(c => c.MasaId == adisyon.MasaId);
                if (buttonMasa != null)
                {
                    buttonMasa.MasaDurum = MasaDurum.Dolu;
                    buttonMasa.AdisyonId = adisyon.Id;
                }
            }
        }

        private void MasaSec(object sender, EventArgs e)
        {
            ControlMasaButton button = (ControlMasaButton)sender;
            btnGarsonSecim.Visible = true;
            btnMusteri.Visible = true;
            gridControl1.DataSource = worker.UrunHareketService.BindingList();
            gridControlOdeme.DataSource = worker.OdemeHareketService.BindingList();
            GarsonButtonOlustur(PersonelTipi.Garson);
            navigationKategori.SelectedPage = PagesKategoriUrunler;

            if (button.MasaDurum == MasaDurum.Bos)
            {
                secilenAdisyon = new Adisyon();
                secilenAdisyon.Id = Guid.NewGuid();
                secilenAdisyon.AdisyonTipi = AdisyonTipi.Masa;
                secilenMasa = worker.MasaService.Get(c => c.Id == button.MasaId);
                secilenAdisyon.MasaId = button.MasaId;
                btnGarsonSecim.Image = ımageList2.Images[0];
                btnGarsonSecim.Text = "Personel Seçilmedi";
                button.AdisyonId = secilenAdisyon.Id;
                btnMusteri.Load();
                ToplamlariSifirla();
                navigationMain.SelectedPage = PageAdisyonAyrinti;

            }
            else if (button.MasaDurum == MasaDurum.Dolu) // Düzeltme burada yapıldı
            {
                // Masa dolu ise yapılması gereken işlemler
                worker.UrunHareketService.Load(c => c.AdisyonId == button.AdisyonId, c => c.Urun, c => c.Porsiyon, c => c.Porsiyon.Birim, c => c.EkMalzemeHareketleri);
                worker.AdisyonService.Load(c => c.Id == button.AdisyonId);
                worker.OdemeHareketService.Load(c => c.AdisyonId == button.AdisyonId, c => c.OdemeTuru);
                worker.EkMalzemeHareketService.Load(null);
                secilenAdisyon = worker.AdisyonService.Get(c => c.Id == button.AdisyonId);
                secilenMasa = worker.MasaService.Get(c => c.Id == button.MasaId);
                Personel garson = worker.GarsonService.Get(c => c.Id == secilenAdisyon.GarsonId);
                btnGarsonSecim.Image = ımageList2.Images[0];
                if (garson != null)
                {
                    btnGarsonSecim.Adi = garson.Adi;
                    btnGarsonSecim.Soyadi = garson.Soyadi;
                    btnGarsonSecim.GarsonId = garson.Id;
                }
                else
                {
                    btnGarsonSecim.Text = "Garson Seçilmedi";
                }

                if (secilenAdisyon.MusteriId != Guid.Empty)
                {
                    Musteri musteri = worker.MusteriService.Get(c => c.Id == secilenAdisyon.MusteriId);
                    if (musteri != null)
                    {
                        btnMusteri.Adi = musteri.Adi;
                        btnMusteri.Soyadi = musteri.Soyadi;
                        btnMusteri.MusteriId = musteri.Id;
                        btnMusteri.MusteriTip = musteri.MusteriTip;
                        btnMusteri.Load();
                    }
                }
                else
                {
                    btnMusteri.Text = "Müşteri Seçilmedi";
                }

                button.AdisyonId = secilenAdisyon.Id;
                navigationMain.SelectedPage = PageAdisyonAyrinti;
                layoutView1.RefreshData();
                UrunHareketToplamGetir();
            }
        }
        void ToplamlariSifirla()
        {
            txtKalanTutar.Value = 0;
            txtOdemeTutari.Value = 0;
            txtOdenenTutar.Value = 0;
            TxtToplamUrunTutar.Value = 0;
            txtToplamUrunHareketTutar.Value = 0;
            txtUrunHareketIndirimTutar.Value = 0;
            TxtUrunHareketOdenecekTutar.Value = 0;
        }
        void MiktarArttir(int sayi)
        {
            UrunHareket row = (UrunHareket)layoutView1.GetFocusedRow();
            if (row == null)
            {
                return;
            }
            if (sayi < 0 && row.Miktar <= 1)
            {
                return;
            }
            row.Miktar += sayi;
            layoutView1.RefreshData();
            UrunHareketToplamGetir();
        }

        private void KategoriButtonOlustur()
        {
            foreach (var Kategori in worker.TanimService.Select(filter: c => c.TanimTipi == TanimTip.UrunGrup, selector: c => new KategoriDto { Id = c.Id, Adi = c.Adi }).ToList())
            {
                ControlKategoriButton button = new ControlKategoriButton
                {
                    Name = Kategori.Id.ToString(),
                    Text = Kategori.Adi,
                    Id = Kategori.Id,
                    Urunler = worker.UrunService.GetList(c => c.UrunGrupId == Kategori.Id, c => c.Porsiyonlar, c => c.EkMalzemeler),
                    GroupIndex = 1,
                    Height = 80,
                    Font = new Font("Century Gothic ", 12, FontStyle.Bold),
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
                    Id = item.Id,
                    UrunImage = item.Fotograf.ByteArrayToImage(),
                    Height = 220,
                    Width = 300,
                    Aciklama = item.Aciklama,
                    Porsiyonlar = item.Porsiyonlar,
                    EkMalzemeler = item.EkMalzemeler,

                };
                urunButton.ButtonClick += UrunClick;
                flowKategoriUrunleri.Controls.Add(urunButton);
            }


        }

        private void UrunClick(object sender, EventArgs e)
        {

            ControlKategoriUrun button = (ControlKategoriUrun)sender;
            if (!button.Porsiyonlar.Any())
            {
                MessageBox.Show("Bu Ürüne Ait Atanmış Bir Porsiyon Bilgisi Bulunamadı!");
                return;
            }
            btnKategoriyeDon.Visible = true;
            flowPorsiyon.Controls.Clear();
            urunHareketEntity = new UrunHareket();

            urunHareketEntity.AdisyonId = secilenAdisyon.Id;
            urunHareketEntity.Id = Guid.NewGuid();
            urunHareketEntity.UrunId = button.Id;
            urunHareketEntity.Miktar = txtMiktar.Value;
            urunHareketEntity.UrunHareketTip = UrunHareketTip.Satis;
            navigationKategori.SelectedPage = PageUrunPorsiyon;
            foreach (var porsiyon in button.Porsiyonlar)
            {
                flowPorsiyon.Controls.Clear();
                ControlPorsiyonButton porsiyonButton = new ControlPorsiyonButton
                {
                    Name = porsiyon.Id.ToString(),
                    Text = porsiyon.Adi + Environment.NewLine + porsiyon.Fiyat.ToString("C2"),
                    Fiyat = porsiyon.Fiyat,
                    EkMalzemeCarpan = porsiyon.EkMalzemeCarpan,
                    Id = porsiyon.Id,
                    Height = 200,
                    Width = 200,
                    Font = new Font("Century Gothic ", 12, FontStyle.Bold),
                    EkMalzemeler = button.EkMalzemeler,
                };
                porsiyonButton.Click += PorsiyonClick;
                flowPorsiyon.Controls.Add(porsiyonButton);
            }
            if (button.Porsiyonlar.Count() == 1)
            {
                ControlPorsiyonButton buttonPorsiyon = (ControlPorsiyonButton)flowPorsiyon.Controls[0];
                buttonPorsiyon.PerformClick();
            }
        }

        private void PorsiyonClick(object sender, EventArgs e)
        {
            flowEkMalzeme.Controls.Clear();
            ControlPorsiyonButton button = (ControlPorsiyonButton)sender;

            urunHareketEntity.PorsiyonId = button.Id;
            urunHareketEntity.BirimFiyat = button.Fiyat;
            txtPorsiyonTutar.Value = button.Fiyat;
            if (!button.EkMalzemeler.Any())
            {
                UrunHareketEkle();
                navigationKategori.SelectedPage = PagesKategoriUrunler;
                return;
            }
            EkMalzemeButonOlustur(button.EkMalzemeCarpan, button.EkMalzemeler);

        }
        void EkMalzemeButonOlustur(decimal EkMalzemeCarpan, IEnumerable<EkMalzeme> EkMalzemeList)
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
            EkMalzemeHesapla();
            urunHareketEntity.EkMalzemeFiyat = txtEkMalzemeTutar.Value;
            UrunHareketEkle();
            foreach (ControlEkMalzemeButton button in flowEkMalzeme.Controls)
            {
                if (button.Checked)
                {
                    if (!worker.EkMalzemeHareketService.Exist(c => c.UrunHareketId == urunHareketEntity.Id && c.EkMalzemeId == button.Id))
                    {
                        worker.EkMalzemeHareketService.AddOrUpdate(new EkMalzemeHareket
                        {
                            Id = Guid.NewGuid(),
                            UrunHareketId = urunHareketEntity.Id,
                            EkMalzemeId = button.Id,
                            Fiyat = button.Fiyat
                        });
                    }
                }
                else
                {
                    worker.EkMalzemeHareketService.EntityStateChange(c => c.UrunHareketId == urunHareketEntity.Id && c.EkMalzemeId == button.Id, EntityState.Deleted);
                }
            }

            navigationKategori.SelectedPage = PagesKategoriUrunler;
        }
        void UrunHareketEkle()
        {
            if (!worker.AdisyonService.Exist(c => c.Id == secilenAdisyon.Id))
            {
                worker.AdisyonService.AddOrUpdate(secilenAdisyon);
                worker.Commit();
            }
            btnKategoriyeDon.Visible = false;
            worker.UrunHareketService.AddOrUpdate(urunHareketEntity);
            worker.UrunService.Load(c => c.Id == urunHareketEntity.UrunId);
            worker.PorsiyonService.Load(c => c.Id == urunHareketEntity.PorsiyonId);
            worker.AdisyonService.Load(c => c.Id == urunHareketEntity.AdisyonId);
            Guid Id = urunHareketEntity.Porsiyon.BirimId;
            worker.TanimService.Load(c => c.Id == Id);
            layoutView1.RefreshData();
            UrunHareketToplamGetir();
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
            if (view.FocusedRowHandle == e.RowHandle)
            {
                e.Appearance.BackColor = Color.DarkOliveGreen;
                return;
            }
            switch (row.UrunHareketTip)
            {
                case UrunHareketTip.Satis:
                    e.Appearance.BackColor = Color.Olive;
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
            SimpleButton button = (SimpleButton)sender;
            if (navigationKategori.SelectedPage == PageOdemeEkrani)
            {
                txtOdemeTutari.Focus();
                SendKeys.Send(button.Text);
            }
            else
            {
                txtMiktar.Focus();
                SendKeys.Send(button.Text);
            }
        }

        private void btnKategoriyeDon_Click(object sender, EventArgs e)
        {
            navigationKategori.SelectedPage = PagesKategoriUrunler;
            btnKategoriyeDon.Visible = false;
        }

        private void btnMiktarArttir_Click(object sender, EventArgs e)
        {
            MiktarArttir(+1);
        }

        private void btnFiyatDegistir_Click(object sender, EventArgs e)
        {
            if (layoutView1.GetFocusedRow() == null)
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
                    if (hareketEntity.Miktar == txtMiktar.Value)
                    {
                        hareketEntity.UrunHareketTip = UrunHareketTip.Iptal;
                    }
                    else if (hareketEntity.Miktar < txtMiktar.Value)
                    {
                        MessageBox.Show($"{hareketEntity.Miktar} Miktarından Daha Fazla İade Yapılamaz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        UrunHareket yeniEntity = hareketEntity.Clone();
                        yeniEntity.Id = Guid.NewGuid();
                        yeniEntity.UrunHareketTip = UrunHareketTip.Iptal;
                        yeniEntity.Miktar = txtMiktar.Value;
                        worker.UrunHareketService.Add(yeniEntity);
                        hareketEntity.Miktar -= txtMiktar.Value;
                    }
                    layoutView1.RefreshData();
                    break;
                case KeyPadIslem.Ikram:
                    if (hareketEntity.Miktar == txtMiktar.Value)
                    {
                        hareketEntity.UrunHareketTip = UrunHareketTip.Ikram;
                    }
                    else if (hareketEntity.Miktar < txtMiktar.Value)
                    {
                        MessageBox.Show($"{hareketEntity.Miktar} Miktarından Daha Fazla ikram Yapılamaz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        UrunHareket yeniEntity = hareketEntity.Clone();
                        yeniEntity.Id = Guid.NewGuid();
                        yeniEntity.UrunHareketTip = UrunHareketTip.Ikram;
                        yeniEntity.Miktar = txtMiktar.Value;
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
                    if (txtMiktar.Value < 0 || txtMiktar.Value > 100)
                    {
                        MessageBox.Show("Girdiğiniz İndirim Oranı 0 İle 100 Arasında Olmalıdır.!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    hareketEntity.Indirim = txtMiktar.Value;
                    layoutView1.RefreshData();
                    break;
                case KeyPadIslem.OdemeBol:
                    txtOdemeTutari.Value = txtKalanTutar.Value / txtOdemeTutari.Value;
                    break;
            }
            keyPadIslem = KeyPadIslem.Yok;
            UrunHareketToplamGetir();
        }

        private void btnIkram_Click(object sender, EventArgs e)
        {
            if (layoutView1.GetFocusedRow() == null) return;
            UrunHareket hareketEntity = (UrunHareket)layoutView1.GetFocusedRow();
            if (hareketEntity.Miktar == 1)
            {
                hareketEntity.UrunHareketTip = UrunHareketTip.Ikram;
                layoutView1.RefreshData();
                UrunHareketToplamGetir();
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
            if (layoutView1.GetFocusedRow() == null)
            {
                return;
            }
            flowEkMalzeme.Controls.Clear();
            urunHareketEntity = (UrunHareket)layoutView1.GetFocusedRow();
            Porsiyon porsiyonEntity = worker.PorsiyonService.Get(c => c.Id == urunHareketEntity.PorsiyonId);
            IEnumerable<EkMalzeme> ekMalzemeList = worker.EkMalzemeService.GetList(c => c.UrunId == urunHareketEntity.UrunId);
            txtPorsiyonTutar.Value = porsiyonEntity.Fiyat;
            EkMalzemeButonOlustur(porsiyonEntity.EkMalzemeCarpan, ekMalzemeList);
            List<EkMalzemeHareket> HareketList = worker.EkMalzemeHareketService.BindingList().ToList();
            foreach (var hareket in HareketList.Where(c => c.UrunHareketId == urunHareketEntity.Id).ToList())
            {
                ControlEkMalzemeButton button = (ControlEkMalzemeButton)flowEkMalzeme.Controls.Find(hareket.EkMalzemeId.ToString(), true)[0];
                button.Checked = true;
            }


        }

        private void btnIndirim_Click(object sender, EventArgs e)
        {
            UrunHareket entity = (UrunHareket)layoutView1.GetFocusedRow();
            if (entity == null)
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
                UrunHareketToplamGetir();
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

        private void btnSiparisKaydet_Click(object sender, EventArgs e)
        {
            //Siparişi Kaydetme  

            //Siparişi İçeriği varsa kaydet
            if (layoutView1.RowCount == 0)
            {
                btnGarsonSecim.Visible = false;
                btnMusteri.Visible = false;
                btnMusteri.Clear();
                navigationMain.SelectedPage = PageMasalar;
                return;
            }
            if (btnGarsonSecim.GarsonId == Guid.Empty)
            {
                MessageBox.Show("Lütfen Siparişi Kaydetmek İçin Personel Seçiniz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            secilenAdisyon.GarsonId = btnGarsonSecim.GarsonId;
            if (btnMusteri.MusteriId != Guid.Empty)
            {
                secilenAdisyon.MusteriId = btnMusteri.MusteriId;
            }
            btnGarsonSecim.Clear();
            btnMusteri.Clear();
            secilenAdisyon.Tutar = TxtUrunHareketOdenecekTutar.Value;
            btnGarsonSecim.Visible = false;
            btnMusteri.Visible = false;
            worker.AdisyonService.AddOrUpdate(secilenAdisyon);
            if (secilenAdisyon.AdisyonTipi==AdisyonTipi.Masa)
            {
                ControlMasaButton button = (ControlMasaButton)flowMasalar.Controls.Find(secilenMasa.Id.ToString(), true)[0];
                if (secilenAdisyon.AdisyonDurum==AdisyonDurum.Iptal || txtKalanTutar.Value <= 0)
                {
                    button.MasaDurum = MasaDurum.Bos;
                }
                else
                {
                    button.MasaDurum = MasaDurum.Dolu;
                }
            }
            if (secilenAdisyon.AdisyonTipi==AdisyonTipi.Siparis)
            {
                ControlSiparisButton button = (ControlSiparisButton)flowSiparis.Controls.Find(secilenAdisyon.Id.ToString(), true)[0];
                if (secilenAdisyon.AdisyonDurum==AdisyonDurum.Iptal || txtKalanTutar.Value <= 0)
                {
                    button.Dispose();
                }
            }
            if (txtKalanTutar.Value <= 0)
            {
             secilenAdisyon.AdisyonDurum = AdisyonDurum.Kapali;
             btnSiparisKaydet.Text = "Değişiklikleri\nKaydet";
             btnSiparisKaydet.ImageOptions.ImageIndex = 0;
            }
            else
            {

                secilenAdisyon.AdisyonDurum = AdisyonDurum.Acik;
            }
            worker.Commit();
            worker = new RestaurantWorker();
            gridControl1.DataSource = worker.UrunHareketService.BindingList();
            gridControlOdeme.DataSource = worker.OdemeHareketService.BindingList();
            lblMesaj.Visible = false;
            navigationMain.SelectedPage = PageMasalar;
        }

        private void btnGarsonSecim_Click(object sender, EventArgs e)
        {
            if (navigationKategori.SelectedPage==PageGarson)
            {
                navigationKategori.SelectedPage = PagesKategoriUrunler;
            }
            else
            {
                navigationKategori.SelectedPage = PageGarson;
            }
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            if (navigationKategori.SelectedPage==PageMusteri)
            {
                navigationKategori.SelectedPage = PagesKategoriUrunler;
            }
            else
            {
                navigationKategori.SelectedPage = PageMusteri;
            }
        }
        private void UrunHareketToplamGetir()
        {            
           AdisyonToplamDto toplamlar= worker.AdisyonService.AdisyonToplamGetir();
            TxtToplamUrunTutar.Value=toplamlar.ToplamTutar;
            txtUrunHareketIndirimTutar.Value = toplamlar.IndirimTutar;
            TxtUrunHareketOdenecekTutar.Value = toplamlar.OdenecekTutar;
            txtOdenenTutar.Value = toplamlar.OdenenTutar;
            txtKalanTutar.Value = toplamlar.KalanTutar;
            if (toplamlar.KalanTutar<=0)
            {
                btnSiparisKaydet.ImageOptions.ImageIndex = 1;
                btnSiparisKaydet.Text="Masayı\nKapat";
            }
            else
            {
                btnSiparisKaydet.ImageOptions.ImageIndex = 0;
                btnSiparisKaydet.Text = "Siparişi\nKaydet";
            }   
            
        }

        private void btnOdemeEkle_Click(object sender, EventArgs e)
        {
            if (navigationKategori.SelectedPage==PageOdemeEkrani)
            {
              navigationKategori.SelectedPage = PagesKategoriUrunler;
            }
            else
            {
                navigationKategori.SelectedPage = PageOdemeEkrani;
            }
        }

        private void btnOdemeTumu_Click(object sender, EventArgs e)
        {
            txtOdemeTutari.Value = txtKalanTutar.Value;
        }

        private void btnOdemeYarim_Click(object sender, EventArgs e)
        {
            txtOdemeTutari.Value = txtKalanTutar.Value / 2;
        }

        private void btnOdemeCeyrek_Click(object sender, EventArgs e)
        {
            txtOdemeTutari.Value = txtKalanTutar.Value / 4;
        }

        private void BtnOdemeN_Click(object sender, EventArgs e)
        {
            keyPadIslem = KeyPadIslem.OdemeBol;
            txtMiktar.Text = null;
            txtMiktar.Properties.NullValuePrompt = "Lütfen Bölünecek Oranı Giriniz!";
        }

        private void ParaClick(object sender, EventArgs e)
        {
            ControlParaButton button = (ControlParaButton)sender;
            txtOdemeTutari.Value += button.Deger;
        }

        private void btnKeypadBack_Click(object sender, EventArgs e)
        {
            if (navigationKategori.SelectedPage == PageOdemeEkrani)
            {
                txtOdemeTutari.Focus();
                SendKeys.Send("{BACKSPACE}");
            }
            else
            {
                txtMiktar.Focus();
                SendKeys.Send("{BACKSPACE}");
            }
        }

        private void btnKeypadDel_Click(object sender, EventArgs e)
        {
            if (navigationKategori.SelectedPage == PageOdemeEkrani)
            {
                txtOdemeTutari.Value = 0;
            }
            else
            {
                txtMiktar.Value = 0;
            }
        }

        private void btnSiparisİptal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Adisyonunuz İptal Edilecek. Emin misiniz?","Uyarı",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                secilenAdisyon.AdisyonDurum = AdisyonDurum.Iptal;
                btnSiparisKaydet.PerformClick();
            }
        }

        private void btnUrunNot_Click(object sender, EventArgs e)
        {
            UrunHareket entity = (UrunHareket)layoutView1.GetFocusedRow();
            if (entity == null) return;

            navigationKategori.SelectedPage = PageUrunNotlari;
            txtUrunNotu.Text = entity.Aciklama;

            foreach (var urunNot in worker.UrunNotService.GetList(c => c.UrunId == entity.UrunId))
            {
                flowUrunNotlari.Controls.Clear();
                SimpleButton button = new SimpleButton
                {
                    Name = urunNot.Id.ToString(),
                    Text = urunNot.Notu,
                    Width = 200,
                    Height = 40
                };
                button.Click += UrunNotClick;
                flowUrunNotlari.Controls.Add(button);
            }
        }

        private void UrunNotClick(object sender, EventArgs e)
        {
            SimpleButton button = (SimpleButton)sender;
            if (string.IsNullOrEmpty(txtUrunNotu.Text))
            {
                txtUrunNotu.Text=button.Text;
            }
            else
            {
                txtUrunNotu.Text += ", " + button.Text; 
            }
        }

        private void btnUrunNotuOnayla_Click(object sender, EventArgs e)
        {
            UrunHareket entity = (UrunHareket)layoutView1.GetFocusedRow();
            entity.Aciklama = txtUrunNotu.Text;
            layoutView1.RefreshData();
            navigationKategori.SelectedPage = PagesKategoriUrunler;
        }

        private void BtnUrunNotVazgec_Click(object sender, EventArgs e)
        {
            navigationKategori.SelectedPage = PagesKategoriUrunler;
        }

        private void btnMasalar_Click(object sender, EventArgs e)
        {
            navigationMain.SelectedPage = PageMasalar;
        }

        private void btnSiparisler_Click(object sender, EventArgs e)
        {
            navigationMain.SelectedPage = PageSiparis;
        }

        private void navigationMain_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            if (e.Page==PageAdisyonAyrinti || e.Page==pageKullaniciGiris)
            {
                panelAnaSolMenu.Visible = false;
            }
            else
            {
                panelAnaSolMenu.Visible = true;
            }
        }

        private void btnYeniSiparis_Click(object sender, EventArgs e)
        {
            btnGarsonSecim.Visible = true;
            btnMusteri.Visible = true;
            gridControl1.DataSource = worker.UrunHareketService.BindingList();
            gridControlOdeme.DataSource = worker.OdemeHareketService.BindingList();
            GarsonButtonOlustur(PersonelTipi.Kurye);
            navigationKategori.SelectedPage = PagesKategoriUrunler;
            secilenAdisyon = new Adisyon();
            secilenAdisyon.Id = Guid.NewGuid();
            secilenAdisyon.AdisyonTipi = AdisyonTipi.Siparis;
            ControlSiparisButton button = new ControlSiparisButton
            {
                Width = 200,
                Height = 150,
                Name = secilenAdisyon.Id.ToString(),
                AdisyonId = secilenAdisyon.Id,
                Font = new Font("Century Gothic", 12, FontStyle.Bold),
                Text = "Sipariş"
            };
            button.Click += SiparisSec;
            flowSiparis.Controls.Add(button);
            btnGarsonSecim.Image = ımageList2.Images[1];
            btnGarsonSecim.Text = "Kurye Seçilmedi";
            btnMusteri.Load();
            ToplamlariSifirla();
            navigationMain.SelectedPage = PageAdisyonAyrinti;
        }

        private void SiparisSec(object sender, EventArgs e)
        {
            ControlSiparisButton button = (ControlSiparisButton)sender;
            btnGarsonSecim.Visible = true;
            btnMusteri.Visible = true;
            gridControl1.DataSource = worker.UrunHareketService.BindingList();
            gridControlOdeme.DataSource = worker.OdemeHareketService.BindingList();
            GarsonButtonOlustur(PersonelTipi.Kurye);
            navigationKategori.SelectedPage = PagesKategoriUrunler;

                // Masa dolu ise yapılması gereken işlemler
                worker.UrunHareketService.Load(c => c.AdisyonId == button.AdisyonId, c => c.Urun, c => c.Porsiyon, c => c.Porsiyon.Birim, c => c.EkMalzemeHareketleri);
                worker.AdisyonService.Load(c => c.Id == button.AdisyonId);
                worker.OdemeHareketService.Load(c => c.AdisyonId == button.AdisyonId, c => c.OdemeTuru);
                worker.EkMalzemeHareketService.Load(null);
                secilenAdisyon = worker.AdisyonService.Get(c => c.Id == button.AdisyonId);
                Personel garson = worker.GarsonService.Get(c => c.Id == secilenAdisyon.GarsonId);
                 btnGarsonSecim.Image = ımageList2.Images[1];
                if (garson != null)
                {
                    btnGarsonSecim.Adi = garson.Adi;
                    btnGarsonSecim.Soyadi = garson.Soyadi;
                    btnGarsonSecim.GarsonId = garson.Id;
                }
                else
                {

                btnGarsonSecim.Text = "Kurye Seçilmedi";
                }

                if (secilenAdisyon.MusteriId != Guid.Empty)
                {
                    Musteri musteri = worker.MusteriService.Get(c => c.Id == secilenAdisyon.MusteriId);
                    if (musteri != null)
                    {
                        btnMusteri.Adi = musteri.Adi;
                        btnMusteri.Soyadi = musteri.Soyadi;
                        btnMusteri.MusteriId = musteri.Id;
                        btnMusteri.MusteriTip = musteri.MusteriTip;
                        btnMusteri.Load();
                    }
                }
                else
                {
                    btnMusteri.Text = "Müşteri Seçilmedi";
                }

                button.AdisyonId = secilenAdisyon.Id;
                navigationMain.SelectedPage = PageAdisyonAyrinti;
                layoutView1.RefreshData();
                UrunHareketToplamGetir();
           
        }

        private void controlBadgeButton1_Click(object sender, EventArgs e)
        {
            navigationMain.SelectedPage = PageBildirim;
        }
    }
}
