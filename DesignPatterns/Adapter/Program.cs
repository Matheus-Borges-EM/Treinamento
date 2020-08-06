using System;

namespace Adapter
{
    public class Program : ClientInterface
    {
        static void Main(string[] args)
        {
            ClientInterface cliente = new Adapter();
            var meuTipoDeDado = new DadosEmXML("uma serie de dados em XML para se tornarem gráficos bonitos");
            cliente.ExecuteAcao(meuTipoDeDado);
            Console.ReadKey();
        }
    }
}
