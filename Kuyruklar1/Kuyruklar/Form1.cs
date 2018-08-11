using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuyruklar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Random Rnd = new Random();
            FifoKuyruk Fifo = new FifoKuyruk(20);
            AzalanKuyruk Azalan = new AzalanKuyruk(20);
            ArtanKuyruk Artan = new ArtanKuyruk(20);
            for (int i = 0; i < 20; i++)
            {
                Musteri YeniMusteri = new Musteri { IslemSuresi = Rnd.Next(60, 600) };
                YeniMusteri.MusteriNo = i + 1;
                Fifo.Ekle(YeniMusteri);
                Azalan.Ekle(YeniMusteri);
                Artan.Ekle(YeniMusteri);

            }
            txtFifoListe.Text = Fifo.Listele();
            txtArtanListe.Text = Artan.Listele();
            txtAzalanListe.Text = Azalan.Listele();
            
            txtFifoListe.Text = Fifo.Listele();
            txtArtanListe.Text = Artan.Listele();
            txtAzalanListe.Text = Azalan.Listele();

            txtFifoToplam.Text = Fifo.topSure.ToString();
            txtArtanToplam.Text = Artan.topSure.ToString();
            txtAzalanToplam.Text = Azalan.topSure.ToString();

            txtFifoOrtalama.Text= ((Fifo.topSure)/20).ToString();
            txtArtanOrtalama.Text = ((Artan.topSure) / 20).ToString();
            txtAzalanOrtalama.Text = ((Azalan.topSure) / 20).ToString();

            txtAzalanFark.Text = Azalan.FarkBul(Fifo);
            txtArtanFark.Text = Artan.FarkBul(Fifo);

            txtArtanTopFark.Text = (Artan.topSure - Fifo.topSure).ToString();
            txtAzalanTopFark.Text = (Azalan.topSure - Fifo.topSure).ToString();

            txtArtanYuzde.Text = ((Artan.topSure - Fifo.topSure) * 100 / Fifo.topSure).ToString();
            txtAzalanYuzde.Text = ((Azalan.topSure - Fifo.topSure) * 100 / Fifo.topSure).ToString();


        }
    }
}
