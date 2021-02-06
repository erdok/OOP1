using System;

namespace GameCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamers gamers1 = new Gamers();
            gamers1.Id = 1;
            gamers1.TcNo = "21214578954";
            gamers1.FirstName = "Paçinko";
            gamers1.LastName = "YOKSULTÜY";
            gamers1.BirthYear = "1990";
            gamers1.Email = "payoks@gmail.com";
            gamers1.UserName = "Papayo";
            gamers1.Password = "123asd456";

            Campagins campagins2 = new Campagins();
            campagins2.Id = 2;
            campagins2.CampaginName = "Bütün Ay Fırsatları";
            campagins2.AmountOfDiscount = 9.99;


            Campagins campagins1 = new Campagins();
            campagins1.Id = 1;
            campagins1.CampaginName = "şok şok şok küçük indirim fırsatları";
            campagins1.AmountOfDiscount = 0.25;

            GameProduct arabaYarisi = new GameProduct();
            arabaYarisi.OyunAdi = "NFSU2";
            arabaYarisi.OyunFiyati = 30;

            AdamAsmaca adamAsmaca = new AdamAsmaca();
            adamAsmaca.OyunAdi = "AdamAsmacaOyunu";
            adamAsmaca.OyunFiyati = 15;

            OyuncuDogrulamaServisi oyuncuDogrulamaServisi = new OyuncuDogrulamaServisi();
            oyuncuDogrulamaServisi.OyuncuDogrulama(gamers1);

            DatabaseLoggerService databaseLoggerService = new DatabaseLoggerService();
            GameProductManager gameProductManager = new GameProductManager();

            gameProductManager.Sales(adamAsmaca, gamers1);
            databaseLoggerService.Log();
            
            gameProductManager.Sales(arabaYarisi, gamers1);
            databaseLoggerService.Log();
           

            GamersManager gamersManager = new GamersManager();
            gamersManager.Add(gamers1);

            CampaginsManager campaginsManager = new CampaginsManager();
            campaginsManager.Add(campagins1);
            campaginsManager.Update(campagins2);
            campaginsManager.Delete(campagins1);
        }
    }
}
