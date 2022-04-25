using ObjectvilleFamilyHouse.LastVersion;

// @source Breaking News: Objectville Diner and Objectville Pancake House Merge (from Head First Design Pattens book)
// Using the Composite pattern to compose menu components into tree structure
IMenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
pancakeHouseMenu.Add(new MenuItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs and toast", true, 2.99));
pancakeHouseMenu.Add(new MenuItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99));
pancakeHouseMenu.Add(new MenuItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49));
pancakeHouseMenu.Add(new MenuItem("Waffles", "Waffles, with your choice blueberries or strawberries", true, 3.59));

IMenuComponent dinerMenu = new Menu("DINER MENU", "Lunch");
dinerMenu.Add(new MenuItem("Vegetarian BLT", "(Faking) Bacon with lettuce & tomato on whole wheat", true, 2.99));
dinerMenu.Add(new MenuItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99));
dinerMenu.Add(new MenuItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 2.99));
dinerMenu.Add(new MenuItem("Hotdog", "A hot dog, with sauerkraut, relish, onions, topped with cheese", false, 3.05));


IMenuComponent cafeMenu = new Menu("CAFÉ MENU", "Dinner");
cafeMenu.Add(new MenuItem("Veggie Burger and Air Fries", "Veggie burger on a whole wheat bun, lettuce, tomato, and fries", true, 3.99));
cafeMenu.Add(new MenuItem("Soup of the day", "A cup of the soup of the day, with a side salad", false, 3.69));
cafeMenu.Add(new MenuItem("Burrito", "A large burrito, with whole pinto beans, salsa, guacamole", true, 4.29));

IMenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert of course!");
dessertMenu.Add(new MenuItem("Apple Pie", "Apple pie with a flaky crust, topped with vanilla ice-cream", true, 1.59));

dinerMenu.Add(dessertMenu);

IMenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");
allMenus.Add(pancakeHouseMenu);
allMenus.Add(dinerMenu);
allMenus.Add(cafeMenu);

Waitress waitress = new Waitress(allMenus);
waitress.PrintMenu();

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();