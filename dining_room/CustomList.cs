using System;
using System.Collections;
using System.Collections.Generic;

namespace dining_room
{
    public class CustomList<T> : ICollection<T> where T : Product
    {
        
        public List<T> MyList { get; set; }
        public int Count => MyList.Count;
        public bool IsReadOnly => false;
        public CustomList()
        {
            MyList = new List<T>();
        }
        
        public T this[int index]
        {
            get => MyList[index];
            set => MyList[index] = value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            if (!Contains(item))
            {
                MyList.Add(item);
            }
            else
            {
                Console.WriteLine("");
            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        
    }
}