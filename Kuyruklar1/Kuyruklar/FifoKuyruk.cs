using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuyruklar
{
    public class FifoKuyruk
    {
        public Musteri[] FifoListe;
        public int rear = -1;
        public int front = -1;
        public int size = 0;
        public int count = 0;
        public int topSure = 0;
        public FifoKuyruk(int size)
        {
            this.size = size;
            FifoListe = new Musteri[size];
        }

        public  void Ekle(Musteri Birey)
        {
            if ((count == size) || (rear == size - 1))
                throw new Exception("Queue dolu.");

            if (front == -1)
                front = 0;
            rear++;
                topSure += Birey.IslemSuresi;

                FifoListe[rear] = Birey;
            Musteri M = FifoListe[rear];
            M.KuyrukSure = topSure;
            M.MusteriNo = rear + 1;



            count++;
        }
        public Musteri Kaldır()
        {
            if (IsEmpty())
                throw new Exception("Queue boş.");

            Musteri temp = FifoListe[front];
            FifoListe[front] = null;
            front++;
            count--;

            return temp;
        }
        public string Listele()
        {
            string temp = "";
            for(int i = 0; i < front; i++)
            {
                temp += (i + 1) + ". kisinin kuyrukta kalma süresi:" + (FifoListe[i].KuyrukSure).ToString() + Environment.NewLine;
            }
            return temp;
        }


        public bool IsEmpty()
        {
            return (count == 0);
        }
    }
}
