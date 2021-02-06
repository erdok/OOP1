using System;
using System.Collections.Generic;
using System.Text;

namespace GameCompany
{
    class GameProductManager // oluşturulan ürünün satış metodu
    {
     

        public void Sales(GameProduct gameProduct, Gamers gamers)
        {
            DatabaseLoggerService databaseLoggerService = new DatabaseLoggerService();
            Console.WriteLine(gameProduct.OyunAdi + " " + gameProduct.OyunFiyati + " TL fiyatına " + gamers.UserName + " adlı kullanıcıya satıldı\n.......");

        }
    }
}
