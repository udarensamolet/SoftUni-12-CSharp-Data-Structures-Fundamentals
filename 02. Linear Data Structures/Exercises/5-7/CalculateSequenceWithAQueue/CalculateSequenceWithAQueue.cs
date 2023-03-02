using System;
using System.Collections.Generic;

namespace CalculateSequenceWithAQueue
{
    class CalculateSequenceWithAQueue
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int> queue = new Queue<int>();
            Queue<int> currents = new Queue<int>();
            queue.Enqueue(n);
            int counter = 1;
            while (counter < 50)
            {

                while (queue.Count > 0)
                {
                    currents.Enqueue(queue.Peek());
                    Console.WriteLine(queue.Dequeue());
                }

                int current = currents.Dequeue();
                queue.Enqueue(current + 1);
                queue.Enqueue(1 + current * 2);
                queue.Enqueue(current + 2);
                counter += 3;
            }
        }
    }
}
