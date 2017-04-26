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
            while (i > 0 && compare(i, parent))
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
                value = Extract();
                return true;
            }
            else
            {
                value = default(T);
                return false;
            }
        }

        public T Extract()
        {
            T value = Heap[0];
            Heap[0] = Heap[Size - 1];
            Heap.RemoveAt(Size - 1);
            heapify();
            return value;
        }

        void heapify()
        {
            int left;
            int right;
            int root;
            int i = 0;

            for (;;)
            {
                left = 2 * i + 1;
                right = 2 * i + 2;
                root = i;

                if (left < Size && compare(left, root))
                {
                    root = left;
                }
                if (right < Size && compare(right, root))
                {
                    root = right;
                }
                if (root == i)
                {
                    break;
                }
                swapValues(root, i);
                i = root;
            }
        }

        protected abstract bool compare(int first, int second);

        void swapValues(int first, int second)
        {
            T temp = Heap[second];
            Heap[second] = Heap[first];
            Heap[first] = temp;
        }
    }
}