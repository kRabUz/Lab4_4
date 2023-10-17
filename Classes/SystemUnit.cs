using Lab4_4.Abstract;
using System.Collections.Generic;

namespace Lab4_4.Classes
{
    public class SystemUnit : LeafComponent
    {
        public SystemUnit(string name, string article, decimal price)
        {
            Name = name;
            Article = article;
            Price = price;
        }

        protected List<LeafComponent> _components = new List<LeafComponent>();

        public override string Category { get; set; } = "System Unit";

        public override string Name { get; set; }

        public override string Article { get; set; }

        public override decimal Price { get; set; }

        public override void Add(LeafComponent component)
        {
            _components.Add(component);
        }

        public override void Remove(LeafComponent component)
        {
            _components.Remove(component);
        }

        public override decimal GetPrice()
        {
            decimal price = Price;

            foreach (LeafComponent component in _components)
            {
                price += component.GetPrice();
            }

            return price * (1 + CollectionPriceConstants.SystemUnitCollectionPremium / 100);
        }
    }
}
