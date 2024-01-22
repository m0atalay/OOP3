using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal interface FileLoggerService: Interface1
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı");
        }

    }
}
