
using Decorator.Decoradores;
using System.Collections.Generic;

namespace Decorator
{

    public enum TipoDrink
    {
        MERIMERI,
        MEXICANA,
        BRASILEIRINHA,
        CAIPIRINHA
    }


    public class Coquetel
    {

        public Coquetel(TipoDrink coquetelPedido)
        {
            DrinkSelecionado = coquetelPedido;
        }

        public TipoDrink DrinkSelecionado { get; set; }

        public void MonteCoquetel()
        {
            if(DrinkSelecionado == TipoDrink.MERIMERI)
            {
                new DecoradorMeriMeri().Adicione();
            }
            if (DrinkSelecionado == TipoDrink.BRASILEIRINHA)
            {
                new DecoradorBrasileirinha().Adicione();
            }
            if (DrinkSelecionado == TipoDrink.MEXICANA)
            {
                new DecoradorMexicana().Adicione();
            }
            if (DrinkSelecionado == TipoDrink.CAIPIRINHA)
            {
                new DecoratorCaipirinha().Adicione();
            }
        }
    }
}
