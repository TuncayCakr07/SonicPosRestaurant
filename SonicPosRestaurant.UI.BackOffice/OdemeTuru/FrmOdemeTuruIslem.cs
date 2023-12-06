using DevExpress.XtraEditors;
using SonicPosRestaurant.Business.Workers;
using SonicPosRestaurant.Entities.Enums;
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

namespace SonicPosRestaurant.UI.BackOffice.OdemeTuru
{
    public partial class FrmOdemeTuruIslem : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Tables.OdemeTuru _odemeTuruEntity;
        public bool Kaydedildi=false;
        RestaurantWorker worker=new RestaurantWorker();
        public FrmOdemeTuruIslem(Entities.Tables.OdemeTuru odemeTuruEntity)
        {
            InitializeComponent();
            _odemeTuruEntity = odemeTuruEntity;
            OdemeTuruBinding();
        }
        void OdemeTuruBinding()
        {
            TxtAdi.DataBindings.Clear();
            txtOdemeTuru.DataBindings.Clear();
            TxtAciklama.DataBindings.Clear();
            TxtAdi.DataBindings.Add("Text",_odemeTuruEntity,"Adi",false,DataSourceUpdateMode.OnPropertyChanged);
            TxtAciklama.DataBindings.Add("Text",_odemeTuruEntity,"Aciklama",false,DataSourceUpdateMode.OnPropertyChanged);
            txtOdemeTuru.DataBindings.Add("Text", _odemeTuruEntity.OdemeTur??new Entities.Tables.Tanim(), "Adi", false, DataSourceUpdateMode.Never);
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            worker.OdemeTuruService.AddOrUpdate(_odemeTuruEntity);
            worker.Commit();
            Kaydedildi = true;
            Close();
        }

        private void txtOdemeTuru_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmTanim form=new FrmTanim(TanimTip.OdemeTuru);
            form.ShowDialog();
            if (form.Secildi)
            {
                _odemeTuruEntity.OdemeTurId = form.tanimEntity.Id;
                txtOdemeTuru.Text = form.tanimEntity.Adi;
            }
        }
    }
}