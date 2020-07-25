using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Componentes
{
    class Vodka : IComponente
    {
        public void Adicione()
        {
            Console.WriteLine("\nVodka adicionada");
        }
    }
}
