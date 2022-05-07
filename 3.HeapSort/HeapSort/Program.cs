using System;

namespace HeapSort
{
    class Program
    {
        static void Sort(int[] array)
        {
            int length = array.Length;

            for (int i = length / 2 - 1; i >=0; i--)
            {
                Heapify(array, length, i);
            }
            for (int i = length -1; i >= 0; i--)
            {
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;
                Heapify(array, i, 0);
            }
        }

        static void Heapify(int[] array, int length, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < length && array[left] > array[largest])
            {
                largest = left;
            }

            if (right < length && array[right] > array[largest])
            {
                largest = right;
            }
            if (largest != i)
            {
                int swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;
                Heapify(array, length, largest);
            }
        }
        static void Main()
        {
         int[] array = { 74, 19, 24, 5, 8, 79, 42, 15, 20, 53, 11 };

            Console.WriteLine("Initial array");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Sort(array);
            Console.WriteLine("\nHeap sort");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
          

        }
    }
}
