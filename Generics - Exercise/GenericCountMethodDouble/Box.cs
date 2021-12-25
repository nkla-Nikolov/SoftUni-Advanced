using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodDouble
{
    public class Box<T> where T : IComparable
    {
        
        public Box()
        {
            List = new List<T>();
        }

        public List<T> List { get; set; }

        public int CounterThan(T item)
        {
            int count = 0;

            foreach (var currentItem in List)
            {
                if (currentItem.CompareTo(item) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
