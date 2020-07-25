using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Componentes
{
    class Acucar : IComponente
    {
        public void Adicione()
        {
            Console.WriteLine("\nAçucar adicionado");
        }
    }
}
