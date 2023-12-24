namespace SonicPosRestaurant.UI.BackOffice.AnaMenu
{
    partial class XtraForm1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.adornerUIManager1 = new DevExpress.Utils.VisualEffects.AdornerUIManager(this.components);
            this.controlKeyboard1 = new SonicPosRestaurant.UserControls.ControlKeyboard();
            this.controlBadgeButton1 = new SonicPosRestaurant.UserControls.ControlBadgeButton();
            ((System.ComponentModel.ISupportInitialize)(this.adornerUIManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(383, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(412, 23);
            this.textBox1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(952, 79);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(170, 134);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // adornerUIManager1
            // 
            this.adornerUIManager1.Owner = this;
            // 
            // controlKeyboard1
            // 
            this.controlKeyboard1.CapsLock = true;
            this.controlKeyboard1.FocusTextBox = null;
            this.controlKeyboard1.KeyboardButtonType = SonicPosRestaurant.UserControls.KeyboardButtonType.Standart;
            this.controlKeyboard1.Location = new System.Drawing.Point(28, 263);
            this.controlKeyboard1.Name = "controlKeyboard1";
            this.controlKeyboard1.Size = new System.Drawing.Size(1203, 256);
            this.controlKeyboard1.TabIndex = 1;
            // 
            // controlBadgeButton1
            // 
            this.controlBadgeButton1.BadgeAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.controlBadgeButton1.BadgeBackColor = System.Drawing.Color.Red;
            this.controlBadgeButton1.BadgeFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.controlBadgeButton1.BadgeForeColor = System.Drawing.Color.White;
            this.controlBadgeButton1.ContainerControl = this;
            this.controlBadgeButton1.Count = 5;
            this.controlBadgeButton1.Location = new System.Drawing.Point(516, 147);
            this.controlBadgeButton1.Name = "controlBadgeButton1";
            this.controlBadgeButton1.Size = new System.Drawing.Size(169, 110);
            this.controlBadgeButton1.TabIndex = 3;
            this.controlBadgeButton1.Text = "controlBadgeButton1";
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 538);
            this.Controls.Add(this.controlBadgeButton1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.controlKeyboard1);
            this.Controls.Add(this.textBox1);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)(this.adornerUIManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private UserControls.ControlKeyboard controlKeyboard1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.Utils.VisualEffects.AdornerUIManager adornerUIManager1;
        private UserControls.ControlBadgeButton controlBadgeButton1;
    }
}