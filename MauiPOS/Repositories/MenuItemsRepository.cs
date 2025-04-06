using MauiPOS.Data;
using MauiPOS.Models;
using MenuItem = MauiPOS.Data.MenuItem;

namespace MauiPOS.Repositories
{
    public class MenuItemsRepository
    {
        private readonly DatabaseService _databaseService;

        public MenuItemsRepository(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public async Task<MenuCategoryModel[]> GetMenuCategoriesAsync()
        {
            var categories = await _databaseService.GetMenuCategoriesAsync();
            return categories.Select(MenuCategoryModel.FromEntity).ToArray();
        }

        public async Task<MenuItem[]> GetMenuItemsByCategoryIdAsync(int categoryId)
        {
            return await _databaseService.GetMenuItemsByCategoryIdAsync(categoryId);
        }

        public async Task<MenuItemModel> GetMenuItemForEditAsync(int menuItemId)
        {
            var menuItem = (await _databaseService.GetMenuItemsByCategoryIdAsync(0)) // Assuming 0 fetches all or adjust logic
                .FirstOrDefault(m => m.Id == menuItemId);

            if (menuItem == null) return new MenuItemModel();

            var menuItemModel = new MenuItemModel
            {
                Id = menuItem.Id,
                Name = menuItem.Name,
                Description = menuItem.Description,
                Price = menuItem.Price,
                Icon = menuItem.Icon
            };

            var itemCategories = await _databaseService.GetCategoriesByMenuItemIdAsync(menuItem.Id);
            var allCategories = await GetMenuCategoriesAsync();

            foreach (var category in allCategories)
            {
                var categoryOfItem = new MenuCategoryModel
                {
                    Icon = category.Icon,
                    Id = category.Id,
                    Name = category.Name,
                    IsSelected = itemCategories.Any(c => c.Id == category.Id)
                };
                menuItemModel.Categories.Add(categoryOfItem);
            }

            return menuItemModel;
        }

        public async Task<string?> SaveMenuItemAsync(MenuItemModel model)
        {
            return await _databaseService.SaveMenuItemAsync(model);
        }

        public MenuItemModel CreateNewMenuItemModel(MenuCategoryModel[] categories)
        {
            var menuItem = new MenuItemModel();
            foreach (var category in categories)
            {
                menuItem.Categories.Add(new MenuCategoryModel
                {
                    Id = category.Id,
                    Icon = category.Icon,
                    Name = category.Name,
                    IsSelected = false
                });
            }
            return menuItem;
        }
    }
}