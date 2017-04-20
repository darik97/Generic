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
                T temp = Heap[i];
                Heap[i] = Heap[parent];
                Heap[parent] = temp;
                i = parent;
                parent = (i - 1) / 2;
            }
        }

        public T Extract()
        {
            T maxValue;
            TryExtract(out maxValue);
            heapify();
            return maxValue;

            //if (Size > 0)
            //{
            //    T value = Heap[0];
            //    Heap[0] = Heap[Size - 1];
            //    Heap.RemoveAt(Size - 1);
            //    heapify();
            //    return value;
            //}
            //else
            //{
            //    throw new IndexOutOfRangeException();
            //}
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

                T temp = Heap[i];
                Heap[i] = Heap[max];
                Heap[max] = temp;
                i = max;
            }
        }
    }
}
