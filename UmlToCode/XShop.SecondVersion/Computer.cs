using System.Collections;

namespace XShop.SecondVersion
{
    public class Computer
    {
        private string _version;
        private string _platform;
        private string _fullname;

        // Do not expose _components
        private readonly Dictionary<Component, int> _components = new Dictionary<Component, int>();

        public Computer(string version, string platform, string fullname)
        {
            _version = version;
            _platform = platform;
            _fullname = fullname;
        }

        public void AddOrUpdate(Component component, int quantity)
        {
            if (_components.ContainsKey(component))
            {
                _components[component] = quantity;
            } else
            {
                _components.Add(component, quantity);
            }
        }

        public void Remove(Component component)
        {
            if (!_components.ContainsKey(component))
            {
                return;
            }
            _components.Remove(component);
        }

        public IEnumerator GetEnumerator()
        {
            return _components.Keys.GetEnumerator();
        }

        public double CalculatePrice()
        {
            double total = 0.0d;
            foreach (Component component in _components.Keys)
            {
                total += component.Price * _components[component];
            }
            return total;
        }
    }
}