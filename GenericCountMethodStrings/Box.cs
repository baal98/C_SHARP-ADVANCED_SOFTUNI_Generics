using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodStrings
{
    public class Box<T> where T : IComparable<T>
    {
        private List<T> list;

        public Box()
        {
            list = new List<T>();
        }

        public void Add(T item)
        {
            list.Add(item);
        }
        public int Count(T element)
        {
            int count = 0;
            foreach (T item in list)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }

            return count;
        }

    }
}
