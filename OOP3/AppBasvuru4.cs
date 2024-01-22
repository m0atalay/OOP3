using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class AppBasvuru4
    {
        //Method Injection
        public void BasvuruYap(ICrediBaseManager crediBaseManager, Interface1 ınterface1)
        {

            crediBaseManager.Hesapla();
            ınterface1.Log();

        }

        public void Crediİnformation(List<ICrediBaseManager> krediler)
        {
          foreach (var k in krediler)
            {
                k.Hesapla();
            }
        }
    }
}
