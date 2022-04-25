namespace ObjectvilleFamilyHouse.SecondVersion
{
    public class MenuItem
    {
        public MenuItem(string name, string description, bool isVegetarian, double price)
        {
            Name = name;
            Description = description;
            IsVegetarian = isVegetarian;
            Price = price;
        }

        public string Name { get; }
        public string Description { get; }
        public bool IsVegetarian { get; }
        public double Price { get; }

        public override string ToString()
        {
            return $"{Name} - {Description} : {Price}";
        }
    }
}