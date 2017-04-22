using System;

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
            while (maxHeap.Size > 0)
            {
                int temp;
                maxHeap.TryExtract(out temp);
                Console.WriteLine(temp);
            }
            Console.WriteLine();
            MinBinaryHeap<int> minHeap = new MinBinaryHeap<int>();
            minHeap.Insert(0);
            minHeap.Insert(1);
            minHeap.Insert(22);
            minHeap.Insert(13);
            minHeap.Insert(10);
            minHeap.Insert(31);
            minHeap.Insert(15);
            minHeap.Insert(3);
            while (minHeap.Size > 0)
            {
                int temp;
                minHeap.TryExtract(out temp);
                Console.WriteLine(temp);
            }
        }
    }
}
