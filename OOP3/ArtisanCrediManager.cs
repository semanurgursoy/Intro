using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ArtisanCrediManager : ICrediManager
    {
        public void Compute()
        {
            Console.WriteLine("Esnaf kredisi odeme plani hesaplandi");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
