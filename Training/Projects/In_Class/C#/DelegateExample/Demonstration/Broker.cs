using System;

namespace Demonstration
{
    // Defines a delegate with output = void and parameter = string
    public delegate void InvestmentAdvice(string StockState);
    public class Broker
    {
        public event InvestmentAdvice AdviceInstance;
        public string _name;
        public string Name { get => _name; set => _name = value; }
        public Broker(string name)
        {
            this.Name = name;
        }
        public void Notify(bool isHigher)
        {
            // Define an event in the market that the delegate reacts to with advice to the investor
            if (isHigher)
            {
                AdviceInstance("Sell");
            }
            else{
                AdviceInstance("Buy");
            }
        }

        public void UpdateStock(bool isStockRising)
        {
            Console.WriteLine("Reached UpdateStock: " + this.Name + "\nStock Rising?: " + isStockRising);

            // New Stock information comes in about the Stock Market
            Notify(isStockRising);
        }
    }
}