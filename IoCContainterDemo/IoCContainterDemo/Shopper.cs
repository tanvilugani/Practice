using System;

namespace IoCContainterDemo
{
    class Shopper
    {
        private readonly ICreditCard _creditCard;

        public Shopper(ICreditCard creditCard)
        {
            _creditCard = creditCard; 
        }

        public void Charge()
        {
           Console.WriteLine(_creditCard.Charge());
        }
    }
}
