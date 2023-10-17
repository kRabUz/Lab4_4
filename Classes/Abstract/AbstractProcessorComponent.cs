using Lab4_4.Abstract;

namespace Lab4_4.Classes.Abstract
{
    public abstract class AbstractProcessorComponent : LeafComponent
    {
        public AbstractProcessorComponent(string name, int clockFrequency, int numberOfCores, string article, decimal price)
        {
            Name = name;
            ClockFrequency = clockFrequency;
            NumberOfCores = numberOfCores;
            Article = article;
            Price = price;
        }

        public override string Category { get; set; } = "Processor";
        public abstract int ClockFrequency { get; set; }
        public abstract int NumberOfCores { get; set; }
    }
}
