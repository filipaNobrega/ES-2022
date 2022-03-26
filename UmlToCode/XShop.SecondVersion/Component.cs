namespace XShop.SecondVersion
{
    public abstract class Component
    {
        protected string Brand { get; }
        protected string Model { get; }

        // Use fields only for variables that have private or protected accessibility.
        private double _price;
        // Public property exposes _price field safely.
        public double Price { get { return _price; } }

        protected Component(string brand, string model, double price)
        {
            Brand = brand;
            Model = model;
            _price = price;
        }
    }
}