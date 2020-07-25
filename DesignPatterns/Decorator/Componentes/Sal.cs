using System;


namespace Decorator.Componentes
{
    class Sal : IComponente
    {
        public void Adicione()
        {
            Console.WriteLine("\nSal adicionado");
        }
    }
}
