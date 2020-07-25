using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class EstrategiaParaPasseio : IEstrategiaDeCobranca
    {
        public string descricaoEstrategia { get ; set ;}

        public EstrategiaParaPasseio()
        {
            descricaoEstrategia = "Estrategia de cobrança para veiculos de passeio, foi cobrado o ";
        }

        public string ObtenhaEstrategia()
        {
            var ehCobrancaPorHora = false;
            var ehCobrancaPorDia = true;
            
            return descricaoEstrategia + ObtenhaComplementoMensagem(ehCobrancaPorDia, ehCobrancaPorHora);
        }

        private string ObtenhaComplementoMensagem(bool ehCobrancaPorHora, bool ehCobrancaPorDia)
        {
            if (ehCobrancaPorHora)
            {
                return "valor por hora";
            }
            else if (ehCobrancaPorDia)
            {
                return "valor por dia";
            }

            return "valor por mês";
        }
    }
}
