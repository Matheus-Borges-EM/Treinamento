using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Componentes
{
    class Tequila : IComponente
    {
        public void Adicione()
        {
            Console.WriteLine("\nTequila adicionada");
        }
    }
}
