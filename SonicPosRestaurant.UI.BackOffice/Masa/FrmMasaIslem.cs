using DevExpress.XtraEditors;
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

namespace SonicPosRestaurant.UI.BackOffice.Masa
{
    public partial class FrmMasaIslem : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Tables.Masa _masa;
        public bool Kaydedildi=false;
        RestaurantWorker worker=new RestaurantWorker();
        public FrmMasaIslem(Entities.Tables.Masa masa)
        {
            InitializeComponent();
            _masa = masa;
            MasaBinding();
        }
        void MasaBinding()
        {
            TxtMasaAdi.DataBindings.Clear();
            txtKapasite.DataBindings.Clear();   
            TxtAciklama.DataBindings.Clear();
            txtKonumu.DataBindings.Clear();

            TxtMasaAdi.DataBindings.Add("Text",_masa,"Adi",false,DataSourceUpdateMode.OnPropertyChanged);
            txtKapasite.DataBindings.Add("Value",_masa,"Kapasite",false,DataSourceUpdateMode.OnPropertyChanged);
            TxtAciklama.DataBindings.Add("Text",_masa,"Aciklama",false,DataSourceUpdateMode.OnPropertyChanged);
            txtKonumu.DataBindings.Add("Text",_masa.Konum??new Entities.Tables.Tanim(),"Adi",false,DataSourceUpdateMode.Never);
        }

        private void txtKonumu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmTanim form = new FrmTanim(TanimTip.Konum);
            form.ShowDialog();
            if (form.Secildi)
            {
                txtKonumu.Text = form.tanimEntity.Adi;
                _masa.KonumId = form.tanimEntity.Id;
            }
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            worker.MasaService.AddOrUpdate(_masa);
            worker.Commit();
            Kaydedildi=true; 
            Close(); 
        }
    }
}