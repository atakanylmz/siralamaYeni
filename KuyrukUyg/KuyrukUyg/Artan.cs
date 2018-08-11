using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuyrukUyg
{
    public class Artan
    {
        private object[] Kisiler;
        private int front = -1;
        private int size = 0;
        private int count = 0;

        public Artan(int size)
        {
            this.size = size;
            Kisiler = new object[size];
        }
        public void Ekle(object o)
        {
            if (count == size)
            {
                throw new Exception("Queue is full");
            }

            if (IsEmpty())
            {
                front++;
                Kisiler[front] = o;
                count++;
            }
            else
            {
                int i;
                for (i = count - 1; i >= 0; i--)
                {
                    Kisi Biri = (Kisi)o;
                    Kisi Kuyruk = (Kisi)Kisiler[i];
                    if (Biri.IslemSuresi < Kuyruk.IslemSuresi)
                        Kisiler[i + 1] = Kisiler[i];
                    else
                        break;
                }
                Kisiler[i + 1] = o;
                front++;
                count++;
            }
        }
        public int KuyrukSureBul(int x)
        {
            int sure = 0;
            for (int i = 0; i < 20; i++)
            {
                sure += SureBulArt(i);
            }
            return sure;
        }
        public int SureBulArt(int x)
        {
            Kisi K = (Kisi)Kisiler[x];
            int sure = K.IslemSuresi;
            return sure;
        }

        public object Remove()
        {
            if (this.IsEmpty())
            {
                throw new Exception("Queue is empty...");
            }
            object temp = Kisiler[front];
            Kisiler[front] = null;
            front--;
            count--;
            return temp;
        }

        public object Peek()
        {
            return Kisiler[front];
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

    }
}
