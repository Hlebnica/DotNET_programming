using System;
using System.Collections.Generic;

namespace dining_room
{
    public class ProductSorter<T> : IComparer<T>  where T : Product
    {
        public int Compare(T product, T other)
        {
            if (other != null && product != null && !product.ProductName.Equals(other.ProductName))
            {
                return product.ProductName.CompareTo(other.ProductName);
            }
            return product!.Price.CompareTo(other!.Price);
        }
    }
}