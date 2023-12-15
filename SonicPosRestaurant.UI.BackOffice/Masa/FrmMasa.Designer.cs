namespace SonicPosRestaurant.UI.BackOffice.Masa
{
    partial class FrmMasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.controlMenu = new SonicPosRestaurant.UserControls.ControlAnaMenuAlt();
            this.gridControlMasa = new DevExpress.XtraGrid.GridControl();
            this.gridMasa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKonum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKapasite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMasa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.controlMenu);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 670);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1309, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menü:";
            // 
            // controlMenu
            // 
            this.controlMenu.ButtonFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.controlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlMenu.Location = new System.Drawing.Point(3, 32);
            this.controlMenu.Name = "controlMenu";
            this.controlMenu.Size = new System.Drawing.Size(1303, 65);
            this.controlMenu.TabIndex = 0;
            this.controlMenu.ButtonEkle += new System.EventHandler(this.controlMenu_ButtonEkle);
            this.controlMenu.ButtonDuzenle += new System.EventHandler(this.controlMenu_ButtonDuzenle);
            this.controlMenu.ButtonSil += new System.EventHandler(this.controlMenu_ButtonSil);
            this.controlMenu.ButtonGuncelle += new System.EventHandler(this.controlMenu_ButtonGuncelle);
            this.controlMenu.ButtonKapat += new System.EventHandler(this.controlMenu_ButtonKapat);
            // 
            // gridControlMasa
            // 
            this.gridControlMasa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMasa.Location = new System.Drawing.Point(0, 75);
            this.gridControlMasa.MainView = this.gridMasa;
            this.gridControlMasa.Name = "gridControlMasa";
            this.gridControlMasa.Size = new System.Drawing.Size(1309, 695);
            this.gridControlMasa.TabIndex = 7;
            this.gridControlMasa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridMasa});
            // 
            // gridMasa
            // 
            this.gridMasa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasaAdi,
            this.colKonum,
            this.colKapasite,
            this.colAciklama});
            this.gridMasa.GridControl = this.gridControlMasa;
            this.gridMasa.Name = "gridMasa";
            // 
            // colMasaAdi
            // 
            this.colMasaAdi.Caption = "Masa Adı";
            this.colMasaAdi.FieldName = "Adi";
            this.colMasaAdi.MinWidth = 25;
            this.colMasaAdi.Name = "colMasaAdi";
            this.colMasaAdi.Visible = true;
            this.colMasaAdi.VisibleIndex = 0;
            this.colMasaAdi.Width = 319;
            // 
            // colKonum
            // 
            this.colKonum.Caption = "Konumu";
            this.colKonum.FieldName = "Konum.Adi";
            this.colKonum.MinWidth = 25;
            this.colKonum.Name = "colKonum";
            this.colKonum.Visible = true;
            this.colKonum.VisibleIndex = 1;
            this.colKonum.Width = 319;
            // 
            // colKapasite
            // 
            this.colKapasite.Caption = "Kapasite";
            this.colKapasite.FieldName = "Kapasite";
            this.colKapasite.MinWidth = 25;
            this.colKapasite.Name = "colKapasite";
            this.colKapasite.Visible = true;
            this.colKapasite.VisibleIndex = 2;
            this.colKapasite.Width = 114;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.MinWidth = 25;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 3;
            this.colAciklama.Width = 527;
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
            this.labelControl1.Size = new System.Drawing.Size(1309, 75);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Masalar";
            // 
            // FrmMasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 770);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridControlMasa);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmMasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masalar";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMasa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private UserControls.ControlAnaMenuAlt controlMenu;
        private DevExpress.XtraGrid.GridControl gridControlMasa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridMasa;
        private DevExpress.XtraGrid.Columns.GridColumn colMasaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colKonum;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colKapasite;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
    }
}