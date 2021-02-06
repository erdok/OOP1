using System;
using System.Collections.Generic;
using System.Text;

namespace GameCompany
{
    class GamersManager
    {
        public void Add(Gamers gamers)
        {
            Console.WriteLine("Yeni oyuncu eklendi\n" + "Oyuncu Adı : " + gamers.FirstName + "\nOyuncu Soyadı : " + gamers.LastName + "\nKullanıcı Adı : " + gamers.UserName + "\nŞifre : " + gamers.Password + "\n.......");
        }

        public void Update(Gamers gamers)
        {
            Console.WriteLine("Oyuncu Güncellendi" + " \n" + gamers.FirstName);
        }

        public void Delete(Gamers gamers)
        {
            Console.WriteLine("Oyuncu silindi" + " \n" + gamers.FirstName );
        }
    }
}
