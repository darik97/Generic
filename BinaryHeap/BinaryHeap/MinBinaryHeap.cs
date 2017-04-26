using System;

namespace BinaryHeap
{
    class MinBinaryHeap<T> : BinaryHeap<T>
        where T : IComparable
    {
        public MinBinaryHeap() : base() { }

        protected override bool compare(int first, int second)
        {
            return Heap[first].CompareTo(Heap[second]) < 0;
        }
    }
}