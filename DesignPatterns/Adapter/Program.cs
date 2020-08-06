using System;

namespace Adapter
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Adapter();

            var meuTipoDeDado = new DadosEmXML("uma serie de dados em XML para se tornarem gráficos bonitos");
            
            cliente.ExecuteAcao(meuTipoDeDado);
            
            Console.ReadKey();
        }
    }
}
