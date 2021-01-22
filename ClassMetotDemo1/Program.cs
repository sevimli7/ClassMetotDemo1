using System;

namespace ClassMetotDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = "12356";
            musteri1.TcNo = "1215224566";
            musteri1.Ad = "Sevgi";
            musteri1.Soyad = "Taş";
            musteri1.Adres = "cumhuriyet cad. hisar sok. no:56 istanbul";

            Musteri musteri2 = new Musteri();
            musteri2.Id = "1235655599";
            musteri2.TcNo = "1215224566";
            musteri2.Ad = "Asya";
            musteri2.Soyad = "Taş";
            musteri2.Adres = "bayrak cad. hisar sok. no:56 kars";

            Musteri musteri3 = new Musteri();
            musteri3.Id = "12356555";
            musteri3.TcNo = "1215224566";
            musteri3.Ad = "Seven";
            musteri3.Soyad = "Boncukburun";
            musteri3.Adres = "bayrak cad. hisar sok. no:56 izmir";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };


            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.TcNo);
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.Adres);
                Console.WriteLine("------------------------------------------");
            }

            MusteriManager musteriManager= new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Guncelle(musteri3);









        }
    }
}
