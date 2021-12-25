using System;
using System.Collections.Generic;
using System.Text;

namespace Threeuple
{
    public class MyThreeuple<Item1, Item2, Item3>
    {
        public MyThreeuple(Item1 first, Item2 second, Item3 third)
        {
            FirstItem = first;
            SecondItem = second;
            ThirdItem = third;
        }

        public Item1 FirstItem { get; set; }
        public Item2 SecondItem { get; set; }
        public Item3 ThirdItem { get; set; }

        public override string ToString()
        {
            return $"{FirstItem} -> {SecondItem} -> {ThirdItem}";
        }
    }
}
