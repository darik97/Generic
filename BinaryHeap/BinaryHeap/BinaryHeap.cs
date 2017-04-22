using System;
using System.Collections.Generic;
using System.Linq;

namespace BinaryHeap
{
    abstract class BinaryHeap<T>
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

        public void Insert(T value)
        {
            Heap.Add(value);
            int i = Size - 1;
            int parent = (i - 1) / 2;
            while (i > 0 && Compare(i, parent))
            {
                swapValues(parent, i);
                i = parent;
                parent = (i - 1) / 2;
            }
        }

        public bool TryExtract(out T value)
        {
            if (Size > 0)
            {
                value = extract();
                /*
                value = Heap[0];
                Heap[0] = Heap[Size - 1];
                Heap.RemoveAt(Size - 1);
                Heapify();
                 */
                return true;
            }
            else
            {
                value = default(T);
                return false;
            }
        }

        private T extract()
        {
            T value = Heap[0];
            Heap[0] = Heap[Size - 1];
            Heap.RemoveAt(Size - 1);
            Heapify();
            return value;
        }

        public void Heapify()
        {
            int left;
            int right;
            int max;
            int i = 0;

            for (;;)
            {
                left = 2 * i + 1;
                right = 2 * i + 2;
                max = i;

                if (left < Size && Compare(left, max))
                {
                    max = left;
                }
                if (right < Size && Compare(right, max))
                {
                    max = right;
                }
                if (max == i)
                {
                    break;
                }
                swapValues(max, i);
                i = max;
            }
        }

        public virtual bool Compare(int first, int second)
        {
            return false;
        }

        protected void swapValues(int first, int second)
        {
            T temp = Heap[second];
            Heap[second] = Heap[first];
            Heap[first] = temp;
        }
    }
}
