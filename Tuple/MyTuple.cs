using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class MyTuple<Item1, Item2>
    {
        public MyTuple(Item1 item1, Item2 item2)
        {
            ItemLeft = item1;
            ItemRight = item2;
        }
        public Item1 ItemLeft { get; set; }
        public Item2 ItemRight { get; set; }

    }
}
