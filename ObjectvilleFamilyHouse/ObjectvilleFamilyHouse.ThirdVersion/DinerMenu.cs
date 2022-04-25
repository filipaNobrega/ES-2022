using System.Collections;

namespace ObjectvilleFamilyHouse.ThirdVersion
{
    public class DinerMenu : IEnumerable
    {
        private const int MaxItems = 6;
        private int _numberOfItems;
        private readonly MenuItem[] _menuItems;

        public DinerMenu()
        {
            _menuItems = new MenuItem[MaxItems];
            AddItem("Vegetarian BLT", "(Faking) Bacon with lettuce & tomato on whole wheat", true, 2.99);
            AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);
            AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 2.99);
            AddItem("Hotdog", "A hot dog, with saurkraut, relish, onions, topped with cheese", false, 3.05);
        }

        public void AddItem(string name, string description, bool isVegetarian, double price)
        {
            var menuItem = new MenuItem(name, description, isVegetarian, price);
            if (_numberOfItems >= MaxItems)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry, menu is full! Can't add item to menu");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                _menuItems[_numberOfItems] = menuItem;
                _numberOfItems++;
            }
        }

        public IEnumerator GetEnumerator()
        {
            // Using yield to define an iterator removes the need for an explicit extra class
            foreach (var item in _menuItems)
            {
                yield return item;
            }
        }
    }
}