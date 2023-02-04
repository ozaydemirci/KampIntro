using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    class SepetManager // Manager, controller burada operasyonlar tutulur. Mesela sepete ekleme v.s
    {
        // naming convention
         public void Ekle(Urun urun)
        {

            Console.WriteLine("Sepete Eklendi: "+urun.Adi);

        }
        public void Ekle2(string urunAdi,string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Sepete Eklendi 2:"+urunAdi);
        }
    }
}
