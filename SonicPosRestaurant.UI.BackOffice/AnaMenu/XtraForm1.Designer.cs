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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.controlKeyboard1 = new SonicPosRestaurant.UserControls.ControlKeyboard();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(383, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(412, 23);
            this.textBox1.TabIndex = 0;
            // 
            // controlKeyboard1
            // 
            this.controlKeyboard1.CapsLock = true;
            this.controlKeyboard1.KeyboardButtonType = SonicPosRestaurant.UserControls.KeyboardButtonType.Standart;
            this.controlKeyboard1.Location = new System.Drawing.Point(28, 263);
            this.controlKeyboard1.Name = "controlKeyboard1";
            this.controlKeyboard1.Size = new System.Drawing.Size(1203, 256);
            this.controlKeyboard1.TabIndex = 1;
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 538);
            this.Controls.Add(this.controlKeyboard1);
            this.Controls.Add(this.textBox1);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private UserControls.ControlKeyboard controlKeyboard1;
    }
}