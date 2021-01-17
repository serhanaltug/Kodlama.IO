using System;
using System.Collections.Generic;

namespace Ders_3_Odev_3
{
    public class MusteriManager
    {
        private List<Musteri> _musteriler;

        public MusteriManager()
        {
            _musteriler = new List<Musteri>();
        }

        public void Ekle(Musteri musteri) {
            _musteriler.Add(musteri);
            Console.WriteLine(musteri.AdSoyad + " eklendi.");
        }
        public void Sil(Musteri musteri)
        {
            _musteriler.Remove(musteri);
            Console.WriteLine(musteri.AdSoyad + " silindi.");
        }
        public void Listele()
        {
            Console.WriteLine("---------------- Müşteri Listesi ----------------");

            if(_musteriler.Count == 0)
            {
                Console.WriteLine("Hiç kayıtlı müşteri bulunmamaktadır. \n");
            }
            else
            {
                foreach (var musteri in _musteriler)
                {
                    Console.WriteLine(musteri.Id + "\t" + musteri.AdSoyad + "\t" + musteri.DogumTarihi.ToString("dd MMMM yyyy"));
                }
                Console.WriteLine();
            }
        }
    }
}
