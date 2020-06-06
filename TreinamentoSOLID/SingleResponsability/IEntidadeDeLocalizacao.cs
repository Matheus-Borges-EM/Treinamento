using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsability
{
    public interface IEntidadeDeLocalizacao
    {
        int Identificador { get; set; }

        string Descricao { get; set; } 
    }
}
