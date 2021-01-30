using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IloggerService databaseLoggerService = new DatabaseLoggerService();
            IloggerService fileLoggerService = new FileLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseLoggerService); 

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasıtKrediManager, konutKrediManager };

            //basvuruManager.KrediOnbilgilendirmesiYap(krediler);
        }
    }
}
