using System;
using System.Collections.Generic;
using System.Text;

namespace Threeuple
{
    public class Threeuple<Item1, Item2, Item3>
    {
        public Threeuple(Item1 item1, Item2 item2, Item3 item3)
        {
            ItemLeft = item1;
            ItemMiddle = item2;
            ItemRight = item3;
        }
        public Item1 ItemLeft { get; set; }
        public Item2 ItemMiddle { get; set; }
        public Item3 ItemRight { get; set; }

    }
}