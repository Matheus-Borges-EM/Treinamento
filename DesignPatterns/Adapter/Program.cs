using System;

namespace Adapter
{
    public class Program : ClientInterface
    {
        static void Main(string[] args)
        {
            ClientInterface cliente = new Adapter();
            var meuTipoDeDado = new MeuTipoDeDado();
            cliente.ExecuteAcao(meuTipoDeDado);
            Console.ReadKey();
        }

        public void ExecuteAcao(MeuTipoDeDado meuTipoDeDado)
        {
            Console.WriteLine("Executa processamento com meus dados");
        }
    }
}
