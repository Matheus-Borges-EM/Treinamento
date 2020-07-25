using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Componentes
{
    class Gelo : IComponente
    {
        public void Adicione()
        {
            Console.WriteLine("\nGelo foi adicionado");
        }
    }
}
