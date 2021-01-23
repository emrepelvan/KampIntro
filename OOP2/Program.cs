using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri customer1 = new Musteri();
            //customer1.Adi = "Emre";
            //customer1.Soyadi = "Pelvan";
            //customer1.Id = 1;
            //customer1.TcNo = "11111111111";
            //customer1.MüsteriNo = "356188";
            //customer1.SirketAdi = "?";

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MüsteriNo = "356188";
            musteri1.Adi = "Emre";
            musteri1.Soyadi = "Pelvan";
            musteri1.TcNo = "11111111111";

            //Kodlama.io

            TuzelMüsteri musteri2 = new TuzelMüsteri();
            musteri2.Id = 2;
            musteri2.MüsteriNo = "883561";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "2222222222";


            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMüsteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
        }
    }
}
