using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class DadosEmJson
    {
        public string Conteudo { get; set; }
        
        public DadosEmJson(string conteudoParaSerConvertido)
        {
            Conteudo = conteudoParaSerConvertido;
        }

    }
}
