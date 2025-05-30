﻿

using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiPOS.Models
{
    public partial class CartModel : ObservableObject
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public decimal Price { get; set; }

        [ObservableProperty, NotifyPropertyChangedFor(nameof(Amount))]
        private int _quantity = 1000;

        public decimal Amount
        {
            get
            {
                int quantity = Quantity;
                return Price * quantity;
            }
        }
    }
}
