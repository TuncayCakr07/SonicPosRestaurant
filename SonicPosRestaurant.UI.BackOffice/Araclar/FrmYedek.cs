using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicPosRestaurant.UI.BackOffice.Araclar
{
    public partial class FrmYedek : DevExpress.XtraEditors.XtraForm
    {
        public FrmYedek()
        {
            InitializeComponent();
        }

        public static void Backup()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Veri yedek dosyası|0.bak";
            save.FileName = "Sonic_Pos_DataBaseBackup_ " + DateTime.Now.ToShortDateString();
            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    if (File.Exists(save.FileName))
                    {
                        File.Delete(save.FileName);
                    }
                    var dbHedef = save.FileName;
                    string dbKaynak = "SonicPOS-Restaurant";
                    using (var db = new SonicPosRestaurant.DataAccess.Contexts.Restaurant.RestaurantContext())
                    {
                        try
                        {
                            var cmd = @"BACKUP DATABASE [" + dbKaynak + "] TO DISK='" + dbHedef + "'";
                            db.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, cmd);
                            MessageBox.Show("Yedekleme İşlemi Tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Yedekleme işlemi sırasında bir hata oluştu:\n" + ex.ToString());
                            MessageBox.Show("Yedekleme işlemi sırasında bir hata oluştu. Hata mesajı loglara yazıldı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Yedekleme İşlemi Tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void BtnYedekle_Click(object sender, EventArgs e)
        {
            Backup(); 
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + @"\Restore.exe");
            Application.Exit();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}