namespace SonicPosRestaurant.UI.BackOffice.AnaMenu
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.controlKullaniciGiris1 = new SonicPosRestaurant.UserControls.controlKullaniciGiris();
            this.SuspendLayout();
            // 
            // controlKullaniciGiris1
            // 
            this.controlKullaniciGiris1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlKullaniciGiris1.Location = new System.Drawing.Point(0, 0);
            this.controlKullaniciGiris1.Name = "controlKullaniciGiris1";
            this.controlKullaniciGiris1.Size = new System.Drawing.Size(596, 425);
            this.controlKullaniciGiris1.TabIndex = 0;
            this.controlKullaniciGiris1.KullaniciKontrolEvent += new System.EventHandler<SonicPosRestaurant.UserControls.KullaniciKontrolEventArgs>(this.controlKullaniciGiris1_KullaniciKontrolEvent);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 425);
            this.Controls.Add(this.controlKullaniciGiris1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FrmLogin.IconOptions.Image")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SonicPos Cafe-Restaurant Otomasyonu";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.controlKullaniciGiris controlKullaniciGiris1;
    }
}