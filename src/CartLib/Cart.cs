using System;
using System.Collections.Generic;
using System.Linq;

namespace CartLib
{
    /// <summary>
    /// A shared class to represent a shopping cart
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// List of items in the cart
        /// </summary>
        public List<CartItem> Items = new List<CartItem>();

        /// <summary>
        /// Is the cart empty
        /// </summary>
        public bool IsEmpty => Items.Count == 0;

        /// <summary>
        /// Total number of items
        /// </summary>
        public int CartCount => Items.Sum(i => i.Quantity);

        /// <summary>
        /// Compute cart total
        /// </summary>
        public decimal CartTotal => Items.Sum(i => i.Total);

        public void AddProduct(Product product)
        {
            // check cart
            var existing = Items.FirstOrDefault(i => i.Code == product.Code);
            if (existing == null)
                // add new item
                Items.Add(new CartItem() { Code = product.Code, Name = product.Name, Price = product.Price, Quantity = 1 });
            else
                // increment count on item
                existing.Quantity += 1;
        }

        /// <summary>
        /// Add 1 to qty for code
        /// </summary>
        /// <param name="code"></param>
        public void IncrementItem(string code)
        {
            var existing = GetExistingItem(code);
            if (existing != null)
                existing.Quantity += 1;
        }

        public void RemoveItem(string code)
        {
            var existing = GetExistingItem(code);
            if (existing != null)
                existing.Quantity -= 1;
            // if qty is zero, remove
            if (existing.Quantity <= 0)
                _ = Items.Remove(existing);
        }

        private CartItem GetExistingItem(string code)
        {
            return Items.FirstOrDefault(i => i.Code == code);
        }
    }
}
