using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuyrukUyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {

            Random randomSure = new Random();


            Artan ArtanK = new Artan(20);
            Azalan AzalanK = new Azalan(20);
            Fifo FifoK = new Fifo(20);


            for (int i = 0; i < 20; i++)
            {
                Random Rnd = new Random();
                int sure = Rnd.Next(60, 600);
                Kisi Musteri = new Kisi { IslemSuresi = sure };
                ArtanK.Ekle(Musteri);
                AzalanK.Ekle(Musteri);
                FifoK.Ekle(Musteri);
            }

            string artanListe = "";
            string azalanListe = "";
            string fifoListe = "";
            for (int i = 0; i < 20; i++)
            {
                int art = ArtanK.SureBulArt(i);
                artanListe += (i + 1).ToString() + ".müşteri: " + art.ToString() + Environment.NewLine;
                int az = AzalanK.SureBulAz(i);
                azalanListe += (i + 1).ToString() + ".müşteri: " + az.ToString() + Environment.NewLine;
                int fif = FifoK.SureBulFif(i);
                fifoListe += (i + 1).ToString() + ".müşteri: " + fif.ToString() + Environment.NewLine;
            }

            txtAzalanListe.Text = azalanListe;
            txtArtanListe.Text = artanListe;
            txtDaireselListe.Text = fifoListe;

            string farkArtan = "";
            string farkAzalan = "";

            for (int i = 0; i < 20; i++)
            {
                int art = ArtanK.KuyrukSureBul(i);
                int az = AzalanK.KuyrukSureBul(i);
                int fif = FifoK.KuyrukSureBul(i);

                farkArtan += (art - fif).ToString() + Environment.NewLine;
                farkArtan += (az - fif).ToString() + Environment.NewLine;
            }
            txtArtanFark.Text = farkArtan;
            txtAzalanFark.Text = farkAzalan;

            int ar = ArtanK.KuyrukSureBul(19);
            txtArtanToplam.Text = ar.ToString();
            int azl = AzalanK.KuyrukSureBul(19);
            txtAzalanToplam.Text = azl.ToString();
            int ff = FifoK.KuyrukSureBul(19);
            txtFifoToplamSure.Text = ff.ToString();

            txtFifoOrtalama.Text = (ff / 20).ToString();
            txtArtanOrtalama.Text = (ar / 20).ToString();
            txtAzalanOrtalama.Text = (azl / 20).ToString();

            int farkArt = ar - ff;
            int farkAz = azl - ff;
            txtAzalanTopFark.Text = farkAz.ToString();
            txtArtanTopFark.Text = farkArt.ToString();
            txtAzalanFarkYuzdesi.Text = (farkArt * 100 / ff).ToString();
            txtArtanFarkYuzdesi.Text = (farkAz * 100 / ff).ToString();

        }


        }
}
