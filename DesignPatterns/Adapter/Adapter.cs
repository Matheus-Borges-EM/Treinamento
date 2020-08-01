using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Adapter : ClientInterface
    {
        public ApiDeTerceiros ApiDeTerceiros = new ApiDeTerceiros();

        public MeuTipoDeDado AdapteDadosDeTerceiro(TipoDeDadosDeTerceiros dadosDeTerceiros)
        {
            Console.WriteLine("Adapta meus dados para dados de terceiros");
            return new MeuTipoDeDado();
        }

        public override void ExecuteAcao(MeuTipoDeDado meuTipoDeDado)
        {
            ApiDeTerceiros.ExecuteAcaoDadosDeTerceitos();
        }
    }
}
