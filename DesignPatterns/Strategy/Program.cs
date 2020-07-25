using System;
using System.Xml.Serialization;

namespace Strategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            var conta = CobrancaParaVeiculoCarga();
            Console.WriteLine(conta.ValorConta());
            conta = CobrancaParaVeiculoPasseio();
            Console.WriteLine(conta.ValorConta());

            Console.ReadKey();
        }

        private static ContaEstacionamento CobrancaParaVeiculoPasseio()
        {
            return new ContaEstacionamento(new Passeio());
        }

        private static ContaEstacionamento CobrancaParaVeiculoCarga()
        {
            return new ContaEstacionamento(new Carga());
        }
    }
}
