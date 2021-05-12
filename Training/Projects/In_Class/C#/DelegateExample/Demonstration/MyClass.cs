using System;
namespace Demonstration
{
    public class MyClass
    {
        public static void Main(string[] args)
        {   
            // Holds a list of bools representing whether the market increase[true] or decreases[false]
            bool[] StockMarket = RandomizeMarket();
            
            // Define delegate class and responder
            Broker Bob = new Broker("Bob");
            Investor Frank = new Investor("Frank");
            BadInvestor Tom = new BadInvestor("Tom");

            // Enlist Bob's help for Franks investments
            Bob.AdviceInstance += Frank.onNotify;
            Bob.AdviceInstance += Tom.onNotify;

            // Invokes the Delegate for each shift in the market
            foreach (bool shift in StockMarket)
                Bob.Notify(shift);
        }

        // Code for randomizing boolean values NOT IMPORTANT FOR DEMONSTRATION
        private static bool[] RandomizeMarket()
        {
            Random rand = new Random();
            bool[] bools = new bool[10];

            for (int i = 0; i < 10; i++)
            {
                int temp = (int)(rand.Next(-1,1) + 1);
                bools[i] = (temp != 0) ? true : false;
            }
            return bools;

        }
    }
}