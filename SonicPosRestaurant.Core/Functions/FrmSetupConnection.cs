using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicPosRestaurant.Core.Functions
{
    public partial class FrmSetupConnection : DevExpress.XtraEditors.XtraForm
    {
        SqlConnectionStringBuilder ConnectionStringBuilder=new SqlConnectionStringBuilder();
        public bool Kaydedildi=false;
        public FrmSetupConnection()
        {
            InitializeComponent();
        }

        private void BaglantiCumleOlustur()
        {
            ConnectionStringBuilder.InitialCatalog = "master";
            ConnectionStringBuilder.DataSource = TxtServer.Text;
            if (chkWindows.Checked)
            {
                ConnectionStringBuilder.IntegratedSecurity = true;
            }
            else
            {
                ConnectionStringBuilder.UserID = TxtUser.Text;
                ConnectionStringBuilder.Password = TxtPassword.Text;
                ConnectionStringBuilder.IntegratedSecurity =false;
            }
        }

        private void chkSql_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSql.Checked)
            {
                TxtUser.Enabled = true;
                TxtPassword.Enabled = true;
            }
            else 
            {
                TxtUser.Enabled = false;
                TxtPassword.Enabled = false;
            }
        }

        private void BtnBaglantiTest_Click(object sender, EventArgs e)
        {
            BaglantiCumleOlustur();
            if (ConnectionStringInfo.Check(ConnectionStringBuilder.ConnectionString))
            {
                MessageBox.Show("Bağlantı Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bağlantı Başarısız", "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            BaglantiCumleOlustur();
            if (ConnectionStringInfo.Check(ConnectionStringBuilder.ConnectionString))
            {
                ConnectionStringBuilder.InitialCatalog = "SonicPOS-Restaurant";
                ConnectionStringInfo.Set(ConnectionStringBuilder.ConnectionString);
                Kaydedildi = true;
                Close();
            }
            else
            {
                MessageBox.Show("Bağlantı Başarısız", "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}