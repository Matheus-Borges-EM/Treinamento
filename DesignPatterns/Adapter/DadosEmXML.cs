using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class DadosEmXML
    {        
        public string Conteudo { get; set; }

        public DadosEmXML(string dados)
        {
            Conteudo = dados;
        }
    }
}
