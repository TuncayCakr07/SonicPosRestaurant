namespace SonicPosRestaurant.UI.BackOffice.Tanim
{
    partial class FrmTanim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTanim));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupTanimBilgi = new DevExpress.XtraEditors.GroupControl();
            this.TxtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.TxtTanim = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ControlMenu = new DevExpress.XtraEditors.GroupControl();
            this.controlMenuKayit = new SonicPosRestaurant.UserControls.ControlMenuKayit();
            this.gridControlTanim = new DevExpress.XtraGrid.GridControl();
            this.gridTanim = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTanim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupTanimBilgi)).BeginInit();
            this.groupTanimBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTanim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlMenu)).BeginInit();
            this.ControlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTanim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTanim)).BeginInit();
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
            this.labelControl1.Size = new System.Drawing.Size(717, 75);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tanım İşlemleri";
            // 
            // groupTanimBilgi
            // 
            this.groupTanimBilgi.Controls.Add(this.TxtAciklama);
            this.groupTanimBilgi.Controls.Add(this.TxtTanim);
            this.groupTanimBilgi.Controls.Add(this.labelControl3);
            this.groupTanimBilgi.Controls.Add(this.labelControl2);
            this.groupTanimBilgi.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupTanimBilgi.Location = new System.Drawing.Point(0, 75);
            this.groupTanimBilgi.Name = "groupTanimBilgi";
            this.groupTanimBilgi.Size = new System.Drawing.Size(717, 174);
            this.groupTanimBilgi.TabIndex = 2;
            this.groupTanimBilgi.Text = "Tanım İşlemleri";
            this.groupTanimBilgi.Visible = false;
            // 
            // TxtAciklama
            // 
            this.TxtAciklama.Location = new System.Drawing.Point(120, 62);
            this.TxtAciklama.Name = "TxtAciklama";
            this.TxtAciklama.Size = new System.Drawing.Size(585, 93);
            this.TxtAciklama.TabIndex = 3;
            // 
            // TxtTanim
            // 
            this.TxtTanim.Location = new System.Drawing.Point(120, 34);
            this.TxtTanim.Name = "TxtTanim";
            this.TxtTanim.Size = new System.Drawing.Size(585, 22);
            this.TxtTanim.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl3.Location = new System.Drawing.Point(5, 62);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(109, 93);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Açıklama:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(5, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(109, 20);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tanim:";
            // 
            // ControlMenu
            // 
            this.ControlMenu.Controls.Add(this.controlMenuKayit);
            this.ControlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlMenu.Location = new System.Drawing.Point(0, 249);
            this.ControlMenu.Name = "ControlMenu";
            this.ControlMenu.Size = new System.Drawing.Size(717, 100);
            this.ControlMenu.TabIndex = 3;
            this.ControlMenu.Text = "Menü";
            // 
            // controlMenuKayit
            // 
            this.controlMenuKayit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlMenuKayit.KapatVisibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            this.controlMenuKayit.KayıtAc = false;
            this.controlMenuKayit.Location = new System.Drawing.Point(2, 28);
            this.controlMenuKayit.Name = "controlMenuKayit";
            this.controlMenuKayit.SecVisibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            this.controlMenuKayit.Size = new System.Drawing.Size(713, 70);
            this.controlMenuKayit.TabIndex = 0;
            this.controlMenuKayit.SecClick += new System.EventHandler(this.controlMenuKayit_SecClick);
            this.controlMenuKayit.EkleClick += new System.EventHandler(this.controlMenuKayit_EkleClick);
            this.controlMenuKayit.DuzenleClick += new System.EventHandler(this.controlMenuKayit_DuzenleClick);
            this.controlMenuKayit.SilClick += new System.EventHandler(this.controlMenuKayit_SilClick);
            this.controlMenuKayit.KaydetClick += new System.EventHandler(this.controlMenuKayit_KaydetClick);
            this.controlMenuKayit.VazgecClick += new System.EventHandler(this.controlMenuKayit_VazgecClick);
            this.controlMenuKayit.KapatClick += new System.EventHandler(this.controlMenuKayit_KapatClick);
            // 
            // gridControlTanim
            // 
            this.gridControlTanim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTanim.Location = new System.Drawing.Point(0, 349);
            this.gridControlTanim.MainView = this.gridTanim;
            this.gridControlTanim.Name = "gridControlTanim";
            this.gridControlTanim.Size = new System.Drawing.Size(717, 331);
            this.gridControlTanim.TabIndex = 4;
            this.gridControlTanim.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridTanim});
            // 
            // gridTanim
            // 
            this.gridTanim.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTanim,
            this.colAciklama});
            this.gridTanim.GridControl = this.gridControlTanim;
            this.gridTanim.Name = "gridTanim";
            this.gridTanim.OptionsView.ShowAutoFilterRow = true;
            this.gridTanim.OptionsView.ShowGroupPanel = false;
            // 
            // colTanim
            // 
            this.colTanim.Caption = "Tanım";
            this.colTanim.FieldName = "Adi";
            this.colTanim.MinWidth = 25;
            this.colTanim.Name = "colTanim";
            this.colTanim.OptionsColumn.AllowEdit = false;
            this.colTanim.Visible = true;
            this.colTanim.VisibleIndex = 0;
            this.colTanim.Width = 94;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.MinWidth = 25;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 1;
            this.colAciklama.Width = 94;
            // 
            // FrmTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 680);
            this.Controls.Add(this.gridControlTanim);
            this.Controls.Add(this.ControlMenu);
            this.Controls.Add(this.groupTanimBilgi);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FrmTanim.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTanim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanımlar";
            ((System.ComponentModel.ISupportInitialize)(this.groupTanimBilgi)).EndInit();
            this.groupTanimBilgi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTanim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlMenu)).EndInit();
            this.ControlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTanim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTanim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupTanimBilgi;
        private DevExpress.XtraEditors.MemoEdit TxtAciklama;
        private DevExpress.XtraEditors.TextEdit TxtTanim;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl ControlMenu;
        private UserControls.ControlMenuKayit controlMenuKayit;
        private DevExpress.XtraGrid.GridControl gridControlTanim;
        private DevExpress.XtraGrid.Views.Grid.GridView gridTanim;
        private DevExpress.XtraGrid.Columns.GridColumn colTanim;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
    }
}