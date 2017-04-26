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
                Console.WriteLine(minHeap.Extract());
            }
            int minValue;
            if (minHeap.TryExtract(out minValue))
            {
                Console.WriteLine(minValue + "\n");
            }
            else
            {
                Console.WriteLine("Куча пуста \n");
            }

            MaxBinaryHeap<string> sHeap = new MaxBinaryHeap<string>();
            sHeap.Insert("yellow");
            sHeap.Insert("red");
            sHeap.Insert("orange");
            sHeap.Insert("green");
            sHeap.Insert("blue");
            sHeap.Insert("indigo");
            sHeap.Insert("violet");
            for (int i = 0; i < sHeap.Size; i++)
            {
                Console.Write(sHeap.Heap[i] + " ");
            }
            Console.WriteLine();
            while (sHeap.Size > 0)
            {
                Console.WriteLine(sHeap.Extract());
            }
            string maxValue;
            if (sHeap.TryExtract(out maxValue))
            {
                Console.WriteLine(maxValue + "\n");
            }
            else
            {
                Console.WriteLine("Куча пуста \n");
            }
        }
    }
}
