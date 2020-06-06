using System;
using System.Collections.Generic;
using System.Text;

namespace SubstituicaoDeLiskov
{
    public class Retangulo
    {
        protected int Altura { get; set; }
        protected int Largura { get; set; }

        public Retangulo(int altura, int largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public int GetArea()
        {
            return Largura * Altura;
        }
    }
}
