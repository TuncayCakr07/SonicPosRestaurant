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

namespace SonicPosRestaurant.UI.BackOffice.Musteri
{
    public partial class FrmMusteri : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker=new RestaurantWorker();
        public FrmMusteri()
        {
            InitializeComponent();
            listele();
         
        }
        void listele()
        {
            worker.MusteriService.Load(null);
            gridControlMusteri.DataSource = worker.MusteriService.BindingList();
        }
        private void controlMenu_ButtonEkle(object sender, EventArgs e)
        {
            FrmMusteriIslem form = new FrmMusteriIslem(new Entities.Tables.Musteri());
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                listele();
            }
        }

        private void controlMenu_ButtonGuncelle(object sender, EventArgs e)
        {
            listele();
        }

        private void controlMenu_ButtonDuzenle(object sender, EventArgs e)
        {
            if (gridMusteri.GetFocusedRow()==null)
            {
                return;
            }
            FrmMusteriIslem form = new FrmMusteriIslem((Entities.Tables.Musteri)gridMusteri.GetFocusedRow());
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                listele();
            }
        }
        private void controlMenu_ButtonSil(object sender, EventArgs e)
        {
            if (gridMusteri.GetFocusedRow() == null)
            {
                return;
            }

            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Emin Misiniz?", "Uyarı!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                worker.MusteriService.Delete((Entities.Tables.Musteri) gridMusteri.GetFocusedRow());
                //gridMusteri.DeleteSelectedRows();
                listele();
            }
        }

        private void controlMenu_ButtonKapat(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}