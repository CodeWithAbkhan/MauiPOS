using MauiPOS.Data;
using MauiPOS.Models;
using MenuItem = MauiPOS.Data.MenuItem;

namespace MauiPOS.Repositories
{
    public class HomeRepository
    {
        private readonly DatabaseService _databaseService;
        private readonly OrdersRepository _ordersRepository;
        private readonly SettingsRepository _settingsRepository;

        public HomeRepository(DatabaseService databaseService, OrdersRepository ordersRepository, SettingsRepository settingsRepository)
        {
            _databaseService = databaseService;
            _ordersRepository = ordersRepository;
            _settingsRepository = settingsRepository;
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

        public int GetTaxPercentage()
        {
            return _settingsRepository.GetTaxPercentage();
        }

        public void SetTaxPercentage(int taxPercentage)
        {
            _settingsRepository.SetTaxPercentage(taxPercentage);
        }

        public async Task<bool> PlaceOrderAsync(CartModel[] cartItems, bool isPaidCash)
        {
            return await _ordersRepository.CreateOrderAsync(cartItems, isPaidCash);
        }
    }
}