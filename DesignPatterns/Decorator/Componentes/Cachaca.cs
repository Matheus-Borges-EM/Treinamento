using System;

namespace Decorator.Componentes
{
    public class Cachaca : IComponente
    {
        public void Adicione()
        {
            Console.WriteLine("\nCachaca adicionada");
        }
    }
}
