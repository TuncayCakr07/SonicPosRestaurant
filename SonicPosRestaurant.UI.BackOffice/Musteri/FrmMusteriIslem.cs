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
using SonicPosRestaurant.Entities.Tables;

namespace SonicPosRestaurant.UI.BackOffice.Musteri
{
    public partial class FrmMusteriIslem : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker=new RestaurantWorker();
        Entities.Tables.Musteri _musteriEntity;
        Entities.Tables.Telefon _telefonEntity;
        Adres _adresEntity;
        public FrmMusteriIslem(Entities.Tables.Musteri musteriEntity)
        {
            InitializeComponent();
            _musteriEntity = musteriEntity;
            if (_musteriEntity.Id==Guid.Empty)
            {
                _musteriEntity.Id = Guid.NewGuid();
            }
            worker.TelefonService.Load(c => c.MusteriId == _musteriEntity.Id);
            gridControlTelefon.DataSource = worker.TelefonService.BindingList();

            worker.AdresService.Load(c=>c.MusteriId== _musteriEntity.Id);
            gridControlAdres.DataSource = worker.AdresService.BindingList();
            MusteriBinding();
        }
        void MusteriBinding()
        {
            TxtMusteriAdi.DataBindings.Clear();
            TxtMusteriSoyadi.DataBindings.Clear();
            TxtSirketAdi.DataBindings.Clear();
            TxtMusteriAciklama.DataBindings.Clear();

            TxtMusteriAdi.DataBindings.Add("Text",_musteriEntity,"Adi",false,DataSourceUpdateMode.OnPropertyChanged);
            TxtMusteriSoyadi.DataBindings.Add("Text",_musteriEntity,"Soyadi",false,DataSourceUpdateMode.OnPropertyChanged);
            TxtSirketAdi.DataBindings.Add("Text",_musteriEntity, "Sirket", false,DataSourceUpdateMode.OnPropertyChanged);
            TxtMusteriAciklama.DataBindings.Add("Text",_musteriEntity, "Aciklama", false,DataSourceUpdateMode.OnPropertyChanged);
        }
        void TelefonBinding()
        {
            TxtTelefonNumarasi.DataBindings.Clear();
            TxtTelefonAciklama.DataBindings.Clear();

            TxtTelefonNumarasi.DataBindings.Add("Text", _telefonEntity, "Telefonu", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtTelefonAciklama.DataBindings.Add("Text", _telefonEntity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        void AdresBinding()
        {
            TxtIl.DataBindings.Clear();
            TxtIlce.DataBindings.Clear();
            TxtSemt.DataBindings.Clear();
            TxtAdres.DataBindings.Clear();

            TxtIl.DataBindings.Add("Text", _adresEntity, "Il", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtIlce.DataBindings.Add("Text", _adresEntity, "Ilce", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtSemt.DataBindings.Add("Text", _adresEntity, "Semt", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtAdres.DataBindings.Add("Text", _adresEntity, "Adres", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void controlMenuTelefon_EkleClick(object sender, EventArgs e)
        {
            _telefonEntity = new Telefon();
            _telefonEntity.MusteriId = _musteriEntity.Id;
            controlMenuTelefon.KayıtAc = true;
            controlMenuTelefon.Visible = true;
            TelefonBinding();
        }

        private void controlMenuTelefon_DuzenleClick(object sender, EventArgs e)
        {
            _telefonEntity=(Telefon)gridTelefon.GetFocusedRow();
            controlMenuTelefon.KayıtAc=true;
            controlMenuTelefon.Visible = true;
            TelefonBinding();
        }

        private void controlMenuTelefon_SilClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Kaydı Silmek İstediğinize Emin misiniz?","Uyarı!",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                gridTelefon.DeleteSelectedRows();
            }
        }

        private void controlMenuTelefon_KaydetClick(object sender, EventArgs e)
        {
            worker.TelefonService.AddOrUpdate(_telefonEntity);
            controlMenuTelefon.KayıtAc=false;
            groupTelefonBilgi.Visible = false;
        }

        private void controlMenuTelefon_VazgecClick(object sender, EventArgs e)
        {
            controlMenuTelefon.KayıtAc = false;
            groupTelefonBilgi.Visible = false;
        }

        private void controlMenuAdres_EkleClick(object sender, EventArgs e)
        {
            controlMenuAdres.KayıtAc = true;
            groupAdresBilgi.Visible = true;
            _adresEntity = new Adres();
            _adresEntity.MusteriId = _musteriEntity.Id;
            AdresBinding();
        }

        private void controlMenuAdres_DuzenleClick(object sender, EventArgs e)
        {
            controlMenuAdres.KayıtAc = true;
            groupAdresBilgi.Visible = true;
            _adresEntity = (Adres)gridAdres.GetFocusedRow();
            AdresBinding();
        }

        private void controlMenuAdres_SilClick(object sender, EventArgs e)
        {

            if (MessageBox.Show("Seçili Olan Kaydı Silmek İstediğinize Emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridAdres.DeleteSelectedRows();
            }
        }

        private void controlMenuAdres_KaydetClick(object sender, EventArgs e)
        {
            worker.AdresService.AddOrUpdate(_adresEntity);
            controlMenuAdres.KayıtAc = false;
            groupAdresBilgi.Visible = false;
        }

        private void controlMenuAdres_VazgecClick(object sender, EventArgs e)
        {
            controlMenuAdres.KayıtAc = false;
            groupAdresBilgi.Visible = false;
        }
    }
}