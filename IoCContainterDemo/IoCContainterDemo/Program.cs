
using System;
namespace IoCContainterDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //ICreditCard masterCard = new MasterCard();
            //ICreditCard visaCard = new VisaCard();
            //var anotherShopper = new Shopper(visaCard);
            //anotherShopper.Charge();

            //var shopper = new Shopper(new Resolver().ResolveCreditCard());

            var resolver = new Resolver();

            resolver.Register<Shopper, Shopper>();
            resolver.Register<ICreditCard, MasterCard>();

            var shopper = resolver.Resolve<Shopper>();

            shopper.Charge();

            Console.ReadKey();            
        }
    }
}
