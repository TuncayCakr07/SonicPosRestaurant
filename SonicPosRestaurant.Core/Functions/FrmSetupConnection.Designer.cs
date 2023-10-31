namespace SonicPosRestaurant.Core.Functions
{
    partial class FrmSetupConnection
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSetupConnection));
            this.chkWindows = new DevExpress.XtraEditors.CheckButton();
            this.chkSql = new DevExpress.XtraEditors.CheckButton();
            this.TxtServer = new DevExpress.XtraEditors.TextEdit();
            this.TxtUser = new DevExpress.XtraEditors.TextEdit();
            this.TxtPassword = new DevExpress.XtraEditors.TextEdit();
            this.BtnBaglantiTest = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TxtServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chkWindows
            // 
            this.chkWindows.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkWindows.Appearance.Options.UseFont = true;
            this.chkWindows.Checked = true;
            this.chkWindows.GroupIndex = 1;
            this.chkWindows.ImageOptions.ImageIndex = 1;
            this.chkWindows.ImageOptions.ImageList = this.ımageList1;
            this.chkWindows.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.chkWindows.Location = new System.Drawing.Point(12, 12);
            this.chkWindows.Name = "chkWindows";
            this.chkWindows.Size = new System.Drawing.Size(209, 208);
            this.chkWindows.TabIndex = 0;
            this.chkWindows.Text = "Windows Oturumu";
            // 
            // chkSql
            // 
            this.chkSql.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkSql.Appearance.Options.UseFont = true;
            this.chkSql.GroupIndex = 1;
            this.chkSql.ImageOptions.ImageIndex = 0;
            this.chkSql.ImageOptions.ImageList = this.ımageList1;
            this.chkSql.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.chkSql.Location = new System.Drawing.Point(227, 12);
            this.chkSql.Name = "chkSql";
            this.chkSql.Size = new System.Drawing.Size(209, 208);
            this.chkSql.TabIndex = 1;
            this.chkSql.TabStop = false;
            this.chkSql.Text = "SQL Server Oturumu";
            this.chkSql.CheckedChanged += new System.EventHandler(this.chkSql_CheckedChanged);
            // 
            // TxtServer
            // 
            this.TxtServer.Location = new System.Drawing.Point(13, 238);
            this.TxtServer.Name = "TxtServer";
            this.TxtServer.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtServer.Properties.Appearance.Options.UseFont = true;
            this.TxtServer.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TxtServer.Properties.ContextImageOptions.Image")));
            this.TxtServer.Size = new System.Drawing.Size(423, 38);
            this.TxtServer.TabIndex = 2;
            // 
            // TxtUser
            // 
            this.TxtUser.Enabled = false;
            this.TxtUser.Location = new System.Drawing.Point(12, 287);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUser.Properties.Appearance.Options.UseFont = true;
            this.TxtUser.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TxtUser.Properties.ContextImageOptions.Image")));
            this.TxtUser.Size = new System.Drawing.Size(423, 38);
            this.TxtUser.TabIndex = 2;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Enabled = false;
            this.TxtPassword.Location = new System.Drawing.Point(12, 336);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPassword.Properties.Appearance.Options.UseFont = true;
            this.TxtPassword.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TxtPassword.Properties.ContextImageOptions.Image")));
            this.TxtPassword.Size = new System.Drawing.Size(423, 38);
            this.TxtPassword.TabIndex = 2;
            // 
            // BtnBaglantiTest
            // 
            this.BtnBaglantiTest.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBaglantiTest.Appearance.Options.UseFont = true;
            this.BtnBaglantiTest.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.BtnBaglantiTest.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnBaglantiTest.Location = new System.Drawing.Point(13, 382);
            this.BtnBaglantiTest.Name = "BtnBaglantiTest";
            this.BtnBaglantiTest.Size = new System.Drawing.Size(135, 65);
            this.BtnBaglantiTest.TabIndex = 3;
            this.BtnBaglantiTest.Text = "Bağlantıyı Test Et";
            this.BtnBaglantiTest.Click += new System.EventHandler(this.BtnBaglantiTest_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.BtnKaydet.Appearance.Options.UseFont = true;
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.BtnKaydet.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnKaydet.Location = new System.Drawing.Point(154, 382);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(135, 65);
            this.BtnKaydet.TabIndex = 3;
            this.BtnKaydet.Text = "Ayarları Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnKapat
            // 
            this.BtnKapat.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.BtnKapat.Appearance.Options.UseFont = true;
            this.BtnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.BtnKapat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnKapat.Location = new System.Drawing.Point(300, 382);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(135, 65);
            this.BtnKapat.TabIndex = 3;
            this.BtnKapat.Text = "Kapat";
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "SQL Server.png");
            this.ımageList1.Images.SetKeyName(1, "Windows.png");
            // 
            // FrmSetupConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 459);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnBaglantiTest);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.TxtServer);
            this.Controls.Add(this.chkSql);
            this.Controls.Add(this.chkWindows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSetupConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSetupConnection";
            ((System.ComponentModel.ISupportInitialize)(this.TxtServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPassword.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckButton chkWindows;
        private DevExpress.XtraEditors.CheckButton chkSql;
        private DevExpress.XtraEditors.TextEdit TxtServer;
        private DevExpress.XtraEditors.TextEdit TxtUser;
        private DevExpress.XtraEditors.TextEdit TxtPassword;
        private DevExpress.XtraEditors.SimpleButton BtnBaglantiTest;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
        private System.Windows.Forms.ImageList ımageList1;
    }
}