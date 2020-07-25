using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Passeio : IVeiculo
    {
        public string descricaoTipo { get; set; }

        public Passeio()
        {
            descricaoTipo = "Veiculo de passeio";
        }
    }
}
