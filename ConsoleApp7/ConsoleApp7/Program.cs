using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 51, 7, 3, 1, 77, 61, 32, 14, 21, 11 };

            Console.WriteLine("Initial array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            int current;
            int min;

            Console.WriteLine();

            for (int i = 0; i < array.Length - 1; i++)
            {
                min = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                current = array[min];
                array[min] = array[i];
                array[i] = current;
            }
            Console.WriteLine();
            Console.Write("Sorted array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
