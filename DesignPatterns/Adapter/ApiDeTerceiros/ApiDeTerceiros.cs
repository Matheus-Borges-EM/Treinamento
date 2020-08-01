using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class ApiDeTerceiros
    {
        public TipoDeDadosDeTerceiros dadosDeTerceiros { get; set; }

        public void ExecuteAcaoDadosDeTerceitos()
        {
            Console.WriteLine("Executada uma ação na api de terceiros");
        }

    }
}
