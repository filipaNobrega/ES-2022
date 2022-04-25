namespace ObjectvilleFamilyHouse.FirstVersion
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
            // For teaching purposes, we'll consider that unifying the implementation is not allowed

            // Because we've two different menu representations (ArrayList vs Array), the Waitress implementation needs to get both menus
            // and use two loops to iterate through their items.
            var breakfastItems = _pancakeHouseMenu.MenuItems;
            foreach(var menuItem in breakfastItems)
            {
                if (menuItem != null)
                {
                    Console.WriteLine(menuItem);
                }
            }

            var lunchItems = _dinerMenu.MenuItems;
            for (var i = 0; i < lunchItems.Length; i++)
            {
                var menuItem = lunchItems[i];
                if (menuItem != null)
                {
                    Console.WriteLine(menuItem);
                }
            }
        }

        public void PrintBreakfastMenu()
        {
            var breakfastItems = _pancakeHouseMenu.MenuItems;
            foreach (var menuItem in breakfastItems)
            {
                if (menuItem != null)
                {
                    Console.WriteLine(menuItem);
                }
            }
        }

        public void PrintLunchMenu()
        {
            var lunchItems = _dinerMenu.MenuItems;
            for (var i = 0; i < lunchItems.Length; i++)
            {
                var menuItem = lunchItems[i];
                if (menuItem != null)
                {
                    Console.WriteLine(menuItem);
                }
            }
        }

        public void PrintVegetarianMenu()
        {
            var breakfastItems = _pancakeHouseMenu.MenuItems;
            foreach (var menuItem in breakfastItems)
            {
                if (menuItem != null)
                {
                    Console.WriteLine(menuItem);
                }
            }

            var lunchItems = _dinerMenu.MenuItems;
            for (var i = 0; i < lunchItems.Length; i++)
            {
                var menuItem = lunchItems[i];
                if (menuItem != null && menuItem.IsVegetarian)
                {
                    Console.WriteLine(menuItem);
                }
            }
        }
    }
}