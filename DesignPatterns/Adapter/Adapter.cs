using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Adapter : ClientInterface
    {
        public ApiDeTerceiros ApiDeTerceiros = new ApiDeTerceiros();

        public TipoDeDadosDeTerceiros AdapteDadosDeTerceiro(MeuTipoDeDado meuTipoDeDado)
        {
            Console.WriteLine("Adapta meus dados para dados de terceiros");
            return new TipoDeDadosDeTerceiros();
        }

        public override void ExecuteAcao(MeuTipoDeDado meuTipoDeDado)
        {
            ApiDeTerceiros.ExecuteAcaoDadosDeTerceitos(AdapteDadosDeTerceiro(meuTipoDeDado));
        }
    }
}
