using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("******************************************");
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " " + "isimli müşteri eklendi! ");
           
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("******************************************");
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " " + "isimli müşteri silindi! ");
          
        }

        public void MusteriListele(Musteri[] musteriler)
        {
            foreach(Musteri musteri in musteriler)
            {
                Console.WriteLine("******************************************");
                Console.WriteLine("Müşteri Adı Soyadı: " + musteri.Adi + " " + musteri.Soyadi);
                Console.WriteLine("Müşteri Email: " + musteri.Email);
                Console.WriteLine("Müşteri Telefonu: " + musteri.Telefon);
                Console.WriteLine("Müşteri Adresi: " + musteri.Adres);
                Console.WriteLine("******************************************");
            }
        }
    }
}
