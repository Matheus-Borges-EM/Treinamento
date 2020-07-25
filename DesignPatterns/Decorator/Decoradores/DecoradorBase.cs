using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class DecoradorBase : IComponente
    {
        protected List<IComponente> ListaDeComponentes { get; set; }

        public abstract void Adicione();

        public abstract void Execute();
    }
}
