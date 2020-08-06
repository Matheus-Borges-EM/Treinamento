using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class SubscritoPorSms : ISubscrito
    {
        public void Update()
        {
            Console.WriteLine("Notificando usuários por Sms");
        }
    }
}
