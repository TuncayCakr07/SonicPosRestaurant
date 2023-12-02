using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SonicPosRestaurant.Business.Workers;

namespace SonicPosRestaurant.UI.BackOffice.Garson
{
    public partial class FrmGarson : DevExpress.XtraEditors.XtraForm
    { 
        RestaurantWorker worker=new RestaurantWorker();
        public FrmGarson()
        {
            InitializeComponent();
            Listele();
        }
        void Listele()
        {
            worker.GarsonService.Load(null);
            gridControlGarson.DataSource = worker.GarsonService.BindingList();
        }

        private void controlMenu_ButtonEkle(object sender, EventArgs e)
        {
            FrmGarsonIslem form=new FrmGarsonIslem(new Entities.Tables.Garson());
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Listele();
            }
        }
        private void controlMenu_ButtonDuzenle(object sender, EventArgs e)
        {
            if (gridGarson.GetFocusedRow()==null)
            {
                return;
            }
            FrmGarsonIslem form = new FrmGarsonIslem((Entities.Tables.Garson)gridGarson.GetFocusedRow());
            form.ShowDialog();
            if (form.Kaydedildi)
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
            if (gridGarson.GetFocusedRow() == null)
            {
                return;
            }

            if (MessageBox.Show("Seçili Olan Kaydı Silmek İstediğinize Emin Misiniz?", "Uyarı!", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                gridGarson.DeleteSelectedRows();
                worker.Commit();
                Listele();
            }
        }

        private void controlMenu_ButtonKapat(object sender, EventArgs e)
        {
            Close();
        }

        private void controlMenu_Load(object sender, EventArgs e)
        {

        }
    }
}