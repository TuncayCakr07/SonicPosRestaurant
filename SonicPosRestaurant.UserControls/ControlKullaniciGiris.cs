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
using SonicPosRestaurant.UserControls;

namespace SonicPosRestaurant.UserControls
{
    public partial class controlKullaniciGiris : DevExpress.XtraEditors.XtraUserControl
    {
        private RestaurantWorker worker;
        private Kullanici kullaniciEntity;
        public event EventHandler<KullaniciKontrolEventArgs> KullaniciKontrolEvent;
        public Action KapatButton;

        public RestaurantWorker RestaurantWorker
        {
            get
            {
                if (worker == null)
                {
                    worker = new RestaurantWorker();
                }
                return worker;
            }
        }
        public controlKullaniciGiris()
        {
            InitializeComponent();
        }

        private void bGiris_Click(object sender, EventArgs e)
        {
            kullaniciEntity = RestaurantWorker.KullaniciService.KullaniciKontrol(txtKullaniciAdi.Text, txtParola.Text);
            KullaniciKontrolEvent?.Invoke(sender, new KullaniciKontrolEventArgs
            {
                Kullanici = kullaniciEntity
            });
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            KapatButton();
        }
    }
}