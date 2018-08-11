using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuyruklar
{
    public class ArtanKuyruk
    {
        public Musteri[] ArtanListe;
        public int rear = -1;
        public int front = -1;
        public int size = 0;
        public int count = 0;
        public int topSure = 0;
        public ArtanKuyruk(int size)
        {
            this.size = size;
            ArtanListe = new Musteri[size];
        }


        public void Ekle(Musteri Birey)
        {
            if (count == size)
            {
                throw new Exception("Queue is full");
            }

            if (IsEmpty())
            {
                front++;
                topSure = Birey.IslemSuresi;
                Birey.KuyrukSure = topSure;
                Birey.MusteriNo = front + 1;
                ArtanListe[front] = Birey;
                count++;
            }
            else
            {
                int i;
                //Not3:
                //Son elemandan başlayarak geriye doğru kuyruk kontrol ediliyor
                //Eklenecek elemanın pozisyonu belirleniyor
                //Var olan elemanlar kaydırılıyor
                for (i = count - 1; i >= 0; i--)
                {
                    Musteri M = ArtanListe[i];
                    if (Birey.IslemSuresi < M.IslemSuresi)
                        ArtanListe[i + 1] = ArtanListe[i];
                    else
                        break;
                }
                topSure = 0;
                for (int j = 0; j < count + 1; j++)
                {
                    Musteri M = ArtanListe[j];
                    topSure += M.IslemSuresi;

                }
                Birey.KuyrukSure = topSure;
                ArtanListe[i + 1] = Birey;


                front++;
                count++;
            }
        }

        public object Kaldır()
        {
            if (this.IsEmpty())
            {
                throw new Exception("Queue is empty...");
            }
            Musteri temp = ArtanListe[front];
            ArtanListe[front] = null;
            front--;
            count--;
            return temp;
        }
        public string Listele()
        {
            string temp = "";
            for (int i = 0; i < front; i++)
            {
                temp += (i + 1) + ". kisinin kuyrukta kalma süresi:" + (ArtanListe[i].KuyrukSure).ToString() + Environment.NewLine;
            }
            return temp;
        }
        public string FarkBul(FifoKuyruk Fifo)
        {
            string farkArtan = "";
            for (int i = 0; i < 20; i++)
            {
                farkArtan += (ArtanListe[i].KuyrukSure - Fifo.FifoListe[i].KuyrukSure).ToString() + Environment.NewLine;

            }
            return farkArtan;
        }
        public bool IsEmpty()
        {
            return (count == 0);
        }


    }
}
