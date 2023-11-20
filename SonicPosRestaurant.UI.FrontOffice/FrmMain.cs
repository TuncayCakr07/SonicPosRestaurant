using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SonicPosRestaurant.Business.Workers;
using SonicPosRestaurant.Core.Functions;
using SonicPosRestaurant.Entities.Enums;
using SonicPosRestaurant.Entities.Tables;
using SonicPosRestaurant.UserControls;
using SonicPosRestaurant.Entities.Dtos;
using DevExpress.XtraEditors;
using SonicPosRestaurant.Core.Extensions;

namespace SonicPosRestaurant.UI.FrontOffice
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker=new RestaurantWorker();
        public FrmMain()
        {
            InitializeComponent();
            KategoriButtonOlustur();
        }
        private void KategoriButtonOlustur()
        {
            foreach (var Kategori in worker.TanimService.Select(filter:c=> c.TanimTipi==TanimTip.UrunGrup,selector:c=>new KategoriDto { Id=c.Id,Adi=c.Adi}).ToList())
            {
                ControlKategoriButton button = new ControlKategoriButton
                {
                    Name = Kategori.Id.ToString(),
                    Text = Kategori.Adi,
                    Id = Kategori.Id,
                    Urunler = worker.UrunService.GetList(c => c.UrunGrupId == Kategori.Id),
                    GroupIndex = 1,
                    Height = 80,
                    Font = new Font("Century Gothic ",12,FontStyle.Bold),
                    Width = flowKategori.Width - 6
                };
                button.CheckedChanged += KategoriSecim;
                flowKategori.Controls.Add(button);
            }
        }

        private void KategoriSecim(object sender, EventArgs e)
        {
            flowKategoriUrunleri.Controls.Clear();
            ControlKategoriButton button = (ControlKategoriButton)sender;

            foreach (var item in button.Urunler)
            {
                ControlKategoriUrun urunButton = new ControlKategoriUrun
                {
                    Name = item.Id.ToString(),
                    UrunAdi = item.Adi,
                    Id=item.Id,
                    UrunImage = item.Fotograf.ByteArrayToImage(),
                    Height = 220,
                    Width = 300,
                    Aciklama = item.Aciklama,
                };
                urunButton.ButtonClick += UrunClick;
                flowKategoriUrunleri.Controls.Add(urunButton);
            }

        }

        private void UrunClick(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
