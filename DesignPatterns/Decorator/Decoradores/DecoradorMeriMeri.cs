using Decorator.Componentes;
using System;
using System.Collections.Generic;

namespace Decorator
{
    public class DecoradorMeriMeri : DecoradorBase
    {
        public override void Adicione()
        {
            ListaDeComponentes = new List<IComponente>()
            {
                new Vodka(),
                new Gelo(),
                new Suco(),
                new Acucar()
            };

            Execute();
        }

        public override void Execute()
        {
            ListaDeComponentes.ForEach(c => c.Adicione());

            Console.WriteLine($"Meri meri finalizado, bom apetite\n\n\n");
        }
    }
}
