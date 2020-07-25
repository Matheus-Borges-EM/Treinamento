using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploOCP
{
    public class ArquivoPdf : Arquivo
    {
        public override void GereArquivo()
        {
            Console.WriteLine("Arquivo PDF gerado com sucesso.");
        }
    }
}
