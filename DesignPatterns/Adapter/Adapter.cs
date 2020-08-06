using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Adapter : ClientBase
    {
        public ApiDeTerceiros ApiDeTerceiros = new ApiDeTerceiros();

        public DadosEmJson AdapteXmlParaJson(DadosEmXML dadosEmXml)
        {
            Console.WriteLine("Adapta dados de XML para Json");
            return new DadosEmJson(dadosEmXml.Conteudo);
        }        

        public void ExecuteAcao(DadosEmXML dadosEmXml)
        {
            var dadosAdaptadosParaJson = AdapteXmlParaJson(dadosEmXml);

            ApiDeTerceiros.GereGraficosBonitosUsandoJson(dadosAdaptadosParaJson);
        }
    }
}
