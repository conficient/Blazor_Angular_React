using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartLib
{
    /// <summary>
    /// "Database" to store all products
    /// </summary>
    public static class ProductDB
    {
        public static List<Product> GetProducts()
        {
            return new List<Product>()
            { 
                new Product { Code="001", Name = "Baked Beans", Price = 0.45m },
                new Product { Code="002", Name = "Medium Eggs (x12)", Price = 1.25m },
                new Product { Code="003", Name = "Sausages", Price = 2.99m },
                new Product { Code="004", Name = "Apples (x4)", Price = 1.45m },
            };
        }
    }
}
