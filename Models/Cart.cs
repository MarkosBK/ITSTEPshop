using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_SHOP.Models
{
    public class Cart
    {
        private List<CartItem> cartItems = new List<CartItem>();
        public IEnumerable<CartItem> CartItems => cartItems;

        public void AddItem(Good good, int quantity)
        {
            CartItem newItem = cartItems.FirstOrDefault(g=>g.Good.Id==good.Id);
            if (newItem == null)
            {
                cartItems.Add(new CartItem() { Good = good, Quantity = quantity });
            }
            else
            {
                newItem.Quantity += quantity;
            }
        }

        public void RemoveItem(Good good)
        {
            cartItems.RemoveAll(g => g.Good.Id == good.Id);
        }
        public void Clear()
        {
            cartItems.Clear();
        }

        public double CalculateTotalPrice()
        {
            return cartItems.Sum(g => g.Good.Price * g.Quantity);
        }
    }
}