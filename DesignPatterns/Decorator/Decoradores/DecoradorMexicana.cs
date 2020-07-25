using Decorator.Componentes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class DecoradorMexicana : DecoradorBase
    {
        public override void Adicione()
        {
            ListaDeComponentes = new List<IComponente>()
            {
                new Tequila(),
                new Limao(),
                new Sal()
            };

            Execute();
        }

        public override void Execute()
        {
            ListaDeComponentes.ForEach(c => c.Adicione());

            Console.WriteLine($"Mexicana finalizada, bom apetite\n\n\n");
        }
    }
}
