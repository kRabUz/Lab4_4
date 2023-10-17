using Lab4_4.Abstract;

namespace Lab4_4.Classes.Abstract
{
    public abstract class AbstractVideoCardComponent : LeafComponent
    {
        public AbstractVideoCardComponent(string name, string model, string article, decimal price)
        {
            Name = name;
            Model = model;
            Article = article;
            Price = price;
        }

        public override string Category { get; set; } = "VideoCard";
        public abstract string Model { get; set; }

    }
}
