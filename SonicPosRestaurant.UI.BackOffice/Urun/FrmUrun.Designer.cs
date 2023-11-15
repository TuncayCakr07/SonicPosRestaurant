namespace SonicPosRestaurant.UI.BackOffice.Urun
{
    partial class FrmUrun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrun));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlUrunler = new DevExpress.XtraGrid.GridControl();
            this.gridUrun = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFotograf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.picFotograf = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrungrup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFotografEkle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BtnFotografEkle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.controlMenu = new SonicPosRestaurant.UserControls.ControlAnaMenuAlt();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotograf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFotografEkle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ürünler";
            // 
            // gridControlUrunler
            // 
            this.gridControlUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUrunler.Location = new System.Drawing.Point(0, 75);
            this.gridControlUrunler.MainView = this.gridUrun;
            this.gridControlUrunler.Name = "gridControlUrunler";
            this.gridControlUrunler.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.BtnFotografEkle,
            this.picFotograf});
            this.gridControlUrunler.Size = new System.Drawing.Size(1309, 595);
            this.gridControlUrunler.TabIndex = 2;
            this.gridControlUrunler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridUrun});
            // 
            // gridUrun
            // 
            this.gridUrun.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFotograf,
            this.colBarkod,
            this.colAdi,
            this.colUrungrup,
            this.colFotografEkle});
            this.gridUrun.GridControl = this.gridControlUrunler;
            this.gridUrun.Name = "gridUrun";
            this.gridUrun.RowHeight = 100;
            // 
            // colFotograf
            // 
            this.colFotograf.Caption = "Fotograf";
            this.colFotograf.ColumnEdit = this.picFotograf;
            this.colFotograf.FieldName = "Fotograf";
            this.colFotograf.MaxWidth = 150;
            this.colFotograf.MinWidth = 150;
            this.colFotograf.Name = "colFotograf";
            this.colFotograf.OptionsColumn.AllowEdit = false;
            this.colFotograf.Visible = true;
            this.colFotograf.VisibleIndex = 0;
            this.colFotograf.Width = 150;
            // 
            // picFotograf
            // 
            this.picFotograf.Name = "picFotograf";
            this.picFotograf.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // colBarkod
            // 
            this.colBarkod.Caption = "Barkodu";
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.MinWidth = 25;
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.OptionsColumn.AllowEdit = false;
            this.colBarkod.Visible = true;
            this.colBarkod.VisibleIndex = 1;
            this.colBarkod.Width = 94;
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Ürün Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.MinWidth = 25;
            this.colAdi.Name = "colAdi";
            this.colAdi.OptionsColumn.AllowEdit = false;
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 2;
            this.colAdi.Width = 94;
            // 
            // colUrungrup
            // 
            this.colUrungrup.Caption = "Kategori";
            this.colUrungrup.FieldName = "UrunGrup.Adi";
            this.colUrungrup.MinWidth = 25;
            this.colUrungrup.Name = "colUrungrup";
            this.colUrungrup.OptionsColumn.AllowEdit = false;
            this.colUrungrup.Visible = true;
            this.colUrungrup.VisibleIndex = 3;
            this.colUrungrup.Width = 94;
            // 
            // colFotografEkle
            // 
            this.colFotografEkle.Caption = "Fotograf Ekle";
            this.colFotografEkle.ColumnEdit = this.BtnFotografEkle;
            this.colFotografEkle.MaxWidth = 80;
            this.colFotografEkle.MinWidth = 80;
            this.colFotografEkle.Name = "colFotografEkle";
            this.colFotografEkle.Visible = true;
            this.colFotografEkle.VisibleIndex = 4;
            this.colFotografEkle.Width = 80;
            // 
            // BtnFotografEkle
            // 
            this.BtnFotografEkle.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.BtnFotografEkle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.BtnFotografEkle.Name = "BtnFotografEkle";
            this.BtnFotografEkle.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.BtnFotografEkle.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BtnFotografEkle_ButtonClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.controlMenu);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 670);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1309, 100);
            this.groupBox1.TabIndex = 1;
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
            // FrmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 770);
            this.Controls.Add(this.gridControlUrunler);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmUrun";
            this.Text = "Ürünler";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotograf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFotografEkle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControlUrunler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridUrun;
        private DevExpress.XtraGrid.Columns.GridColumn colFotograf;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colUrungrup;
        private DevExpress.XtraGrid.Columns.GridColumn colFotografEkle;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit BtnFotografEkle;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit picFotograf;
        private System.Windows.Forms.GroupBox groupBox1;
        private UserControls.ControlAnaMenuAlt controlMenu;
    }
}