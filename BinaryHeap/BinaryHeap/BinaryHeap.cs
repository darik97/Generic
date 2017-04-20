using System;
using System.Collections.Generic;
using System.Linq;

namespace BinaryHeap
{
    class BinaryHeap<T>
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

        public virtual void Insert(T value)
        {
            Heap.Add(value);
        }

        //public virtual T Extract()
        //{
        //    if (Size > 0)
        //    {
        //        T value = Heap[0];
        //        Heap[0] = Heap[Size - 1];
        //        Heap.RemoveAt(Size - 1);
        //        return value;
        //    }
        //    else
        //    {
        //        throw new IndexOutOfRangeException();
        //    }
        //}
    }
}
