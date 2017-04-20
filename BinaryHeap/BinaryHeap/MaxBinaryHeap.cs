using System;

namespace BinaryHeap
{
    class MaxBinaryHeap<T> : BinaryHeap<T>
        where T : IComparable
    {
        public MaxBinaryHeap() : base() { }

        public override void Insert(T value)
        {
            base.Insert(value);
            int i = Size - 1;
            int parent = (i - 1) / 2;
            while (i > 0 && Heap[parent].CompareTo(Heap[i]) < 0)
            {
                swapValues(parent, i);
                i = parent;
                parent = (i - 1) / 2;
            }
        }

        public override T Extract()
        {
            T maxValue;
            tryExtract(out maxValue);
            heapify();
            return maxValue;
        }
        
        void heapify()
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

                if (left < Size && Heap[left].CompareTo(Heap[max]) > 0)
                {
                    max = left;
                }
                if (right < Size && Heap[right].CompareTo(Heap[max]) > 0)
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
    }
}
