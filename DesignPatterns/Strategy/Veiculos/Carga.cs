using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Strategy
{
    public class Carga : IVeiculo
    {
        public string descricaoTipo { get; set; }

        public Carga()
        {
            descricaoTipo = "Vericulo de carga";
        }
    }
}
