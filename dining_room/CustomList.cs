using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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

        public void Add(T item)
        {
            MyList.Add(item);
        }

        public void Clear()
        {
            MyList.Clear();
        }

        public bool Contains(T item)
        {
            bool contain = false;
            foreach (T unused in MyList.Where(temp => temp.Equals(item)))
            {
                contain = true;
            }
            return contain;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null)  
                throw new ArgumentNullException("Массив не может быть пустым");
            if (arrayIndex < 0) 
                throw new ArgumentOutOfRangeException("Начальный индекс массива не может быть отрицательным");
            if (Count > array.Length - arrayIndex) 
                throw new ArgumentException("Массив имеет меньше элементов, чем коллекция");
            for (int i = 0; i < MyList.Count; i++) 
            {
                array[i + arrayIndex] = MyList[i];
            }
        }

        public bool Remove(T item)
        {
            bool result = false;
            for (int i = 0; i < MyList.Count; i++)
            {
                T currentT = (T)MyList[i];
                if (item != null && item.GetHashCode() == currentT.GetHashCode())
                {
                    MyList.Remove(MyList[i]);
                    result = true;
                    break;
                }
            }
            return result;
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            return MyList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return MyList.GetEnumerator();
        }
        
        public void SortByField(Func<Product, Product, bool> funcRealization)
        {
            for (int i = 0; i < MyList.Count; i++)
            {
                for(int j = i + 1; j < MyList.Count; j++)
                {
                    if(funcRealization(MyList[i], MyList[j]))
                    {
                        (MyList[i], MyList[j]) = (MyList[j], MyList[i]);
                    }
                }
            }
        }
        
        public void Foreach(Action<T> action)
        {
            if (action == null) 
                Console.WriteLine("Action не установлен");
            else
            {
                foreach(var item in MyList)
                {
                    action.Invoke(item);
                }
            }
            
        }
    }
}