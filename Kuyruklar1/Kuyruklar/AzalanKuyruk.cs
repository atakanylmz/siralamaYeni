using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuyruklar
{
    public class AzalanKuyruk
    {
        public Musteri[] AzalanListe;
        public int rear = -1;
        public int front = -1;
        public int size = 0;
        public int count = 0;
        public int topSure = 0;
        public AzalanKuyruk(int size)
        {
            this.size = size;
            AzalanListe = new Musteri[size];
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
                Birey.MusteriNo = front + 1;
                AzalanListe[front] = Birey;
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
                    if (Birey.IslemSuresi > AzalanListe[i].IslemSuresi)
                        AzalanListe[i + 1] = AzalanListe[i];
                    else
                        break;
                }
                topSure = 0;
                for(int j = 0; j < count; j++)
                {
                    Musteri M=AzalanListe[j];
                    topSure += M.IslemSuresi;

                }
                Birey.KuyrukSure = topSure;
                AzalanListe[i + 1] = Birey;


                
               
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
            Musteri temp = AzalanListe[front];
            AzalanListe[front] = null;
            front--;
            count--;
            return temp;
        }
        public string Listele()
        {
            string temp = "";
            for (int i = 0; i < front; i++)
            {
                temp += (i + 1) + ". kisinin kuyrukta kalma süresi:" + (AzalanListe[i].KuyrukSure).ToString() + Environment.NewLine;
            }
            return temp;
        }
        public string FarkBul(FifoKuyruk Fifo)
        {
            string farkAzalan = "";
            for (int i = 0; i < 20; i++)
            {
                farkAzalan += (AzalanListe[i].KuyrukSure - Fifo.FifoListe[i].KuyrukSure).ToString() + Environment.NewLine;

            }
            return farkAzalan;
        }
        public bool IsEmpty()
        {
            return (count == 0);
        }
    }
}
