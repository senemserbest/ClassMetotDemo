using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    { 
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine( musteri.Ad + " " + musteri.Soyad + " " + "eklendi");

        }
       
        
        public void Sil(Musteri musteri)
        {
            Console.WriteLine (musteri.Ad + " " + musteri.Soyad + " " +   "silindi" );
        }
        public void Listele(Musteri [] musteriler)
        {
       
            foreach(var musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + musteri.Bakiye + "TL" + "/" + musteri.KartTipi);
            }    
            
        }
    }
}
