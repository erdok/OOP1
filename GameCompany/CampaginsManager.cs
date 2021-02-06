using System;
using System.Collections.Generic;
using System.Text;

namespace GameCompany
{
    class CampaginsManager : ICampaginService
    {
        public void Add(Campagins campagins)
        {
            Console.WriteLine(campagins.CampaginName + " " + "Yeni Kampanya Eklendi\n........");
        }

        public void Delete(Campagins campagins)
        {
            Console.WriteLine(campagins.CampaginName + " " +"Bu Kampanya Artık Aktif Değildir.\n.......");
        }

        public void Update(Campagins campagins)
        {
            Console.WriteLine(campagins.CampaginName +" " + "Kampanyası Güncellendi\n.......");
        }

    }
}
