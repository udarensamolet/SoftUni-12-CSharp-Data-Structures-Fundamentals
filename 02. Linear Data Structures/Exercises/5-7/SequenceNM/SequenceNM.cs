using System;
using System.Linq;
using System.Collections.Generic;


namespace SequenceNM
{
    class SequenceNM
    {
        static void Main()
        {
            int[] tokens = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int n = tokens[0];
            int m = tokens[1];

            Queue<Item> que = new Queue<Item>();
            que.Enqueue(new Item(n, null));
            while (que.Count > 0)
            {
                Item e = que.Dequeue();
                if (e.Value < m)
                {
                    que.Enqueue(new Item(e.Value + 1, e));
                    que.Enqueue(new Item(e.Value + 2, e));
                    que.Enqueue(new Item(e.Value * 2, e));
                }
                if (e.Value == m)
                {
                    e.PrintSolution();
                    return;
                }
            }
        }
    }
}
