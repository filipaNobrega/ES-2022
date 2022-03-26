namespace XShop.FirstVersion
{
    public class Computer
    {
        private string _version;
        private string _platform;
        private string _fullname;

        private readonly List<Component> _components = new List<Component>();
        
        public IList<Component> Components { get { return _components; } }

        public Computer(string version, string platform, string fullname)
        {
            _version = version;
            _platform = platform;
            _fullname = fullname;
        }

        public double CalculatePrice()
        {
            double total = 0.0d;
            foreach (Component component in _components)
            {
                total += component.Price;
            }
            return total;
        }
    }
}