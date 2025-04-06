namespace MauiPOS.Data;

public static class SeedData
{
    public static List<MenuCategory> GetMenuCategories()
    {
        return new List<MenuCategory>
        {
            new MenuCategory { Id = 1, Name = "Beverages", Icon = @"\Images\drink.png" },
            new MenuCategory { Id = 2, Name = "Main Course", Icon = @"\Images\meal.png" },
            new MenuCategory { Id = 3, Name = "Snacks", Icon = @"\Images\snacks.png" },
            new MenuCategory { Id = 4, Name = "Desserts", Icon = @"\Images\cake.png" },
            new MenuCategory { Id = 5, Name = "Fast Food", Icon = @"\Images\fast_food.png" }
        };
    }
    public static List<MenuItem> GetMenuItems()
    {
        return new List<MenuItem>
        { 
            new MenuItem { Id = 2, Name = "Biryani", Icon = @"\Images\biryani.png", Description = "Spicy chicken biryani", Price = 7.99m },
            new MenuItem { Id = 3, Name = "Buns", Icon = @"\Images\buns.png", Description = "Freshly baked buns", Price = 2.99m },
            new MenuItem { Id = 4, Name = "Burger and Fries Combo", Icon = @"\Images\burger_fries_combo.png", Description = "Burger with fries", Price = 5.99m },
            new MenuItem { Id = 5, Name = "Cake", Icon = @"\Images\cake.png", Description = "Delicious chocolate cake", Price = 3.99m },
            new MenuItem { Id = 6, Name = "Chocolate", Icon = @"\Images\chocolate.png", Description = "Rich chocolate bar", Price = 1.99m },
            new MenuItem { Id = 7, Name = "Cocktail", Icon = @"\Images\cocktail.png", Description = "Refreshing cocktail", Price = 6.99m },
            new MenuItem { Id = 8, Name = "Coffee", Icon = @"\Images\coffee.png", Description = "Hot coffee", Price = 1.99m },
            new MenuItem { Id = 9, Name = "Cupcake", Icon = @"\Images\cupcake.png", Description = "Sweet cupcake", Price = 2.49m },
            new MenuItem { Id = 10, Name = "Donut", Icon = @"\Images\donut.png", Description = "Glazed donut", Price = 1.49m },
            new MenuItem { Id = 11, Name = "Energy Drink", Icon = @"\Images\energy_drink.png", Description = "Energy drink", Price = 2.99m },
            new MenuItem { Id = 12, Name = "Fast Food", Icon = @"\Images\fast_food.png", Description = "Quick and tasty fast food", Price = 5.99m },
            new MenuItem { Id = 13, Name = "Fish and Chips", Icon = @"\Images\fish_and_chips.png", Description = "Crispy fish and chips", Price = 6.99m },
            new MenuItem { Id = 14, Name = "Fish", Icon = @"\Images\fish.png", Description = "Grilled fish", Price = 7.99m },
            new MenuItem { Id = 15, Name = "French Fries", Icon = @"\Images\french_fries.png", Description = "Crispy french fries", Price = 2.99m },
            new MenuItem { Id = 16, Name = "Fried Chicken", Icon = @"\Images\fried_chicken.png", Description = "Crispy fried chicken", Price = 5.99m },
            new MenuItem { Id = 17, Name = "Fried Egg", Icon = @"\Images\fried_egg.png", Description = "Sunny_side_up fried egg", Price = 1.49m },
            new MenuItem { Id = 18, Name = "Fried Rice", Icon = @"\Images\fried_rice.png", Description = "Savory fried rice", Price = 4.99m },
            new MenuItem { Id = 19, Name = "Hamburger", Icon = @"\Images\hamburger.png", Description = "Juicy hamburger", Price = 4.99m },
            new MenuItem { Id = 20, Name = "Hotdog", Icon = @"\Images\hotdog.png", Description = "Grilled hotdog", Price = 3.49m },
            new MenuItem { Id = 21, Name = "Ice Cream", Icon = @"\Images\ice_cream.png", Description = "Cold ice cream", Price = 2.99m },
            new MenuItem { Id = 22, Name = "Idli Platter", Icon = @"\Images\idli_platter.png", Description = "South Indian idli platter", Price = 3.99m },
            new MenuItem { Id = 23, Name = "Kebab", Icon = @"\Images\kebab.png", Description = "Grilled kebab", Price = 5.99m },
            new MenuItem { Id = 24, Name = "Kimchi Jjigae", Icon = @"\Images\kimchi_jjiage.png", Description = "Spicy kimchi stew", Price = 6.99m },
            new MenuItem { Id = 25, Name = "Laddu", Icon = @"\Images\laddu.png", Description = "Sweet laddu", Price = 1.99m },
            new MenuItem { Id = 26, Name = "Lobster", Icon = @"\Images\lobster.png", Description = "Fresh lobster", Price = 15.99m },
            new MenuItem { Id = 27, Name = "Mango", Icon = @"\Images\mango.png", Description = "Ripe mango", Price = 1.49m },
            new MenuItem { Id = 28, Name = "Masala Dosa", Icon = @"\Images\masala_dosa.png", Description = "Crispy masala dosa", Price = 4.99m },
            new MenuItem { Id = 29, Name = "Meal", Icon = @"\Images\meal.png", Description = "Complete meal", Price = 9.99m },
            new MenuItem { Id = 30, Name = "Nachos", Icon = @"\Images\nachos.png", Description = "Cheesy nachos", Price = 3.99m },
            new MenuItem { Id = 31, Name = "Noodles", Icon = @"\Images\noodles.png", Description = "Stir_fried noodles", Price = 4.99m },
            new MenuItem { Id = 32, Name = "Orange Juice", Icon = @"\Images\orange_juice.png", Description = "Fresh orange juice", Price = 2.49m },
            new MenuItem { Id = 33, Name = "Pancakes", Icon = @"\Images\pancakes.png", Description = "Fluffy pancakes", Price = 3.99m },
            new MenuItem { Id = 34, Name = "Paneer", Icon = @"\Images\paneer.png", Description = "Paneer curry", Price = 4.99m },
            new MenuItem { Id = 35, Name = "Pasta", Icon = @"\Images\pasta.png", Description = "Italian pasta", Price = 5.99m },
            new MenuItem { Id = 36, Name = "Pie", Icon = @"\Images\pie.png", Description = "Fruit pie", Price = 3.99m },
            new MenuItem { Id = 37, Name = "Pizza Slice", Icon = @"\Images\pizza_slice.png", Description = "Slice of pizza", Price = 2.99m },
            new MenuItem { Id = 38, Name = "Pizza", Icon = @"\Images\pizza.png", Description = "Whole pizza", Price = 8.99m },
            new MenuItem { Id = 39, Name = "Ramen", Icon = @"\Images\ramen.png", Description = "Japanese ramen", Price = 6.99m },
            new MenuItem { Id = 40, Name = "Rice", Icon = @"\Images\rice.png", Description = "Steamed rice", Price = 1.99m },
            new MenuItem { Id = 41, Name = "Roasted Chicken", Icon = @"\Images\roasted_chicken.png", Description = "Roasted chicken", Price = 7.99m },
            new MenuItem { Id = 42, Name = "Salad Bowl", Icon = @"\Images\salad_bowl.png", Description = "Fresh salad bowl", Price = 4.99m },
            new MenuItem { Id = 43, Name = "Salad Plate", Icon = @"\Images\salad_plate.png", Description = "Fresh salad plate", Price = 4.99m },
            new MenuItem { Id = 44, Name = "Samosa", Icon = @"\Images\samosa.png", Description = "Crispy samosa", Price = 1.99m },
            new MenuItem { Id = 45, Name = "Sandwich", Icon = @"\Images\sandwich.png", Description = "Tasty sandwich", Price = 3.99m },
            new MenuItem { Id = 46, Name = "Snacks", Icon = @"\Images\snacks.png", Description = "Various snacks", Price = 2.99m },
            new MenuItem { Id = 47, Name = "Soda", Icon = @"\Images\soda.png", Description = "Refreshing soda", Price = 1.49m },
            new MenuItem { Id = 48, Name = "Soft Drink", Icon = @"\Images\soft_drink.png", Description = "Cold soft drink", Price = 1.99m },
            new MenuItem { Id = 49, Name = "Soju", Icon = @"\Images\soju.png", Description = "Korean soju", Price = 3.99m },
            new MenuItem { Id = 50, Name = "Spaghetti", Icon = @"\Images\spaghetti.png", Description = "Italian spaghetti", Price = 5.99m },
            new MenuItem { Id = 51, Name = "Sushi", Icon = @"\Images\sushi.png", Description = "Assorted sushi", Price = 8.99m },
            new MenuItem { Id = 52, Name = "Taco", Icon = @"\Images\taco.png", Description = "Mexican taco", Price = 3.99m },
            new MenuItem { Id = 53, Name = "Thai Food", Icon = @"\Images\thai_food.png", Description = "Spicy Thai food", Price = 6.99m },
            new MenuItem { Id = 54, Name = "Thali", Icon = @"\Images\thali.png", Description = "Indian thali", Price = 7.99m },
            new MenuItem { Id = 55, Name = "Wrap", Icon = @"\Images\wrap.png", Description = "Healthy wrap", Price = 4.99m }
        };
    }

