using Decorator.Componentes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class DecoradorBrasileirinha : DecoradorBase
    {
        public override void Adicione()
        {
            ListaDeComponentes = new List<IComponente>()
            {
                new Cachaca(),
                new LeiteCondensado(),
                new Acucar(),
                new Gelo()
            };

            Execute();
        }

        public override void Execute()
        {
            ListaDeComponentes.ForEach(c => c.Adicione());

            Console.WriteLine($"Basileirinha finalizada, bom apetite\n\n\n");
        }
    }
}
