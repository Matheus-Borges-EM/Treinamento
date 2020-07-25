using Decorator.Componentes;
using System;
using System.Collections.Generic;


namespace Decorator.Decoradores
{
    public class DecoratorCaipirinha : DecoradorBase
    {
        public override void Adicione()
        {
            ListaDeComponentes = new List<IComponente>()
            {
                new Cachaca(),
                new Limao(),
                new Acucar()
            };

            Execute();
        }

        public override void Execute()
        {
            ListaDeComponentes.ForEach(c => c.Adicione());
            Console.WriteLine("Caipirinha finalizada, bom apetite");
        }
    }
}
