using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    /// <summary>
    /// Simple product class
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Product code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Product name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Unit price
        /// </summary>
        public decimal Price { get; set; }
    }
}
