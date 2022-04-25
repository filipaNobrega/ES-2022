namespace ObjectvilleFamilyHouse.FirstVersion
{
    // @source Breaking News: Objectville Diner and Objectville Pancake House Merge (from Head First Design Pattens book)
    class Program
    {
        static void Main(string[] args)
        {
            var dinerMenu = new DinerMenu();
            var pancakeHouseMenu = new PancakeHouseMenu();

            Console.WriteLine("Welcome to Objectville Family House");
            var waitress = new Waitress(dinerMenu, pancakeHouseMenu);

            Console.WriteLine("\n--------- MENU --------");
            waitress.PrintMenu();

            Console.WriteLine("\n--- BREAKFAST MENU ----");
            waitress.PrintBreakfastMenu();

            Console.WriteLine("\n----- LUNCH MENU ------");
            waitress.PrintLunchMenu();

            Console.WriteLine("\n--- VEGETARIAN MENU ---");
            waitress.PrintVegetarianMenu();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
