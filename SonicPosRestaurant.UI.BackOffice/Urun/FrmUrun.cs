using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Helpers;
using SonicPosRestaurant.Business.Workers;
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

namespace SonicPosRestaurant.UI.BackOffice.Urun
{
    public partial class FrmUrun : DevExpress.XtraEditors.XtraForm
    { 
        RestaurantWorker worker=new RestaurantWorker();
        public FrmUrun()
        {
            InitializeComponent();
            Listele();
        }
        void Listele()
        {
            worker.UrunService.Load(null, c => c.UrunGrup);
            gridControlUrunler.DataSource = worker.UrunService.BindingList();
        }
        private void controlMenu_ButtonEkle(object sender, EventArgs e)
        {
            FrmUrunIslem frm = new FrmUrunIslem(new Entities.Tables.Urun());
            frm.ShowDialog();
            if (frm.Eklendi)
            {
                Listele();
            }
        }

        private void controlMenu_ButtonDuzenle(object sender, EventArgs e)
        {
            if (gridUrun.GetFocusedRow()==null)
            {
                return;
            }
            FrmUrunIslem form = new FrmUrunIslem((Entities.Tables.Urun)gridUrun.GetFocusedRow());
            form.ShowDialog();
            if (form.Eklendi)
            {
                Listele();
            }
        }

        private void controlMenu_ButtonGuncelle(object sender, EventArgs e)
        {
            Listele();
        }

        private void controlMenu_ButtonSil(object sender, EventArgs e)
        {
            if (gridUrun.GetFocusedRow() == null)
            {
                return;
            }
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Emin Misiniz?","Uyarı!",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                gridUrun.DeleteSelectedRows();
                Listele();
            }
            
        }

        private void controlMenu_ButtonKapat(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}