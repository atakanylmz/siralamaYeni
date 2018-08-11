using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuyruk
{
    public class DaireselKuyruk:GenelKuyruk
    {

        public DaireselKuyruk(int boyut)
        {
            this.size = boyut;
            musteriler = new KuyruktakiBirey[size];
        }

        public override void Ekle(KuyruktakiBirey Birey)
        {
            if (front == -1)
                front = 0;

            if (rear == size - 1)
            {
                rear = 0;
                this.musteriler[rear] = Birey;
            }
            else
            {
                this.musteriler[++rear] = Birey;
            }
            count++;

        }



    }
}
