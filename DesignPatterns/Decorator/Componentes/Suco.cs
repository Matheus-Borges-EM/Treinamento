using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Componentes
{
    class Suco : IComponente
    {
        public void Adicione()
        {
            Console.WriteLine("\nSuco adicionado");
        }
    }
}
