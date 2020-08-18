using System;
using System.Collections.Generic;
using System.Linq;

namespace Shared
{
    /// <summary>
    /// A shared class to represent a shopping cart
    /// </summary>
    public class Cart 
    {

        public List<CartItem> Items = new List<CartItem>();

        public bool IsEmpty => Items.Count == 0;

        public void AddProduct(Product product)
        {
            // check cart
            var existing = Items.FirstOrDefault(i => i.Code == product.Code);
            if(existing == null)
            {
                // add new item
                Items.Add(new CartItem() { Code = product.Code, Name = product.Name, Price = product.Price, Quantity = 1 });
            }
            else
            {
                existing.Quantity += 1;
            }
        }
    }
}
