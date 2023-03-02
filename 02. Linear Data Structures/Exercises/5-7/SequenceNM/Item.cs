using System;
using System.Collections.Generic;

namespace SequenceNM
{
    class Item
    {
        
        public int Value { get; set; }
        private Item Previous { get; set; }

        public Item(int value, Item previous = null)
        {
            this.Value = value;
            this.Previous = previous;
        }

        public void PrintSolution()
        {
            Item item = this;
            while (item != null)
            {
                Console.Write(item.Value + " ");
                item = item.Previous;
            }
            Console.WriteLine();
        }
    }
}
