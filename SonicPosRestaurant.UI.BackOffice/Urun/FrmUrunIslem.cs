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

namespace SonicPosRestaurant.UI.BackOffice.Urun
{
    public partial class FrmUrunIslem : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker = new RestaurantWorker();
        private Entities.Tables.Urun _urunEntity;
        private Porsiyon _porsiyonEntity;
        private EkMalzeme _ekMalzemeEntity;
        public FrmUrunIslem(Entities.Tables.Urun urunEntity)
        {
            InitializeComponent();
            _urunEntity = urunEntity;
            if (urunEntity.Id==Guid.Empty)
            {
                _urunEntity.Id = Guid.NewGuid();
            }
        }
        void UrunBinding()
        {
            TxtBarkod.DataBindings.Clear();
            TxtUrunAdi.DataBindings.Clear();
            TxtUrunAciklama.DataBindings.Clear();
            picUrunFoto.DataBindings.Clear();
            TxtBarkod.DataBindings.Add("Text",_urunEntity,"Barkod",false,DataSourceUpdateMode.OnPropertyChanged);
            TxtUrunAdi.DataBindings.Add("Text",_urunEntity,"Adi",false,DataSourceUpdateMode.OnPropertyChanged);
            TxtUrunAciklama.DataBindings.Add("Text",_urunEntity,"Aciklama",false,DataSourceUpdateMode.OnPropertyChanged);
            picUrunFoto.DataBindings.Add("Image",_urunEntity,"Fotograf",false,DataSourceUpdateMode.OnPropertyChanged);
        }
        void PorsiyonBinding()
        {
            TxtPorsiyonAdi.DataBindings.Clear();
            TxtPorsiyonFiyat.DataBindings.Clear();
            TxtEkMalzemeCarpan.DataBindings.Clear();
            TxtPorsiyonAciklama.DataBindings.Clear();
            TxtPorsiyonAdi.DataBindings.Add("Text", _porsiyonEntity, "Adi", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtPorsiyonFiyat.DataBindings.Add("Value", _porsiyonEntity, "Fiyat", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtEkMalzemeCarpan.DataBindings.Add("Value", _porsiyonEntity, "EkMalzemeCarpan", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtPorsiyonAciklama.DataBindings.Add("Text", _porsiyonEntity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        void EkMalzemeBinding()
        {
            TxtMalzemeAdi.DataBindings.Clear();
            TxtMalzemeFiyati.DataBindings.Clear();
            TxtMalzemeAciklama.DataBindings.Clear();
            TxtMalzemeAdi.DataBindings.Add("Text",_ekMalzemeEntity,"Adi",false, DataSourceUpdateMode.OnPropertyChanged);
            TxtMalzemeFiyati.DataBindings.Add("Value",_ekMalzemeEntity,"Fiyat",false, DataSourceUpdateMode.OnPropertyChanged);
            TxtMalzemeAciklama.DataBindings.Add("Text",_ekMalzemeEntity,"Aciklama",false, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}