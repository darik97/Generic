﻿using System;

namespace BinaryHeap
{
    class MinBinaryHeap<T> : BinaryHeap<T>
        where T : IComparable
    {
        public MinBinaryHeap() : base() { }

        public override void Insert(T value)
        {
            base.Insert(value);
            int i = Size - 1;
            int parent = (i - 1) / 2;
            while (i > 0 && Heap[parent].CompareTo(Heap[i]) > 0)
            {
                swapValues(parent, i);
                i = parent;
                parent = (i - 1) / 2;
            }
        }

        public override T Extract()
        {
            T minValue;
            tryExtract(out minValue);
            heapify();
            return minValue;
        }

        void heapify()
        {
            int left;
            int right;
            int min;
            int i = 0;

            for (;;)
            {
                left = 2 * i + 1;
                right = 2 * i + 2;
                min = i;

                if (left < Size && Heap[left].CompareTo(Heap[min]) < 0)
                {
                    min = left;
                }
                if (right < Size && Heap[right].CompareTo(Heap[min]) < 0)
                {
                    min = right;
                }
                if (min == i)
                {
                    break;
                }
                swapValues(min, i);
                i = min;
            }
        }

    }
}
