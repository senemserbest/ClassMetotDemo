using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
         

            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Fehime";
            musteri1.Soyad = "Çay";
            musteri1.Bakiye = 8562;
            musteri1.KartTipi = "MasterCard";
           

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Selim";
            musteri2.Soyad = "Erdemir";
            musteri2. Bakiye = 5204;
            musteri2.KartTipi = "Visa";

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Rahmi";
            musteri3.Soyad = "Açıkgöz";
            musteri3.Bakiye = 15203;
            musteri3.KartTipi = "Visa";



            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Console.WriteLine("İşlem gerçekleştirildi.");


            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);
            
            Console.WriteLine("İşlem gerçekleştirildi.");

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            

            musteriManager.Listele(musteriler);
            

            Console.WriteLine("İşlem gerçekleştirildi.");

        } 
    }
}
