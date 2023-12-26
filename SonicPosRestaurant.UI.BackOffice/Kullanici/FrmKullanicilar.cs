using DevExpress.XtraEditors;
using SonicPosRestaurant.Business.Workers;
using SonicPosRestaurant.Entities.Enums;
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

namespace SonicPosRestaurant.UI.BackOffice.Kullanici
{
    public partial class FrmKullanicilar : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker = new RestaurantWorker();
        private Entities.Tables.Kullanici _entity;
        public FrmKullanicilar()
        {
            InitializeComponent();
            worker.KullaniciService.Load(null);
            gridControlKullanicilar.DataSource = worker.KullaniciService.BindingList();
            lookYetki.Properties.DataSource = Enum.GetValues(typeof(KullaniciRol));
        }

        void KullaniciBinding()
        {
            txtAdSoyad.DataBindings.Clear();
            txtKullaniciAdi.DataBindings.Clear();
            lookYetki.DataBindings.Clear();
            TxtAciklama.DataBindings.Clear();

            txtAdSoyad.DataBindings.Add("Text", _entity, "AdSoyad", false, DataSourceUpdateMode.OnPropertyChanged);
            txtKullaniciAdi.DataBindings.Add("Text", _entity, "KullaniciAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            lookYetki.DataBindings.Add("EditValue", _entity, "KullaniciRol", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtAciklama.DataBindings.Add("Text", _entity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void controlKullaniciMenu_EkleClick(object sender, EventArgs e)
        {
            _entity = new Entities.Tables.Kullanici();
            controlKullaniciMenu.KayıtAc = true;
            groupKullaniciBilgi.Visible = true;
            KullaniciBinding();
        }

        private void controlKullaniciMenu_DuzenleClick(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRow() == null)
            {
                return;
            }
            else
            {
                _entity = (Entities.Tables.Kullanici)gridView1.GetFocusedRow();
                controlKullaniciMenu.KayıtAc = true;
                groupKullaniciBilgi.Visible = true;
                txtKullaniciAdi.Enabled = false;
                txtAdSoyad.Enabled = false;
                KullaniciBinding();
            }
        }

        private void controlKullaniciMenu_SilClick(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRow() == null)
            {
                return;
            }
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Eminmisiniz?","Uyarı!",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                gridView1.DeleteSelectedRows();
            }
        }

        private void controlKullaniciMenu_KaydetClick(object sender, EventArgs e)
        {
            if (txtParola.Text!=txtParolaTekrar.Text)
            {
                if (!(String.IsNullOrEmpty(txtParola.Text) && txtKullaniciAdi.Enabled==false))
                {
                    MessageBox.Show("Girilen Parolalar Eşleşmemektedir!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (!(String.IsNullOrEmpty(txtParola.Text) && txtKullaniciAdi.Enabled == false))
                {
                    _entity.Parola =txtParola.Text;
                }
            }
            worker.KullaniciService.AddOrUpdate(_entity);
            worker.Commit();
            controlKullaniciMenu.KayıtAc = false;
            groupKullaniciBilgi.Visible = false;
            txtParola.Text = null;
            txtParolaTekrar=null;
        }

        private void controlKullaniciMenu_VazgecClick(object sender, EventArgs e)
        {
            _entity = null;
            controlKullaniciMenu.KayıtAc = false;
            groupKullaniciBilgi.Visible = false;
            txtParola.Text = null;
            txtParolaTekrar = null;
            txtAdSoyad.Enabled = true;
        }

        private void controlKullaniciMenu_KapatClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}