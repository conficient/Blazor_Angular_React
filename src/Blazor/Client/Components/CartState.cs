using CartLib;
using System;

namespace Blazor.Client.Components
{
    /// <summary>
    /// A state machine for the cart
    /// </summary>
    public class CartState
    {
        public CartState()
        {
            // create an empty cart
            Cart = new Cart();
        }

        // 
        public event Action OnChange;  // event for changes

        /// <summary>
        /// Notify consumers the cart has changed
        /// </summary>
        private void NotifyStateChanged() => OnChange?.Invoke();


        /// <summary>
        /// Cart object 
        /// </summary>
        public Cart Cart { get; private set; }

        /// <summary>
        /// Add a product to the cart
        /// </summary>
        /// <param name="product"></param>
        public void AddProduct(Product product)
        {
            Cart.AddProduct(product);
            NotifyStateChanged();
        }

        public void IncrementItem(string code)
        {
            Cart.IncrementItem(code);
            NotifyStateChanged();
        }

        public void RemoveItem(string code)
        {
            Cart.RemoveItem(code);
            NotifyStateChanged();
        }

        /// <summary>
        /// Remove all items
        /// </summary>
        public void ClearAll()
        {
            Cart.Items.Clear();
            NotifyStateChanged();
        }
    }
}
