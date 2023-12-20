using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicPosRestaurant.UserControls
{
    public partial class ControlKeyboard : DevExpress.XtraEditors.XtraUserControl
    {
        private bool capsLock = true;
        private KeyboardButtonType buttonType = KeyboardButtonType.Standart;
        private BaseEdit focusTextEdit = null;
        public ControlKeyboard()
        {
            InitializeComponent();
        }
        public BaseEdit FocusTextBox 
        { 
            get { return focusTextEdit; }
            set { focusTextEdit = value; } 
        }
        public KeyboardButtonType KeyboardButtonType 
        
        { 
            get { return buttonType;}
            set 
            {
                buttonType = value;
                foreach (KeyboardButton button in layoutControl1.Controls.OfType<KeyboardButton>().ToList())
                {
                    switch (value)
                    {
                       case KeyboardButtonType.Standart:
                            button.Text=button.First.ToString();
                            break;

                        case KeyboardButtonType.Shift:
                            button.Text=button.Second.ToString();
                            if (button.Text == "&")
                            {
                                button.Text = "&&";
                            }
                            break;

                        case KeyboardButtonType.Alt:
                            button.Text=button.Third.ToString();
                            break;
                    }
                }
            } 
        }
        public bool CapsLock
        {
            get { return capsLock; }
            set
            {
                capsLock = value;
                foreach (KeyboardButton button in layoutControl1.Controls.OfType<KeyboardButton>().ToList())
                {
                    if (value)
                    {
                        button.Text = button.Text.ToUpper();
                    }
                    else
                    {
                        button.Text = button.Text.ToLower();
                    }
                    button.Invalidate();
                }
            }
        }

        private void KeyboardButtonClick(object sender, EventArgs e)
        {
            KeyboardButton button = (KeyboardButton)sender;
            if (focusTextEdit!=null)
            {
                focusTextEdit.Focus();
            }
            if (!String.IsNullOrEmpty(button.Text))
            {
                if (button.Text=="&&")
                {
                    SendKeys.Send("{&}");
                }
                else
                {
                    SendKeys.Send("{" + button.Text + "}");
                }
              
            }
        }

        private void KeyEsc_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ESC}");
        }

        private void KeyTab_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
        }

        private void KeyBackSpace_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BACKSPACE}");
        }

        private void KeyDel_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DEL}");
        }

        private void KeyYukari_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{UP}");
        }

        private void KeyAsagiOk_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DOWN}");
        }

        private void KeySolOk_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{LEFT}");
        }

        private void KeySagOk_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }

        private void KeyEnter_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void KeyCapsLock_CheckedChanged(object sender, EventArgs e)
        {
            CapsLock=KeyCapsLock.Checked;
        }

        private void KeySpace_Click(object sender, EventArgs e)
        {
            SendKeys.Send(" ");
        }

        private void KeySolShift_CheckedChanged(object sender, EventArgs e)
        {
            if (KeySolShift.Checked)
            {
                KeyboardButtonType = KeyboardButtonType.Shift;
            }
            else
            {
                KeyboardButtonType = KeyboardButtonType.Standart;
            }
        }

        private void KeySagShift_CheckedChanged(object sender, EventArgs e)
        {
            if (KeySagShift.Checked)
            {
                KeyboardButtonType = KeyboardButtonType.Shift;
            }
            else
            {
                KeyboardButtonType = KeyboardButtonType.Standart;
            }
        }

        private void KeyAlt_CheckedChanged(object sender, EventArgs e)
        {
            if (KeyAlt.Checked)
            {
                KeyboardButtonType = KeyboardButtonType.Alt;
            }
            else
            {
                KeyboardButtonType = KeyboardButtonType.Standart;
            }
        }
    }
}
