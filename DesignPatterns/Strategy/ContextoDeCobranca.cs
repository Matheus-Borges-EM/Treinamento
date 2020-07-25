
namespace Strategy
{
    public class ContextoDeCobranca
    {
        private IEstrategiaDeCobranca Estrategia;

        public void InicializeEstrategia(IVeiculo veiculo)
        {
            if (veiculo is Passeio)
            {
                Estrategia = new EstrategiaParaPasseio();
            }

            else if (veiculo is Carga)
            {
                Estrategia = new EstrategiaCobrancaCarga();
            }            
        }

        public string ExecuteEstrategia()
        {
            return Estrategia.ObtenhaEstrategia();
        }
    }
}