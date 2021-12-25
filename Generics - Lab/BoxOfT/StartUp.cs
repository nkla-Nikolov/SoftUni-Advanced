using System;
using System.Reflection;

namespace BoxOfT
{
   public class Program
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            box.Add(1);
            box.Add(2);
            
        }
    }
}
