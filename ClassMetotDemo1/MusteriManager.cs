using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo1
{
    class MusteriManager
    {
        public void Ekle( Musteri musteri)// ekle, ne ekle? musteri ekle

        {
            Console.WriteLine("musteri eklendi : "+musteri.Ad);
        }

        public void Sil(Musteri musteri)// sil, neyi sil? musteriyi sil

        {
            Console.WriteLine("musteri silindi : " + musteri.Ad);
        }

        public void Guncelle (Musteri musteri)// parametreye neyi güncellemek istediğimizi giriyoruz

        {
            Console.WriteLine("musteri güncellendi : " + musteri.Ad);
        }





    }
}
