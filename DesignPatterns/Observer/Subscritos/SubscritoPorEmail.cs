using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class SubscritoPorEmail : ISubscrito
    {
        public void Update()
        {
            Console.WriteLine("Notificando usuários no Email");
        }
    }
}
