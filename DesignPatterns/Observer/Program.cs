using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var usuarioDeEmail = new SubscritoPorEmail();
            var usuarioDeSms = new SubscritoPorSms();

            var publicador = new Publicador();

            Console.WriteLine("Adicione clientes para receberem notificações");

            publicador.Inscreva(usuarioDeEmail);
            publicador.Inscreva(usuarioDeSms);

            Console.WriteLine("Produto novo saiu, notifique clientes em todas as plataformas");

            publicador.NotifiqueInscritos();

            Console.WriteLine("Desinscreva cliente que recebe notificação por email");

            publicador.Desinscreva(usuarioDeEmail);

            Console.WriteLine("Notifique clientes novamentes");

            publicador.NotifiqueInscritos();
        }
    }
}
