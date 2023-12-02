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

namespace SonicPosRestaurant.UI.BackOffice.Garson
{
    public partial class FrmGarsonIslem : DevExpress.XtraEditors.XtraForm
    {
        Entities.Tables.Garson _garson;
        public bool Kaydedildi=false;
        RestaurantWorker worker=new RestaurantWorker();
        public FrmGarsonIslem(Entities.Tables.Garson garson)
        {
            InitializeComponent();
            _garson = garson;
            GarsonBinding();
        }
        void GarsonBinding()
        {
            TxtAdi.DataBindings.Clear();
            txtSoyadi.DataBindings.Clear();
            TxtAciklama.DataBindings.Clear();
            TxtAdi.DataBindings.Add("Text",_garson,"Adi",false,DataSourceUpdateMode.OnPropertyChanged);
            txtSoyadi.DataBindings.Add("Text",_garson,"Soyadi",false,DataSourceUpdateMode.OnPropertyChanged);
            TxtAciklama.DataBindings.Add("Text",_garson,"Aciklama",false,DataSourceUpdateMode.OnPropertyChanged);
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            worker.GarsonService.AddOrUpdate(_garson);
            worker.Commit();
            Kaydedildi=true; 
            MessageBox.Show("İşlem Kaydedildi!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Close();
        }
    }
}