using DevExpress.XtraEditors;
using SonicPosRestaurant.Components.CallerId;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicPosRestaurant.UI.BackOffice.AnaMenu
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        CallerId callerId;
        public XtraForm1()
        {
            InitializeComponent();
            callerId = new CallerId(this);
        }
    }
}