using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 55, 2, 5, 1, 73, 21, 77, 11, 3 };

            int current;

            Console.WriteLine("Initial array");

            foreach (int index in array)
                Console.Write(index + " ");
            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int k = 0; k <= array.Length - 2; k++)
                {
                    if (array[k] > array[k+1])
                    {
                        current = array[k + 1];
                        array[k + 1] = array[k];
                        array[k] = current;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Sorted array:");
            foreach (int sorted in array)
                Console.Write(sorted + " ");
                Console.Write("\n ");

            }
        }
    }

