using System;

namespace GenericCountMethodDouble
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();
            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                box.List.Add(num);
            }

            double comparator = double.Parse(Console.ReadLine());

            Console.WriteLine(box.CounterThan(comparator));
        }
    }
}
