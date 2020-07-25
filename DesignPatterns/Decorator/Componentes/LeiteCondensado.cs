using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Componentes
{
    class LeiteCondensado : IComponente
    {
        public void Adicione()
        {
            Console.WriteLine("\nLeite condensado adicionado");
        }
    }
}
