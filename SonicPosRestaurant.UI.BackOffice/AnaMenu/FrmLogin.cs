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

namespace SonicPosRestaurant.UI.BackOffice.AnaMenu
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void controlKullaniciGiris1_KullaniciKontrolEvent(object sender, UserControls.KullaniciKontrolEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (e.Kullanici == null)
                {
                    MessageBox.Show("Girilen Kullanıcı Bilgileri Hatalıdır!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Kullanıcı Girişi Başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmAnaMenu form = new FrmAnaMenu();
                    form.Show();
                    this.Hide();
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}