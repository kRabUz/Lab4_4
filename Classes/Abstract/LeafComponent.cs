using Lab4_4.Classes.Abstract;

namespace Lab4_4.Abstract
{
    public abstract class LeafComponent : Composite
    {
        public abstract string Category { get; set; }
        public abstract string Name { get; set; }
        public abstract string Article { get; set; }
        public abstract decimal Price { get; set; }
    }
}
