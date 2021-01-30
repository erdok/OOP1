using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "123456";
            musteri1.Adi = "Erdo";
            musteri1.Soyadi = "Anka";
            musteri1.TcNo = "52144457885";

            //Tuzel Müşetri

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "548741";
            musteri2.SirketAdi = "Kodlama.İo";
            musteri2.VergiNo = "12345678";


            Musteri musteri3 = new GercekMusteri(); //musteri classı hem gerçek hem de tüzel kişinin referansını tutabiliyor
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager musteriManager = new CustomerManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);




        }
    }
}
