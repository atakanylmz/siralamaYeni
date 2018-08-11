using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuyruk
{
    public abstract class GenelKuyruk
    {
        public KuyruktakiBirey[] musteriler;
        public int rear=-1;
        public int front = -1;
        public int size = 0;
        public int count = 0;
        public abstract void Ekle(KuyruktakiBirey Birey);
        public int Cikar()
        {
            KuyruktakiBirey Musteri = this.musteriler[front];

            int sure = Musteri.IslemSuresi;
            if (front == size - 1)
            {
                front = 0;
            }
            else
            {
                this.musteriler[front] = null;
                front++;
            }
            count--;
            return sure;

        }
      

       


    }
}
