using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class EstrategiaCobrancaCarga : IEstrategiaDeCobranca
    {
        public string descricaoEstrategia { get; set; }

        public EstrategiaCobrancaCarga()
        {
            descricaoEstrategia = "Estrategia de cobrança para veículos de carga";
        }

        public string ObtenhaEstrategia()
        {
            return descricaoEstrategia;
        }
    }
}
