using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuyruk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
                Random randomSure = new Random();


            AzalanOncelikliKuyruk Azalan = new AzalanOncelikliKuyruk(20);
            ArtanOncelikliKuyruk Artan = new ArtanOncelikliKuyruk(20);
            DaireselKuyruk Dairesel = new DaireselKuyruk(20);
            


                for (int i = 0; i < 20; i++)
            {

                Random Rnd = new Random();
                int sure=Rnd.Next(60, 600);
                KuyruktakiBirey Musteri = new KuyruktakiBirey {IslemSuresi=sure };


                Azalan.Ekle(Musteri);
                Artan.Ekle(Musteri);
                Dairesel.Ekle(Musteri);
            }


            int artanKuyruktakiSure = 0, azalanKuyruktakiSure = 0, fifoKuyruktakiSure = 0,
                artanKisiselIslemSuresi = 0, azalanKisiselIslemSuresi = 0,fifoKisiselIslemSuresi=0,
                artanBireyselFark = 0, azalanBireyselFark=0, artanToplam = 0, fifoToplam = 0, azalanToplam = 0,
                artanTopFark = 0, azalanTopFark = 0, artanYuzde = 0, azalanYuzde = 0,
                artanOrtalama = 0, azalanOrtalama = 0, fifoOrtalama = 0;

            string artanKisi = "", azalanKisi = "", fifoKisi = ""
                ,artanKisiFark="",azalanKisiFark="";
            for(int i = 0; i < 20; i++)
            {
                artanKisiselIslemSuresi=Artan.Cikar();
                azalanKisiselIslemSuresi =Azalan.Cikar();
                fifoKisiselIslemSuresi =Dairesel.Cikar();

                //kuyruktaki elemanın kuyrukta harcayacağı zamanla işlemi için harcayacağı zaman toplanıyor
                artanKuyruktakiSure += artanKisiselIslemSuresi;
                azalanKuyruktakiSure += azalanKisiselIslemSuresi;
                fifoKuyruktakiSure += fifoKisiselIslemSuresi;

                artanKisi += (i + 1).ToString() + ". kişinin kuyruk+işlem süresi:" + artanKuyruktakiSure.ToString() + Environment.NewLine;
                azalanKisi += (i + 1).ToString() + ". kişinin kuyruk+işlem süresi:" + azalanKuyruktakiSure.ToString() + Environment.NewLine;
                fifoKisi += (i + 1).ToString() + ". kişinin kuyruk+işlem süresi:" + fifoKuyruktakiSure.ToString() + Environment.NewLine;
             
                artanBireyselFark = artanKuyruktakiSure - fifoKuyruktakiSure;
                azalanBireyselFark = azalanKuyruktakiSure - fifoKuyruktakiSure;

                artanKisiFark += artanBireyselFark.ToString() + Environment.NewLine;
                azalanKisiFark += azalanBireyselFark.ToString() + Environment.NewLine;
            }

            txtArtanListe.Text = artanKisi;
            txtAzalanListe.Text = azalanKisi;
            txtDaireselListe.Text = fifoKisi;

            txtArtanFark.Text = artanKisiFark;
            txtAzalanFark.Text = azalanKisiFark;

            artanToplam = artanKuyruktakiSure;
            azalanToplam = azalanKuyruktakiSure;
            fifoToplam = fifoKuyruktakiSure;

            txtArtanToplam.Text = artanToplam.ToString();
            txtAzalanToplam.Text = azalanToplam.ToString();
            txtFifoToplamSure.Text = fifoToplam.ToString();

            artanTopFark = artanToplam - fifoToplam;
            azalanTopFark = azalanToplam - fifoToplam;

            txtArtanTopFark.Text = artanTopFark.ToString();
            txtAzalanTopFark.Text = azalanTopFark.ToString();

            artanYuzde = artanToplam * 100 / fifoToplam;
            azalanYuzde = azalanToplam * 100 / fifoToplam;

            txtArtanFarkYuzdesi.Text = artanYuzde.ToString();
            txtAzalanFarkYuzdesi.Text = azalanYuzde.ToString();

            artanOrtalama = artanToplam / 20;
            azalanOrtalama = azalanToplam / 20;
            fifoOrtalama = fifoToplam / 20;

            txtArtanOrtalama.Text = artanOrtalama.ToString();
            txtAzalanOrtalama.Text = azalanOrtalama.ToString();
            txtFifoOrtalama.Text = fifoOrtalama.ToString();


        }

        private void txtDaireselListe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAzalanListe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtArtanToplam_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtArtanOrtalama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtArtanTopFark_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtArtanListe_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtFifoOrtalama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFifoToplamSure_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtAzalanFark_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtAzalanOrtalama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAzalanTopFark_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAzalanFarkYuzdesi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAzalanToplam_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtArtanFark_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtArtanFarkYuzdesi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
