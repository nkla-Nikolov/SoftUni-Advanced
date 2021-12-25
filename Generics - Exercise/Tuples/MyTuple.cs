using System;
using System.Collections.Generic;
using System.Text;

namespace Tuples
{
    public class MyTuple<Item1, Item2>
    {
        public MyTuple(Item1 left, Item2 right)
        {
            FirstItem = left;
            SecondItem = right;
        }
        public Item1 FirstItem { get; set; }
        public Item2 SecondItem { get; set; }


        public string GetItems()
        {
            return $"{FirstItem} -> {SecondItem}";
        }
    }
}
