using System;

namespace Metotlar
{
    class Program
    {
        //metotlar sürekli tekrar etmeyi engeller.
        //Dont repeat yourself - DRY(Kendini tekrar etme) - Clean Code(Temiz Kod) -Best Practice
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 14;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Aciklama = "Amasya elması";
            urun1.Fiyati = 14;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Aciklama = "Diyarabakır karpuzu";
            urun2.Fiyati = 80;

            Urun[] urunler = new Urun[] {urun1,urun2 };

            //type safe -- tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("---------------Metotlar---------------");
            //instance - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut" , 12,8 );
            sepetManager.Ekle2("Elma", "Yeşil elma" , 12,8 );
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu" , 12,8 );
            
        }
    }
}




