using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuyrukUyg
{
    public class Fifo
    {
        private object[] Kisiler;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;
        public Fifo(int size)
        {
            this.size = size;
            Kisiler = new object[size];
        }
        public void Ekle(object o)
        {
            if ((count == size) || (rear == size - 1))
                throw new Exception("Queue dolu.");

            if (front == -1)
                front = 0;

            Kisiler[++rear] = o;
            count++;
        }
        public int KuyrukSureBul(int x)
        {
            int sure = 0;
            for (int i = 0; i < 20; i++)
            {
                sure += SureBulFif(i);
            }
            return sure;
        }
        public int SureBulFif(int x)
        {
            Kisi K = (Kisi)Kisiler[x];
            return K.IslemSuresi;
        }
        public object Remove()
        {
            if (IsEmpty())
                throw new Exception("Queue boş.");

            object temp = Kisiler[front];
            Kisiler[front] = null;
            front++;
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
