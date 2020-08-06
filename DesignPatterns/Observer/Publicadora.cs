using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class Publicador
    {
        List<ISubscrito> Subscritos { get; set; }

        public Publicador()
        {
            Subscritos = new List<ISubscrito>();
        }

        public void Inscreva(ISubscrito subscrito)
        {
            Subscritos.Add(subscrito);
        }

        public void Desinscreva(ISubscrito subscrito)
        {
            Subscritos.Remove(subscrito);
        }

        public void NotifiqueInscritos()
        {
            foreach (var subscrito in Subscritos)
            {
                subscrito.Update();
            }
        }

    }
}
