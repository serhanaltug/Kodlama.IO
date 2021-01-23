using System;

namespace Ders_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();

            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Serhan";
            musteri1.Soyadi = "Altug";
            musteri1.TcNo = "12345678910";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Websiyon";
            musteri2.VergiNo = "12345678910";

            Musteri musteri3 = new GercekMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);


        }
    }
}
