using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class ApiDeTerceiros
    {
        public void ExecuteAcaoDadosDeTerceitos(TipoDeDadosDeTerceiros dadosDeTerceiros)
        {
            if (dadosDeTerceiros is TipoDeDadosDeTerceiros)
            {
                Console.WriteLine("Executada uma ação na api de terceiros");
            }
        }

    }
}
