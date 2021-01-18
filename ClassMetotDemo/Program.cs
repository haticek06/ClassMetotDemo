using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ayşe";
            musteri1.Soyadi = "Yılmaz";
            musteri1.Email = "ayse@email.com";
            musteri1.Telefon = "123456789";
            musteri1.Adres = "Ankara";


            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Fatma";
            musteri2.Soyadi = "Demir";
            musteri2.Email = "fatma@email.com";
            musteri2.Telefon = "789456123";
            musteri2.Adres = "İstanbul";


            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Mehmet";
            musteri3.Soyadi = "Yıldız";
            musteri3.Email = "mehmet@email.com";
            musteri3.Telefon = "456123789";
            musteri3.Adres = "İzmir";

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3 };



            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("<------Müşteri Ekleme------>");
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);


            Console.WriteLine("<------Müşteri Listeleme------>");
            musteriManager.MusteriListele(musteriler);


            Console.WriteLine("<------Müşteri Silme------>");
            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriSil(musteri3);
        }
    }
}
