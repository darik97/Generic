using System;

namespace BinaryHeap
{
    class MaxBinaryHeap<T> : BinaryHeap<T>
        where T : IComparable
    {
        public MaxBinaryHeap() : base() { }

        public override bool Compare(int first, int second)
        {
            return Heap[first].CompareTo(Heap[second]) > 0;
        }
    }
}