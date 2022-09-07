using System;
using System.Collections.Generic;

namespace dining_room
{
    public class ProductSorter : IComparer<Product> 
    {
        public int Compare(Product product, Product other)
        {
            if (other != null && product != null && !product.ProductName.Equals(other.ProductName))
            {
                return product.ProductName.CompareTo(other.ProductName);
            }
            return product!.Price.CompareTo(other!.Price);
            
        }
    }
}