namespace ObjectvilleFamilyHouse.ThirdVersion
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
            while (breakfastEnumerator.MoveNext())
            {
                var menuItem = (MenuItem)breakfastEnumerator.Current;
                if (menuItem != null)
                {
                    Console.WriteLine(menuItem);
                }
            }

            var lunchEnumerator = _dinerMenu.GetEnumerator();
            while (lunchEnumerator.MoveNext())
            {
                var menuItem = (MenuItem)lunchEnumerator.Current;
                if (menuItem != null)
                {
                    Console.WriteLine(menuItem);
                }
            }
        }

        public void PrintBreakfastMenu()
        {
            var breakfastEnumerator = _pancakeHouseMenu.GetEnumerator();
            while (breakfastEnumerator.MoveNext())
            {
                var menuItem = (MenuItem)breakfastEnumerator.Current;
                if (menuItem != null)
                {
                    Console.WriteLine(menuItem);
                }
            }
        }

        public void PrintLunchMenu()
        {
            var lunchEnumerator = _dinerMenu.GetEnumerator();
            while (lunchEnumerator.MoveNext())
            {
                var menuItem = (MenuItem)lunchEnumerator.Current;
                if (menuItem != null)
                {
                    Console.WriteLine(menuItem);
                }
            }
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