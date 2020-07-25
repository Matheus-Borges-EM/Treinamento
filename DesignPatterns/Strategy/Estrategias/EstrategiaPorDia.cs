using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Estrategias
{
    public class EstrategiaPorDia : IEstrategiaDeCobranca
    {
        public IVeiculo Veiculo;

        public EstrategiaPorDia(IVeiculo veiculo)
        {
            Veiculo = veiculo;
        }

        public string ObtenhaEstrategia()
        {
            return $"Estrategia de cálculo para {Veiculo.descricaoTipo} utilizando estratégia por mês";
        }
    }
}
