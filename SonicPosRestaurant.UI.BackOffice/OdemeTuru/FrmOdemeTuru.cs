using DevExpress.XtraEditors;
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

namespace SonicPosRestaurant.UI.BackOffice.OdemeTuru
{
    public partial class FrmOdemeTuru : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker=new RestaurantWorker();
        public FrmOdemeTuru()
        {
            InitializeComponent();
            Listele();
        }

        void Listele()
        {
            worker.OdemeTuruService.Load(null,c=>c.OdemeTur);
            gridControlOdemeTuru.DataSource = worker.OdemeTuruService.BindingList();
        }

        private void controlMenu_ButtonEkle(object sender, EventArgs e)
        {
            FrmOdemeTuruIslem form=new FrmOdemeTuruIslem(new Entities.Tables.OdemeTuru());
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

        private void controlMenu_ButtonDuzenle(object sender, EventArgs e)
        {
            Entities.Tables.OdemeTuru entity =(Entities.Tables.OdemeTuru)gridOdemeTuru.GetFocusedRow();
            if (entity==null)
            {
                return; 
            }
            FrmOdemeTuruIslem form = new FrmOdemeTuruIslem(entity);
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Listele();
            }
        }

        private void controlMenu_ButtonSil(object sender, EventArgs e)
        {
            if (gridOdemeTuru.GetFocusedRow() == null)
            {
                return;
            }

            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Emin Misiniz?", "Uyarı!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridOdemeTuru.DeleteSelectedRows();
                worker.Commit();
                Listele();
            }
        }

        private void controlMenu_ButtonKapat(object sender, EventArgs e)
        {
            Close();
        }
    }
}