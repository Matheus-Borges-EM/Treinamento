using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            new Coquetel(TipoDrink.BRASILEIRINHA).MonteCoquetel();
            new Coquetel(TipoDrink.MERIMERI).MonteCoquetel();
            new Coquetel(TipoDrink.MEXICANA).MonteCoquetel();
            new Coquetel(TipoDrink.CAIPIRINHA).MonteCoquetel();                       
        }
    }
}
