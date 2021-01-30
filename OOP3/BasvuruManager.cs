using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, IloggerService loggerService)
        {
            // başvuran bilgilerini değerlendirme
            // birsürü bir sürü kod ....
            krediManager.Hesapla();
            loggerService.Log();

        }

        public void KrediOnbilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
