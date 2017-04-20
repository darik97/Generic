using System;
using System.Collections.Generic;
using System.Linq;

namespace BinaryHeap
{
    class MaxBinaryHeap<T>
        where T : IComparable
    {
        public readonly List<T> heap;
        public int Size
        {
            get
            {
                return heap.Count();
            }
        }

        public MaxBinaryHeap()
        {
            heap = new List<T>();
        }

        public void Insert(T value)
        {
            heap.Add(value);
            int i = Size - 1;
            int parent = (i - 1) / 2;
            while (i > 0 && heap[parent].CompareTo(heap[i]) < 0)
            {
                T temp = heap[i];
                heap[i] = heap[parent];
                heap[parent] = temp;
                i = parent;
                parent = (i - 1) / 2;
            }
        }

        public T Extract()
        {
            if (Size > 0)
            {
                T value = heap[0];
                heap[0] = heap[Size - 1];
                heap.RemoveAt(Size - 1);
                heapify();
                return value;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        
        void heapify()
        {
            int left;
            int right;
            int max;
            int i = 0;
            
            for (; ; )
            {
                left = 2 * i + 1;
                right = 2 * i + 2;
                max = i;

                if (left < Size && heap[left].CompareTo(heap[max]) > 0)
                {
                    max = left;
                }
                if (right < Size && heap[right].CompareTo(max) > 0)
                {
                    max = right;
                }
                if (max == i)
                {
                    break;
                }

                T temp = heap[i];
                heap[i] = heap[max];
                heap[max] = temp;
                i = max;
            } 
        }        
    }
}
