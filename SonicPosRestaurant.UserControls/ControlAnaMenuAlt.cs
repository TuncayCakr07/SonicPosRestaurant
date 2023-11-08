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

namespace SonicPosRestaurant.UserControls
{
    public partial class ControlAnaMenuAlt : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler ButtonEkle;
        public event EventHandler ButtonDuzenle;
        public event EventHandler ButtonSil;
        public event EventHandler ButtonGuncelle;
        public event EventHandler ButtonKapat;
        private Font _buttonFont=new Font("Century Gothic",9,FontStyle.Bold);
        public Font ButtonFont { get 
            {
              return _buttonFont;
            }
            set 
            { 
              BtnEkle.Font = value;
              BtnDuzenle.Font = value;
              BtnSil.Font = value;
              BtnGuncelle.Font = value;
              BtnKapat.Font = value;
              _buttonFont = value;
            } }
        public ControlAnaMenuAlt()
        {
            InitializeComponent();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            ButtonEkle?.Invoke(this, e);
        }

        private void BtnDuzenle_Click(object sender, EventArgs e)
        {
            ButtonDuzenle?.Invoke(this, e);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            ButtonSil?.Invoke(this, e);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            ButtonGuncelle?.Invoke(this, e);
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            ButtonKapat?.Invoke(this, e);
        }
    }
}
