using System;
using System.Collections.Generic;
using System.Text;

namespace GameCompany
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("\nVeritabanına Loglandı\n.......\n");
        }
    }
}
