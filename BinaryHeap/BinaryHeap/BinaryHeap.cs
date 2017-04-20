using System;
using System.Collections.Generic;
using System.Linq;

namespace BinaryHeap
{
    class BinaryHeap<T>
        where T : IComparable
    {
        public readonly List<T> Heap;

        public int Size
        {
            get
            {
                return Heap.Count();
            }
        }

        public BinaryHeap()
        {
            Heap = new List<T>();
        }

        public virtual void Insert(T value)
        {
            Heap.Add(value);
        }

        public virtual T Extract()
        {
            T value;
            tryExtract(out value);
            return value;
        }

        protected bool tryExtract(out T value)
        {
            if (Size > 0)
            {
                value = Heap[0];
                Heap[0] = Heap[Size - 1];
                Heap.RemoveAt(Size - 1);
                return true;
            }
            else
            {
                value = default(T);
                return false;
            }
        }

        protected void swapValues(int first, int second)
        {
            T temp = Heap[second];
            Heap[second] = Heap[first];
            Heap[first] = temp;
        }
    }
}
