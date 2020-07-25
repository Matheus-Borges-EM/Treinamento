using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploOCP
{
    public class Program
    {
        static void Main(string[] args)
        {
            var arquivos = new List<Arquivo>();

            var arquivoWord = new ArquivoWord();
            arquivos.Add(arquivoWord);

            var arquivoPdf = new ArquivoPdf();
            arquivos.Add(arquivoPdf);

            var arquivoTxt = new ArquivoTxt();
            arquivos.Add(arquivoTxt);

            var geradorDeArquivo = new GeradorDeArquivos();
            geradorDeArquivo.GereArquivos(arquivos);

            Console.ReadKey();
        }
    }
}
