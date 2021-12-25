
using System.Collections.Generic;

namespace GenericSwapMethodStrings
{
    public class Box<T>
    {
        public Box()
        {
            List = new List<T>();
        }

        public List<T> List { get; set; }

        public List<T> SwapIndexes(int idx1, int idx2)
        {
            T firstElement = List[idx1];
            T secondElement = List[idx2];
            List[idx1] = secondElement;
            List[idx2] = firstElement;

            return List;
        }

        public override string ToString()
        {
            return $"{typeof(T)}";
        }
    }
}
