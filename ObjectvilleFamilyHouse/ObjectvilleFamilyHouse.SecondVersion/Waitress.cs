using System.Collections;

namespace ObjectvilleFamilyHouse.SecondVersion
{
    public class Waitress
    {
        private readonly DinerMenu _dinerMenu;
        private readonly PancakeHouseMenu _pancakeHouseMenu;

        public Waitress(DinerMenu dinerMenu, PancakeHouseMenu pancakeHouseMenu)
        {
            _dinerMenu = dinerMenu;
            _pancakeHouseMenu = pancakeHouseMenu;
        }

        public void PrintMenu()
        {
            var breakfastEnumerator = _pancakeHouseMenu.GetEnumerator();
            PrintMenu(breakfastEnumerator);

            var lunchEnumerator = _dinerMenu.GetEnumerator();
            PrintMenu(lunchEnumerator);
        }

        private static void PrintMenu(IEnumerator breakfastEnumerator)
        {
            // By using the Iterator pattern, we got rid of some redundancy in the process
            // Now the Menu implementation are encapsulated. The Waitress has no idea how the Menus hold their collection of menu items
            while (breakfastEnumerator.MoveNext())
            {
                var menuItem = (MenuItem) breakfastEnumerator.Current;
                if (menuItem != null)
                {
                    Console.WriteLine(menuItem);
                }
            }
        }

        public void PrintBreakfastMenu()
        {
            var breakfastEnumerator = _pancakeHouseMenu.GetEnumerator();
            PrintMenu(breakfastEnumerator);
        }

        public void PrintLunchMenu()
        {
            var lunchEnumerator = _dinerMenu.GetEnumerator();
            PrintMenu(lunchEnumerator);
        }

        public void PrintVegetarianMenu()
        {
            var breakfastEnumerator = _pancakeHouseMenu.GetEnumerator();
            while (breakfastEnumerator.MoveNext())
            {
                var menuItem = (MenuItem)breakfastEnumerator.Current;
                if (menuItem != null && menuItem.IsVegetarian)
                {
                    Console.WriteLine(menuItem);
                }
            }

            var lunchEnumerator = _dinerMenu.GetEnumerator();
            while (lunchEnumerator.MoveNext())
            {
                var menuItem = (MenuItem)lunchEnumerator.Current;
                if (menuItem != null && menuItem.IsVegetarian)
                {
                    Console.WriteLine(menuItem);
                }
            }
        }
    }
}