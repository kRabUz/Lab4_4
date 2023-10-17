using Lab4_4.Abstract;
using System.Collections.Generic;

namespace Lab4_4.Classes
{
    public class Computer
    {
        protected List<LeafComponent> _components = new List<LeafComponent>();

        public void Add(LeafComponent component)
        {
            _components.Add(component);
        }

        public void Remove(LeafComponent component)
        {
            _components.Remove(component);
        }

        public decimal GetPrice()
        {
            decimal price = 0;

            foreach (LeafComponent component in _components)
            {
                price += component.GetPrice();
            }

            return price * (1 + CollectionPriceConstants.ComputerCollectionPremium / 100);
        }
    }
}
