using System;
//Tekrar tekrar kullanmak için.


namespace Metodlar

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun u1 = new Urun();
            u1.Adi = "Elma";
            u1.Fiyati = 10;
            u1.Aciklama = "Amasya elması";


            Urun u2 = new Urun();
            u2.Adi = "Karpuz";
            u2.Fiyati = 20;
            u2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { u1, u2 };

            //tyoe safe-  Tip güvenliği
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");
            }

            Console.WriteLine("");
            Console.WriteLine("******** Metodlar **********");
            
            //instance- örnek 
            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(u1);
            sepetManager.Ekle(u2);
            Console.WriteLine("*******************");
            Console.WriteLine("");
            sepetManager.Ekle2("Armut","Deveci",10,5);
            sepetManager.Ekle2("Karpuz", "Diyarbakır", 20,10);


        }
    }
}
