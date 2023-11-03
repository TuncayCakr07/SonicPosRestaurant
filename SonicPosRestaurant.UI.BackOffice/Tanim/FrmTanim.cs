using DevExpress.XtraEditors;
using SonicPosRestaurant.Business.Workers;
using SonicPosRestaurant.Entities.Enums;
using SonicPosRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicPosRestaurant.UI.BackOffice.Tanim
{
    public partial class FrmTanim : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker = new RestaurantWorker();
        public Entities.Tables.Tanim tanimEntity;
        public bool Secildi=false;
        private TanimTip _tanimTip;
        public FrmTanim(TanimTip tanimTip)
        {
            InitializeComponent();
            _tanimTip = tanimTip;
            worker.TanimService.Load(c=> c.TanimTipi==tanimTip);
            gridControlTanim.DataSource = worker.TanimService.BindingList();
        }
        void TanimBinding()
        {
            TxtTanim.DataBindings.Clear();  
            TxtAciklama.DataBindings.Clear();
            TxtTanim.DataBindings.Add("Text",tanimEntity,"Adi",false,DataSourceUpdateMode.OnPropertyChanged);
            TxtAciklama.DataBindings.Add("Text",tanimEntity,"Aciklama",false,DataSourceUpdateMode.OnPropertyChanged);
        }

        private void controlMenuKayit_SecClick(object sender, EventArgs e)
        {
            Secildi = true;
            tanimEntity=(Entities.Tables.Tanim)gridTanim.GetFocusedRow();
            Close();
        }

        private void controlMenuKayit_EkleClick(object sender, EventArgs e)
        {
            controlMenuKayit.KayıtAc = true;
            groupTanimBilgi.Visible = true;
            tanimEntity = new Entities.Tables.Tanim();
            tanimEntity.Id=Guid.NewGuid();
            TanimBinding();
        }

        private void controlMenuKayit_DuzenleClick(object sender, EventArgs e)
        {
            controlMenuKayit.KayıtAc = true;
            groupTanimBilgi.Visible = true;
            tanimEntity =(Entities.Tables.Tanim)gridTanim.GetFocusedRow();
            TanimBinding();
        }

        private void controlMenuKayit_SilClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İster Misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                gridTanim.DeleteSelectedRows();
            }
        }

        private void controlMenuKayit_KaydetClick(object sender, EventArgs e)
        {
            controlMenuKayit.KayıtAc = false;
            groupTanimBilgi.Visible = false;
            tanimEntity.TanimTipi = _tanimTip;
            worker.TanimService.AddOrUpdate(tanimEntity);
            worker.Commit();
        }

        private void controlMenuKayit_VazgecClick(object sender, EventArgs e)
        {
            controlMenuKayit.KayıtAc = false;
            groupTanimBilgi.Visible = false;
        }

        private void controlMenuKayit_KapatClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}