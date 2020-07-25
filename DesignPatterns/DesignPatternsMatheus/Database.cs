
namespace DesignPatternsMatheus
{
    public class Database
    {
        private const string stringDeConexao = "String de conexao qualquer";
        public MapeadorFicticio mapeadorQualquer;

        public Database()
        {
            mapeadorQualquer = new MapeadorFicticio(stringDeConexao);
        }
    }
}
