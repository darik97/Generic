using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHeap
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxBinaryHeap<int> maxHeap = new MaxBinaryHeap<int>();
            maxHeap.Insert(0);
            maxHeap.Insert(1);
            maxHeap.Insert(22);
            maxHeap.Insert(13);
            maxHeap.Insert(10);
            maxHeap.Insert(31);
            maxHeap.Insert(15);
            maxHeap.Insert(3);
            for (int i = 0; i < maxHeap.heap.Count; i++)
            {
                Console.WriteLine(maxHeap.heap[i]);
            }
        }
    }
}
