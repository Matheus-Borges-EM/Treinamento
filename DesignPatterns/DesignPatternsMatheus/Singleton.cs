
namespace DesignPatternsMatheus
{
    class Singleton
    {
        public static Database Instancia;

        private Singleton()
        {

        }

        public static void GetInstancia()
        {
            Instancia = new Database();
        }
    }
}
