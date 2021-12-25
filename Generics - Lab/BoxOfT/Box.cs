using System.Collections.Generic;

namespace BoxOfT
{
   public class Box<T>
   {
       private List<T> list = new List<T>();

       public int Count { get => list.Count; }

       public void Add(T element)
        {
            list.Add(element);
        }

        public T Remove()
        {
            T element = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return element;
        }

    }
}
