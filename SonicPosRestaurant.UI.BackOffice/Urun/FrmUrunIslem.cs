﻿using DevExpress.XtraEditors;
using SonicPosRestaurant.Business.Workers;
using SonicPosRestaurant.Entities.Enums;
using SonicPosRestaurant.Entities.Tables;
using SonicPosRestaurant.UI.BackOffice.Tanim;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicPosRestaurant.UI.BackOffice.Urun
{
    public partial class FrmUrunIslem : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker = new RestaurantWorker();
        private Entities.Tables.Urun _urunEntity;
        private Porsiyon _porsiyonEntity;
        private EkMalzeme _ekMalzemeEntity;
        public FrmUrunIslem(Entities.Tables.Urun urunEntity)
        {
            InitializeComponent();
            _urunEntity = urunEntity;
            if (urunEntity.Id==Guid.Empty)
            {
                _urunEntity.Id = Guid.NewGuid();
            }
            worker.PorsiyonService.Load(c=> c.UrunId==_urunEntity.Id);
            gridControlPorsiyon.DataSource = worker.PorsiyonService.BindingList();
            worker.EkMalzemeService.Load(c=> c.UrunId== _urunEntity.Id);
            gridControlMalzeme.DataSource = worker.EkMalzemeService.BindingList();
            UrunBinding();
        }
        void UrunBinding()
        {
            TxtBarkod.DataBindings.Clear();
            TxtUrunAdi.DataBindings.Clear();
            TxtUrunAciklama.DataBindings.Clear();
            picUrunFoto.DataBindings.Clear();
            TxtBarkod.DataBindings.Add("Text",_urunEntity,"Barkod",false,DataSourceUpdateMode.OnPropertyChanged);
            TxtUrunAdi.DataBindings.Add("Text",_urunEntity,"Adi",false,DataSourceUpdateMode.OnPropertyChanged);
            TxtUrunAciklama.DataBindings.Add("Text",_urunEntity,"Aciklama",false,DataSourceUpdateMode.OnPropertyChanged);
            picUrunFoto.DataBindings.Add("EditValue",_urunEntity,"Fotograf",false,DataSourceUpdateMode.OnPropertyChanged);
        }
        void PorsiyonBinding()
        {
            TxtPorsiyonAdi.DataBindings.Clear();
            TxtPorsiyonFiyat.DataBindings.Clear();
            TxtEkMalzemeCarpan.DataBindings.Clear();
            TxtPorsiyonAciklama.DataBindings.Clear();
            TxtPorsiyonAdi.DataBindings.Add("Text", _porsiyonEntity, "Adi", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtPorsiyonFiyat.DataBindings.Add("Value", _porsiyonEntity, "Fiyat", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtEkMalzemeCarpan.DataBindings.Add("Value", _porsiyonEntity, "EkMalzemeCarpan", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtPorsiyonAciklama.DataBindings.Add("Text", _porsiyonEntity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        void EkMalzemeBinding()
        {
            TxtMalzemeAdi.DataBindings.Clear();
            TxtMalzemeFiyati.DataBindings.Clear();
            TxtMalzemeAciklama.DataBindings.Clear();
            TxtMalzemeAdi.DataBindings.Add("Text",_ekMalzemeEntity,"Adi",false, DataSourceUpdateMode.OnPropertyChanged);
            TxtMalzemeFiyati.DataBindings.Add("Value",_ekMalzemeEntity,"Fiyat",false, DataSourceUpdateMode.OnPropertyChanged);
            TxtMalzemeAciklama.DataBindings.Add("Text",_ekMalzemeEntity,"Aciklama",false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void controlMenuPorsiyon_EkleClick(object sender, EventArgs e)
        {
            controlMenuPorsiyon.KayıtAc = true;
            groupPorsiyonBilgi.Visible = true;
            _porsiyonEntity = new Porsiyon();
            _porsiyonEntity.UrunId = _urunEntity.Id;
            PorsiyonBinding();
        }

        private void controlMenuPorsiyon_DuzenleClick(object sender, EventArgs e)
        {
            controlMenuPorsiyon.KayıtAc = true;
            groupPorsiyonBilgi.Visible = true;
            _porsiyonEntity =(Porsiyon)gridPorsiyon.GetFocusedRow();
            PorsiyonBinding();
        }

        private void controlMenuPorsiyon_SilClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İster Misiniz?","Uyarı!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                gridPorsiyon.DeleteSelectedRows();
            }
        }

        private void controlMenuPorsiyon_KaydetClick(object sender, EventArgs e)
        {
            controlMenuPorsiyon.KayıtAc = false;
            groupPorsiyonBilgi.Visible = false;
            worker.PorsiyonService.AddOrUpdate(_porsiyonEntity);
        }

        private void controlMenuPorsiyon_VazgecClick(object sender, EventArgs e)
        {
            controlMenuPorsiyon.KayıtAc = false;
            groupPorsiyonBilgi.Visible = false;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
                worker.UrunService.AddOrUpdate(_urunEntity);
                worker.Commit();
                MessageBox.Show("Ürün başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Formu kapat
        }

        private void controlMenuEkMalzeme_EkleClick(object sender, EventArgs e)
        {
            controlMenuEkMalzeme.KayıtAc = true;
            groupEkMalzeme.Visible = true;
            _ekMalzemeEntity=new EkMalzeme();
            _ekMalzemeEntity.UrunId=_urunEntity.Id;
            EkMalzemeBinding();
        }

        private void controlMenuEkMalzeme_DuzenleClick(object sender, EventArgs e)
        {
            controlMenuEkMalzeme.KayıtAc = true;
            groupEkMalzeme.Visible = true;
            _ekMalzemeEntity=(EkMalzeme)gridMalzeme.GetFocusedRow();
            EkMalzemeBinding();
        }

        private void controlMenuEkMalzeme_SilClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İster Misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                gridMalzeme.DeleteSelectedRows();
            }
        }

        private void controlMenuEkMalzeme_KaydetClick(object sender, EventArgs e)
        {
            controlMenuEkMalzeme.KayıtAc = false;
            groupEkMalzeme.Visible = false;
            worker.EkMalzemeService.AddOrUpdate(_ekMalzemeEntity);
        }

        private void controlMenuEkMalzeme_VazgecClick(object sender, EventArgs e)
        {
            controlMenuEkMalzeme.KayıtAc = false;
            groupEkMalzeme.Visible = false;
        }

        private void TxtKategori_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmTanim frm=new FrmTanim(TanimTip.UrunGrup);
            frm.ShowDialog();
            if (frm.Secildi)
            {
                TxtKategori.Text = frm.tanimEntity.Adi;
                _urunEntity.UrunGrupId = frm.tanimEntity.Id;
            }
        }

        private void TxtBirim_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmTanim frm = new FrmTanim(TanimTip.Birim);
            frm.ShowDialog();
            if (frm.Secildi)
            {
                TxtBirim.Text = frm.tanimEntity.Adi;
                _porsiyonEntity.BirimId = frm.tanimEntity.Id;
            }
        }
    }
}