    public static List<MenuItemCategoryMapping> GetMenuItemCategoryMappings()
    {
        return new List<MenuItemCategoryMapping>
        {
            new MenuItemCategoryMapping { CategoryId = 1, MenuItemId = 1 },
            new MenuItemCategoryMapping { CategoryId = 1, MenuItemId = 6 },
            new MenuItemCategoryMapping { CategoryId = 1, MenuItemId = 7 },
            new MenuItemCategoryMapping { CategoryId = 1, MenuItemId = 8 },
            new MenuItemCategoryMapping { CategoryId = 1, MenuItemId = 10 },
            new MenuItemCategoryMapping { CategoryId = 1, MenuItemId = 11 },
            new MenuItemCategoryMapping { CategoryId = 1, MenuItemId = 32 },
            new MenuItemCategoryMapping { CategoryId = 1, MenuItemId = 47 },
            new MenuItemCategoryMapping { CategoryId = 1, MenuItemId = 48 },
            new MenuItemCategoryMapping { CategoryId = 1, MenuItemId = 49 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 2 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 13 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 14 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 18 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 20 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 22 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 23 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 24 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 26 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 28 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 29 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 31 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 34 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 35 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 38 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 39 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 40 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 41 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 45 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 50 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 51 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 52 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 53 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 54 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 55 },
            new MenuItemCategoryMapping { CategoryId = 3, MenuItemId = 3 },
            new MenuItemCategoryMapping { CategoryId = 3, MenuItemId = 15 },
            new MenuItemCategoryMapping { CategoryId = 3, MenuItemId = 16 },
            new MenuItemCategoryMapping { CategoryId = 3, MenuItemId = 17 },
            new MenuItemCategoryMapping { CategoryId = 3, MenuItemId = 19 },
            new MenuItemCategoryMapping { CategoryId = 3, MenuItemId = 30 },
            new MenuItemCategoryMapping { CategoryId = 4, MenuItemId = 5 },
            new MenuItemCategoryMapping { CategoryId = 4, MenuItemId = 8 },
            new MenuItemCategoryMapping { CategoryId = 4, MenuItemId = 9 },
            new MenuItemCategoryMapping { CategoryId = 4, MenuItemId = 21 },
            new MenuItemCategoryMapping { CategoryId = 4, MenuItemId = 25 },
            new MenuItemCategoryMapping { CategoryId = 4, MenuItemId = 27 },
            new MenuItemCategoryMapping { CategoryId = 4, MenuItemId = 33 },
            new MenuItemCategoryMapping { CategoryId = 4, MenuItemId = 36 },
            new MenuItemCategoryMapping { CategoryId = 5, MenuItemId = 4 },
            new MenuItemCategoryMapping { CategoryId = 5, MenuItemId = 12 },
            new MenuItemCategoryMapping { CategoryId = 5, MenuItemId = 37 },
            new MenuItemCategoryMapping { CategoryId = 5, MenuItemId = 38 },
            new MenuItemCategoryMapping { CategoryId = 5, MenuItemId = 45 },
            new MenuItemCategoryMapping { CategoryId = 5, MenuItemId = 46 }
        };
    }
}