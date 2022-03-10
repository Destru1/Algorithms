using System;

namespace BinarySearch
{
    class Program
    {
       
        static void Main(string[] args)
        {
            

            int[] sortedArray = { 1,3,4,6,7,8,13,21,31,44,52,61,77};
            Console.Write("Enter a number: ");

            int searchNumber = int.Parse(Console.ReadLine());
           
            var input = BinarySearch(sortedArray, searchNumber);
            
            Console.WriteLine($"Number {searchNumber} is found at {input} element");


        }

        public static int BinarySearch(int[] array, int key)
        {
            int min = 0;
            int max = array.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;

                if (array[mid] == key)
                {
                    return mid;
                }

                else if (array[mid] > key)
                {
                    max = mid;
                }

                else
                {
                    min = mid++;
                }
            }
         
            return -1;
        }
    }

}