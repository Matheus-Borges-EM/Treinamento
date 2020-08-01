using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class ClientInterface
    {
        public virtual void ExecuteAcao(MeuTipoDeDado meuTipoDeDado)
        {
            Console.WriteLine("Executa ação");
        }
    }
}
