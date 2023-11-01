using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicPosRestaurant.UserControls
{
    public partial class ControlMenuKayit : DevExpress.XtraEditors.XtraUserControl
    {
        private bool KayitAc=false;
        [Category("İşlem Butonları")]
        public event EventHandler SecClick;
        [Category("İşlem Butonları")]
        public event EventHandler EkleClick;
        [Category("İşlem Butonları")]
        public event EventHandler DuzenleClick;
        [Category("İşlem Butonları")]
        public event EventHandler SilClick;
        [Category("İşlem Butonları")]
        public event EventHandler KaydetClick;
        [Category("İşlem Butonları")]
        public event EventHandler VazgecClick;
        [Category("İşlem Butonları")]
        public event EventHandler KapatClick;

        public LayoutVisibility SecVisibility {
            get
            {
                return layouItemSec.Visibility;        
            }
            set
            {
                layouItemSec.Visibility= value;
                Root.BestFit();
            }
        }

        public LayoutVisibility KapatVisibility
        {
            get
            {
                return layoutItemKapat.Visibility;
            }
            set
            {
                layoutItemKapat.Visibility = value;
                Root.BestFit();
            }
        }
        public bool KayıtAc
        {
            get
            {
                return KayitAc;
            }
            set
            {
                BtnEkle.Enabled = !value;
                btnDuzenle.Enabled = !value;
                btnSil.Enabled = !value;
                BtnSec.Enabled = !value;
                btnKapat.Enabled = !value;
                BtnKaydet.Enabled = value;
                btnVazgec.Enabled = value;
                KayitAc = value;
            }
        }
        public ControlMenuKayit()
        {
            InitializeComponent();
        }

        private void BtnSec_Click(object sender, EventArgs e)
        {
            SecClick?.Invoke(this,e);
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            EkleClick?.Invoke(this, e);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            DuzenleClick?.Invoke(this, e);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SilClick?.Invoke(this, e);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            KaydetClick?.Invoke(this, e);
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            VazgecClick?.Invoke(this, e);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
             KapatClick?.Invoke(this, e);
        }
    }
}
