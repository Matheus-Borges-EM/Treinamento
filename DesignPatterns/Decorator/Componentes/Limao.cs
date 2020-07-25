using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Componentes
{
    class Limao : IComponente
    {
        public void Adicione()
        {
            Console.WriteLine("\nLimao adicionado");
        }
    }
}
