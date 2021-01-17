using System;

namespace Ders_3_Odev_3
{
    class Program
    {
        static void Main(string[] args)
        {

            MusteriManager musteriManager = new MusteriManager();

            Musteri musteri1 = new Musteri() { Id = 1, AdSoyad = "Ahmet Yılmaz", DogumTarihi = new DateTime(1981, 11, 2) };
            Musteri musteri2 = new Musteri() { Id = 2, AdSoyad = "Tuana Ertürk", DogumTarihi = new DateTime(1982, 3, 20) };
            Musteri musteri3 = new Musteri() { Id = 3, AdSoyad = "Metin Korkmaz", DogumTarihi = new DateTime(1979, 6, 1) };
            Musteri musteri4 = new Musteri() { Id = 4, AdSoyad = "Semih Sağ", DogumTarihi = new DateTime(1981, 5, 21) };
            Musteri musteri5 = new Musteri() { Id = 5, AdSoyad = "Nurşah Yılmaz", DogumTarihi = new DateTime(1983, 5, 24) };

            musteriManager.Listele();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            musteriManager.Listele();

            musteriManager.Sil(musteri3);

            musteriManager.Listele();

            musteriManager.Ekle(musteri4);
            musteriManager.Ekle(musteri5);

            musteriManager.Listele();

            Console.ReadLine();
        }
    }
}
