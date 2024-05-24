using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class CustomList<T>
    {
        private int capacity;
        private int count;
        public int Capacity { get => capacity; }
        public int Count { get => count; }
        private T[] items;
        public T[] Items { get => items; }

        private int InitialCount = 4;

        public CustomList()
        {
            items = new T[0];
            capacity = items.Length;
        }

        public void Add(T item)
        {
            if (count == capacity)
            {

                Array.Resize(ref items, capacity == 0 ? InitialCount : items.Length *2);
                capacity = items.Length;
            }

            items[count] = item;
            count ++;
        }

        public void GetAll()
        {
            for (int i = 0; i < count ; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
        public void Remove(T item)
        {
            var index = Array.IndexOf(items, item);
            if (index != -1)
            {
                for (int i = 0; i < count; i++)
                {
                    items[i] = items[i + 1];
                }
                count--;
                
            }
        }

        public bool Contains(T item)
        {
            var index = Array.IndexOf<T>(items, item);
            if(index != -1)
                return true;
            return false;
        }

        public bool Any()
        {
            if(count == 0)
                return false;
            return true;
        }

        public void Clear()
        {
            for (int i = 0; i < count; i++)
                items[i] = default;
            count = 0;
        }

        public T FirstOrNull()
        {
            if (count == 0)
                return default;
            return items[0];
        }

        public T ElementAtOrDefault(int index)
        {
            if (count <= index)
                return default;
            else return items[index];
        }

        public T LastOrDefault()
        {
            if (count == 0)
                return default;
            return items[count - 1];
        }

    }
}
