using Lab4_4.Abstract;

namespace Lab4_4.Classes.Abstract
{
    public abstract class Composite
    {
        public abstract void Add(LeafComponent component);
        public abstract void Remove(LeafComponent component);
        public abstract decimal GetPrice();
    }
}
