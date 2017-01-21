
using System;
namespace IoCContainterDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ICreditCard masterCard = new MasterCard();
            ICreditCard visaCard = new VisaCard();

            var shopper = new Shopper(masterCard);

            shopper.Charge();

            var anotherShopper = new Shopper(visaCard);

            anotherShopper.Charge();

            Console.ReadKey();            
        }
    }
}
