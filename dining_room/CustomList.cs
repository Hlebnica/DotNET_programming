using System;
using System.Collections;
using System.Collections.Generic;

namespace dining_room
{
    public class CustomList : IEnumerable
    {
        public List<Object> _products = new();

        public void AppendInList(Object nameOfProduct)
        {
            _products.Add(nameOfProduct);
        }

        
        
        public void ClearList()
        {
            _products.Clear();
        }
        
        public IEnumerator GetEnumerator() => _products.GetEnumerator();
    }
}