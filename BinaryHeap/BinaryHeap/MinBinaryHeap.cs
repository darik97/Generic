using System;

namespace BinaryHeap
{
    class MinBinaryHeap<T> : BinaryHeap<T>
        where T : IComparable
    {
        public MinBinaryHeap() : base() { }

        public override bool Compare(int first, int second)
        {
            return Heap[first].CompareTo(Heap[second]) < 0;
        }
    }
}