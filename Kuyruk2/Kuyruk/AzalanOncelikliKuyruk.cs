using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuyruk
{
    public class AzalanOncelikliKuyruk:GenelKuyruk
    {
        public AzalanOncelikliKuyruk(int boyut)
        {
            this.size = boyut;
            musteriler = new KuyruktakiBirey[size];
        }

        public override void Ekle(KuyruktakiBirey Birey)
        {
            
            if (count == 0)
            {
                rear++;
                front++;
                this.musteriler[rear] = Birey;
                count++;
            }
            else
            {   int i;
                for (i = count - 1; i >= 0; i--)
                {
                    KuyruktakiBirey Musteri= this.musteriler[i];
                    KuyruktakiBirey Birisi = Birey;
                    if ((Musteri.IslemSuresi) < (Birisi.IslemSuresi))
                        this.musteriler[i + 1] = this.musteriler[i];
                    else
                        break;
                }
                this.musteriler[i + 1] = Birey;
                rear++;
                count++;
            }
          
        }

    }
}
