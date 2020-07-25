using Strategy;

public class ContaEstacionamento
{
    private IVeiculo Veiculo;

    private ContextoDeCobranca ContextoDeCobranca;

    public ContaEstacionamento(IVeiculo veiculo)
    {
        Veiculo = veiculo;
        ContextoDeCobranca = new ContextoDeCobranca();
    }

    public string ValorConta()
    {
        ContextoDeCobranca.InicializeEstrategia(Veiculo);
        return ContextoDeCobranca.ExecuteEstrategia();
    }
}