namespace SonicPosRestaurant.UI.BackOffice.Kullanici
{
    partial class FrmKullanicilar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullanicilar));
            this.controlKullaniciMenu = new SonicPosRestaurant.UserControls.ControlMenuKayit();
            this.gridControlKullanicilar = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKullaniciAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetki = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupKullaniciBilgi = new DevExpress.XtraEditors.GroupControl();
            this.lookYetki = new DevExpress.XtraEditors.LookUpEdit();
            this.TxtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.txtParolaTekrar = new DevExpress.XtraEditors.TextEdit();
            this.txtParola = new DevExpress.XtraEditors.TextEdit();
            this.txtAdSoyad = new DevExpress.XtraEditors.TextEdit();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKullanicilar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupKullaniciBilgi)).BeginInit();
            this.groupKullaniciBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookYetki.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParolaTekrar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // controlKullaniciMenu
            // 
            this.controlKullaniciMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlKullaniciMenu.KapatVisibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            this.controlKullaniciMenu.KayıtAc = false;
            this.controlKullaniciMenu.Location = new System.Drawing.Point(0, 595);
            this.controlKullaniciMenu.Name = "controlKullaniciMenu";
            this.controlKullaniciMenu.SecVisibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            this.controlKullaniciMenu.Size = new System.Drawing.Size(893, 62);
            this.controlKullaniciMenu.TabIndex = 0;
            this.controlKullaniciMenu.EkleClick += new System.EventHandler(this.controlKullaniciMenu_EkleClick);
            this.controlKullaniciMenu.DuzenleClick += new System.EventHandler(this.controlKullaniciMenu_DuzenleClick);
            this.controlKullaniciMenu.SilClick += new System.EventHandler(this.controlKullaniciMenu_SilClick);
            this.controlKullaniciMenu.KaydetClick += new System.EventHandler(this.controlKullaniciMenu_KaydetClick);
            this.controlKullaniciMenu.VazgecClick += new System.EventHandler(this.controlKullaniciMenu_VazgecClick);
            this.controlKullaniciMenu.KapatClick += new System.EventHandler(this.controlKullaniciMenu_KapatClick);
            // 
            // gridControlKullanicilar
            // 
            this.gridControlKullanicilar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlKullanicilar.Location = new System.Drawing.Point(0, 349);
            this.gridControlKullanicilar.MainView = this.gridView1;
            this.gridControlKullanicilar.Name = "gridControlKullanicilar";
            this.gridControlKullanicilar.Size = new System.Drawing.Size(893, 246);
            this.gridControlKullanicilar.TabIndex = 1;
            this.gridControlKullanicilar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKullaniciAdi,
            this.colAdSoyad,
            this.colAciklama,
            this.colYetki});
            this.gridView1.GridControl = this.gridControlKullanicilar;
            this.gridView1.Name = "gridView1";
            // 
            // colKullaniciAdi
            // 
            this.colKullaniciAdi.Caption = "Kullanıcı Adı";
            this.colKullaniciAdi.FieldName = "KullaniciAdi";
            this.colKullaniciAdi.MinWidth = 25;
            this.colKullaniciAdi.Name = "colKullaniciAdi";
            this.colKullaniciAdi.Visible = true;
            this.colKullaniciAdi.VisibleIndex = 0;
            this.colKullaniciAdi.Width = 215;
            // 
            // colAdSoyad
            // 
            this.colAdSoyad.Caption = "Ad Soyad";
            this.colAdSoyad.FieldName = "AdSoyad";
            this.colAdSoyad.MinWidth = 25;
            this.colAdSoyad.Name = "colAdSoyad";
            this.colAdSoyad.Visible = true;
            this.colAdSoyad.VisibleIndex = 1;
            this.colAdSoyad.Width = 215;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.MinWidth = 25;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 2;
            this.colAciklama.Width = 276;
            // 
            // colYetki
            // 
            this.colYetki.Caption = "Yetkisi";
            this.colYetki.FieldName = "KullaniciRol";
            this.colYetki.MinWidth = 25;
            this.colYetki.Name = "colYetki";
            this.colYetki.Visible = true;
            this.colYetki.VisibleIndex = 3;
            this.colYetki.Width = 157;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.ImageOptions.Image")));
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(893, 75);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Kullanıcılar";
            // 
            // groupKullaniciBilgi
            // 
            this.groupKullaniciBilgi.Controls.Add(this.lookYetki);
            this.groupKullaniciBilgi.Controls.Add(this.TxtAciklama);
            this.groupKullaniciBilgi.Controls.Add(this.txtParolaTekrar);
            this.groupKullaniciBilgi.Controls.Add(this.txtParola);
            this.groupKullaniciBilgi.Controls.Add(this.txtAdSoyad);
            this.groupKullaniciBilgi.Controls.Add(this.txtKullaniciAdi);
            this.groupKullaniciBilgi.Controls.Add(this.labelControl9);
            this.groupKullaniciBilgi.Controls.Add(this.labelControl3);
            this.groupKullaniciBilgi.Controls.Add(this.labelControl4);
            this.groupKullaniciBilgi.Controls.Add(this.labelControl2);
            this.groupKullaniciBilgi.Controls.Add(this.labelControl7);
            this.groupKullaniciBilgi.Controls.Add(this.labelControl6);
            this.groupKullaniciBilgi.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupKullaniciBilgi.Location = new System.Drawing.Point(0, 75);
            this.groupKullaniciBilgi.Name = "groupKullaniciBilgi";
            this.groupKullaniciBilgi.Size = new System.Drawing.Size(893, 274);
            this.groupKullaniciBilgi.TabIndex = 9;
            this.groupKullaniciBilgi.Text = "Kullanıcı Bilgisi";
            this.groupKullaniciBilgi.Visible = false;
            // 
            // lookYetki
            // 
            this.lookYetki.Location = new System.Drawing.Point(152, 182);
            this.lookYetki.Name = "lookYetki";
            this.lookYetki.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookYetki.Properties.NullText = "Lütfen Bir Telefon Tipi Seçiniz..";
            this.lookYetki.Properties.ShowFooter = false;
            this.lookYetki.Size = new System.Drawing.Size(728, 22);
            this.lookYetki.TabIndex = 0;
            // 
            // TxtAciklama
            // 
            this.TxtAciklama.Location = new System.Drawing.Point(152, 214);
            this.TxtAciklama.Name = "TxtAciklama";
            this.TxtAciklama.Size = new System.Drawing.Size(729, 52);
            this.TxtAciklama.TabIndex = 2;
            // 
            // txtParolaTekrar
            // 
            this.txtParolaTekrar.Location = new System.Drawing.Point(152, 146);
            this.txtParolaTekrar.Name = "txtParolaTekrar";
            this.txtParolaTekrar.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParolaTekrar.Properties.Appearance.Options.UseFont = true;
            this.txtParolaTekrar.Properties.PasswordChar = '*';
            this.txtParolaTekrar.Size = new System.Drawing.Size(432, 24);
            this.txtParolaTekrar.TabIndex = 1;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(152, 113);
            this.txtParola.Name = "txtParola";
            this.txtParola.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParola.Properties.Appearance.Options.UseFont = true;
            this.txtParola.Properties.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(432, 24);
            this.txtParola.TabIndex = 1;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(151, 48);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.Properties.Appearance.Options.UseFont = true;
            this.txtAdSoyad.Size = new System.Drawing.Size(729, 24);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(152, 78);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Properties.Appearance.Options.UseFont = true;
            this.txtKullaniciAdi.Size = new System.Drawing.Size(729, 24);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseTextOptions = true;
            this.labelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl9.Location = new System.Drawing.Point(5, 214);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(141, 51);
            this.labelControl9.TabIndex = 2;
            this.labelControl9.Text = "Açıklama:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl3.Location = new System.Drawing.Point(6, 182);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(140, 20);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Kullanıcı Yetki:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl4.Location = new System.Drawing.Point(5, 50);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(140, 20);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Ad Soyad:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(6, 148);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(140, 20);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Parola Tekrar:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl7.Location = new System.Drawing.Point(6, 80);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(140, 20);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "Kullanıcı Adı:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl6.Location = new System.Drawing.Point(6, 114);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(140, 20);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Parola:";
            // 
            // FrmKullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 657);
            this.Controls.Add(this.gridControlKullanicilar);
            this.Controls.Add(this.groupKullaniciBilgi);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.controlKullaniciMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FrmKullanicilar.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKullanicilar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKullanicilar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupKullaniciBilgi)).EndInit();
            this.groupKullaniciBilgi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookYetki.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParolaTekrar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public UserControls.ControlMenuKayit controlKullaniciMenu;
        public DevExpress.XtraGrid.GridControl gridControlKullanicilar;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colKullaniciAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colAdSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colYetki;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraEditors.GroupControl groupKullaniciBilgi;
        private DevExpress.XtraEditors.LookUpEdit lookYetki;
        private DevExpress.XtraEditors.MemoEdit TxtAciklama;
        private DevExpress.XtraEditors.TextEdit txtParola;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtParolaTekrar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtAdSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}