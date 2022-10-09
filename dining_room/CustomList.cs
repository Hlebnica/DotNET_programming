using System.Collections;
using System.Collections.Generic;

namespace dining_room
{
    public class CustomList : IEnumerable
    {
        private List<string> _products = new();
        public void AppendInList(string nameOfProduct)
        {
            _products.Add(nameOfProduct);
        }
        public IEnumerator GetEnumerator() => _products.GetEnumerator();
    }
}