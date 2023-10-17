using Lab4_4.Abstract;
using Lab4_4.Classes.Abstract;
using System;

namespace Lab4_4.Classes
{
    public class IntelProcessor : AbstractProcessorComponent
    {
        public IntelProcessor(int clockFrequency, int numberOfCores, string article, decimal price) : base("Intel", clockFrequency, numberOfCores, article, price)
        {
        }

        public override string Name { get; set; }
        public override int ClockFrequency { get; set; }
        public override int NumberOfCores { get; set; }
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
