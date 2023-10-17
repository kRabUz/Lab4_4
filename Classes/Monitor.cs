using Lab4_4.Abstract;
using System;

namespace Lab4_4.Classes
{
    public class Monitor : LeafComponent
    {
        public Monitor(string name, double screenDiagonal, string article, decimal price)
        {
            Name = name;
            ScreenDiagonal = screenDiagonal;
            Article = article;
            Price = price;
        }

        public override string Category { get; set; } = "Monitor";

        public override string Name { get; set; }
        public double ScreenDiagonal { get; set; }

        public override string Article { get; set; }

        public override decimal Price { get; set; }

        public override void Add(LeafComponent component)
        {
            throw new NotImplementedException();
        }

        public override void Remove(LeafComponent component)
        {
            throw new NotImplementedException();
        }

        public override decimal GetPrice()
        {
            return Price;
        }

    }
}
