using System;
using System.Collections.Generic;

namespace _03.MinHeap
{
    public class PriorityQueue<T> : MinHeap<T> where T : IComparable<T>
    {
        public PriorityQueue()
        {
            elements = new List<T>();
            indices = new Dictionary<T, int>();
        }

        public void Enqueue(T element) => Add(element);

        public T Dequeue() => ExtractMin();

        public void DecreaseKey(T key)
        {
            HeapifyUp(indices[key]);
        }
    }
}
