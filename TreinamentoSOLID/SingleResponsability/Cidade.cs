namespace TreinamentoSOLID
{
    public class Cidade
    {
        public int Identificador { get; set; }

        public Estado Estado { get; set; }

        public string Descricao { get; set; }

        public int CodigoIBGE { get; set; }

        public Cidade(int identificador, Estado estado, string descricao, int codigoIBGE)
        {
            Identificador = identificador;
            Estado = estado;
            Descricao = descricao;
            CodigoIBGE = codigoIBGE;
        }


    }
}