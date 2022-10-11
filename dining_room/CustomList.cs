using System.Collections;
using System.Collections.Generic;

namespace dining_room
{
    public class CustomList : IEnumerable
    {
        public List<string> _products = new();

        public void AppendInList(string nameOfProduct)
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