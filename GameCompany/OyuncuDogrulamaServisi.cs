using System;
using System.Collections.Generic;
using System.Text;

namespace GameCompany
{
    class OyuncuDogrulamaServisi : IOyuncuDogrulamaServisi
    {
        public void OyuncuDogrulama(Gamers gamers)
        {
            if (gamers.TcNo == "21214578954" & gamers.FirstName == "Paçinko" &gamers.LastName == "YOKSULTÜY" & gamers.BirthYear == "1990" )
            {
                Console.WriteLine("\n \nTebrikler Doğrulama Başarılı\n.......");
            }
            else
            {
                Console.WriteLine("\nHata! Lütfen Bilgilerinizi Kontrol Edip Yeniden Giriş Yapınız!\n.......");
            }
        }
    }
}
