
using Strategy.Estrategias;

namespace Strategy
{
    public class ContextoDeCobranca
    {
        private IEstrategiaDeCobranca Estrategia;

        public void InicializeEstrategia(IVeiculo veiculo)
        {
            var ehPorDia = true;
            var ehPorHora = true;

            if (ehPorHora)
            {
                Estrategia = new EstrategiaPorHora(veiculo);
            }
            else if (ehPorDia)
            {
                Estrategia = new EstrategiaPorDia(veiculo);
            }
            else
            {
                Estrategia = new EstrategiaPorMes(veiculo);
            }
        }

        public string ExecuteEstrategia()
        {
            return Estrategia.ObtenhaEstrategia();
        }
    }
}