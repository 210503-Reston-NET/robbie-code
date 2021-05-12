using System;

namespace Demonstration
{
    public class BadInvestor
    {
        public string Name { get; set; }
        public BadInvestor(string name)
        {
            this.Name = name;
        }
        /// <summary>
        /// Method passed to delegate to handle what this class wants when Delegate is Invoked
        /// </summary>
        /// <param name="message">Passed parameter from the delegate</param>
        public void onNotify(string message)
        {
            switch (message)
            {
                case "Buy":
                    System.Console.WriteLine("Sell my Doge Coin!!! \n-Sincerly\n" + this.Name);
                    System.Console.WriteLine("");
                    break;
                case "Sell":
                    System.Console.WriteLine("Buy more Doge Coin!!! \n-Sincerly\n" + this.Name);
                    System.Console.WriteLine("");
                    break;
                default:
                    System.Console.WriteLine("How did we get here!??!?!");
                    break;
            }
        }
    }
}