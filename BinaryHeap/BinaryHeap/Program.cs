using System;

namespace BinaryHeap
{
    class Program
    {
        static void Main(string[] args)
        {
            MinBinaryHeap<int> minHeap = new MinBinaryHeap<int>();
            minHeap.Insert(0);
            minHeap.Insert(1);
            minHeap.Insert(22);
            minHeap.Insert(13);
            minHeap.Insert(10);
            minHeap.Insert(31);
            minHeap.Insert(15);
            minHeap.Insert(3);
            for (int i = 0; i < minHeap.Size; i++)
            {
                Console.Write(minHeap.Heap[i] + " ");
            }
            Console.WriteLine();
            while (minHeap.Size > 0)
            {
                int value;
                if (minHeap.TryExtract(out value))
                {
                    Console.WriteLine(value);
                }
                else
                {
                    Console.WriteLine("Куча пуста");
                }
            }
            Console.WriteLine();
            MaxBinaryHeap<string> sHeap = new MaxBinaryHeap<string>();
            sHeap.Insert("yellow");
            sHeap.Insert("red");
            sHeap.Insert("orange");
            sHeap.Insert("green");
            sHeap.Insert("blue");
            sHeap.Insert("indigo");
            sHeap.Insert("violet");
            while (sHeap.Size > 0)
            {
                string value;
                if (sHeap.TryExtract(out value))
                {
                    Console.WriteLine(value);
                }
                else
                {
                    Console.WriteLine("Куча пуста");
                }
            }
        }
    }
}
