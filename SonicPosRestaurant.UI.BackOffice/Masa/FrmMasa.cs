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
using SonicPosRestaurant.UserControls;

namespace SonicPosRestaurant.UI.BackOffice.Masa
{
    public partial class FrmMasa : DevExpress.XtraEditors.XtraForm
    {
         RestaurantWorker worker=new RestaurantWorker();
        public FrmMasa()
        {
            InitializeComponent();
            Listele();
        }
        void Listele()
        {
            worker.MasaService.Load(null,c=>c.Konum);
            gridControlMasa.DataSource = worker.MasaService.BindingList();
        }

        private void controlMenu_ButtonEkle(object sender, EventArgs e)
        {
            FrmMasaIslem form=new FrmMasaIslem(new Entities.Tables.Masa());
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Listele();
            } 
        }
        private void controlMenu_ButtonDuzenle(object sender, EventArgs e)
        {
            if (gridMasa.GetFocusedRow() == null)
            {
                return;
            }
            FrmMasaIslem form = new FrmMasaIslem((Entities.Tables.Masa)gridMasa.GetFocusedRow());
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Listele();
            }
        }

        private void controlMenu_ButtonSil(object sender, EventArgs e)
        {
            if (gridMasa.GetFocusedRow() == null)
            {
                return;
            }

            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Emin Misiniz?", "Uyarı!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridMasa.DeleteSelectedRows();
                worker.Commit();
                Listele();
            }
        }
        private void controlMenu_ButtonGuncelle(object sender, EventArgs e)
        {
            Listele();
        }

        private void controlMenu_ButtonKapat(object sender, EventArgs e)
        {
            Close();
        }
    }
}