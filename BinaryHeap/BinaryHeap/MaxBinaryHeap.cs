using System;

namespace BinaryHeap
{
    class MaxBinaryHeap<T> : BinaryHeap<T>
        where T : IComparable
    {
        public MaxBinaryHeap() : base() { }

        protected override bool compare(int first, int second)
        {
            return Heap[first].CompareTo(Heap[second]) > 0;
        }
    }
}