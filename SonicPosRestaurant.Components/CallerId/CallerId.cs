using DevExpress.XtraBars.Alerter;
using DevExpress.XtraEditors;
using SonicPosRestaurant.Business.Managers;
using SonicPosRestaurant.Business.Workers;
using SonicPosRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SonicPosRestaurant.Components.CallerId
{
    public class CallerId
    {
        [DllImport("cid.dll", EntryPoint = "CidData", CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string CidData();

        [DllImport("cid.dll", EntryPoint = "CidStart")]
        public static extern string CidStart();
        private Timer timer;
        RestaurantWorker worker;
        private XtraForm _form;
        public CallerId(XtraForm form)
        {
            worker = new RestaurantWorker();
            _form = form;
            timer = new Timer(TimerElapsed,null,0,100);
            CidStart();
        }

        private void TimerElapsed(object state)
        {
            string temp = "";

            temp = CidData();
            if (!String.IsNullOrEmpty(temp))
            {
                string[] tempdata = temp.Split(',');
                string telefon = tempdata[2];
                Telefon musteri = worker.TelefonService.Get(c => c.Telefonu == telefon,c=>c.Musteri);
                AlertControl alertControl=new AlertControl();
                if (musteri == null)
                {
                    _form.Invoke((Action)delegate
                    {
                        alertControl.Show(_form, tempdata[1] + "Hattan Aranıyorsunuz!", telefon + "\n Kayıtsız Müşteri Numarası");
                    });
                }
                else
                {
                    _form.Invoke((Action)delegate
                    {
                        alertControl.Show(_form, tempdata[1] + "Hattan Aranıyorsunuz!", telefon + "\n" + musteri.Musteri.Adi + " " + musteri.Musteri.Soyadi);
                    });
                }
            }
        }
    }
    public class ConstCharPtrMarshaler : ICustomMarshaler
    {
        public object MarshalNativeToManaged(IntPtr pNativeData)
        {
            return Marshal.PtrToStringAnsi(pNativeData);
        }

        public IntPtr MarshalManagedToNative(object ManagedObj)
        {
            return IntPtr.Zero;
        }

        public void CleanUpNativeData(IntPtr pNativeData)
        {
        }

        public void CleanUpManagedData(object ManagedObj)
        {
        }

        public int GetNativeDataSize()
        {
            return IntPtr.Size;
        }

        static readonly ConstCharPtrMarshaler instance = new ConstCharPtrMarshaler();

        public static ICustomMarshaler GetInstance(string cookie)
        {
            return instance;
        }
    }
}
