using System;
using System.Linq;

namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> getMin = x =>
            {
                int min = int.MaxValue;

                foreach (var item in x)
                {
                    if (item < min)
                    {
                        min = item;
                    }
                }

                return min;
            };

            Console.WriteLine(getMin(Console.ReadLine().Split(" ").Select(int.Parse).ToArray()));
        }
    }
}
