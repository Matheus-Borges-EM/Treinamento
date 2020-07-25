using System.Collections.Generic;

namespace ExemploOCP
{
    public class GeradorDeArquivos
    {
        public void GereArquivos(List<Arquivo> arquivos)
        {
            foreach (var arquivo in arquivos)
            {
                arquivo.GereArquivo();
            }
        }
    }
}
