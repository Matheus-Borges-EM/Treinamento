using System;

namespace SubstituicaoDeLiskov
{
    class Program
    {
        static void Main(string[] args)
        {
            var quadrado = new Quadrado(5);
            var retangulo = new Retangulo(5, 7);

            Console.WriteLine($"{quadrado.GetArea()} \n{retangulo.GetArea()}");

            Console.ReadKey();
        }
    }
}
