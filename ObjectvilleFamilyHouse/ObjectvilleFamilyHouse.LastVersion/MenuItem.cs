namespace ObjectvilleFamilyHouse.LastVersion
{
    public class MenuItem : MenuComponent
    {
        public MenuItem(string name, string description, bool isVegetarian, double price) : base(name, description)
        {
            IsVegetarian = isVegetarian;
            Price = price;
        }

        public bool IsVegetarian { get; }
        public double Price { get; }

        public override string ToString()
        {
            return $"{Name} - {Description} : {Price}";
        }
    }
}