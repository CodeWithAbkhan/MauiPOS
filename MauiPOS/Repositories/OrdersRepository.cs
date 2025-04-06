using MauiPOS.Data;
using MauiPOS.Models;

namespace MauiPOS.Repositories
{
    public class OrdersRepository
    {
        private readonly DatabaseService _databaseService;

        public OrdersRepository(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public async Task<OrderModel[]> GetOrdersAsync()
        {
            var dbOrders = await _databaseService.GetOrdersAsync();
            return dbOrders.Select(o => new OrderModel
            {
                Id = o.Id,
                OrderDate = o.OrderDate,
                PaymentMode = o.PaymentMode,
                TotalAmountPaid = o.TotalAmountPaid,
                TotalItemsCount = o.TotalItemsCount
            }).ToArray();
        }

        public async Task<OrderItem[]> GetOrderItemsByOrderIdAsync(int orderId)
        {
            return await _databaseService.GetOrderItemsByOrderIdAsync(orderId);
        }

        public async Task<bool> CreateOrderAsync(CartModel[] cartItems, bool isPaidCash)
        {
            var orderItems = cartItems
                .Select(item => new OrderItem
                {
                    MenuItemId = item.ItemId,
                    Name = item.Name,
                    Icon = item.Icon,
                    Price = item.Price,
                    Quantity = item.Quantity
                }).ToArray();

            var order = new OrderModel
            {
                OrderDate = DateTime.Now,
                PaymentMode = isPaidCash ? "Cash" : "Online",
                TotalAmountPaid = cartItems.Sum(i => i.Amount),
                TotalItemsCount = cartItems.Length,
                Items = orderItems
            };

            var errorMessage = await _databaseService.PlaceOrderAsync(order);
            return string.IsNullOrEmpty(errorMessage);
        }
    }
}