namespace TreinamentoSOLID
{
    public class Estado
    {
        public int Identificador { get; set; }

        public string Descricao { get; set; }

        public string UF { get; set; }

        public int CodigoIBGE { get; set; }

        public Estado(int identificador, string descricao, string uf, int codigoIBGE)
        {
            Identificador = identificador;
            Descricao = descricao;
            UF = uf;
            CodigoIBGE = codigoIBGE;
        }
    }
}