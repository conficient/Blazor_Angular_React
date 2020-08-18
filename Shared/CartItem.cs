using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class CartItem
    {
        /// <summary>
        /// Product code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Name of the item
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Number of units
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Computed total for this item
        /// </summary>
        public decimal Total => Price * Quantity;
    }
}
