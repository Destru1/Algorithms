using System;
using System.Diagnostics;

namespace ASD_SE2_2021
{
    class Program
    {
        public static int[] myArray = { 3, 8, 2, 9, 6, 1, 5, 4, 7 };
        public static int[] sortedArray = { 1,2,3,4,5,6,7,8,9,10 };


       
    
        public static void EnterArray(int size)
        {
            myArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter an element: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void RandomArray(int size)
        {
            myArray = new int[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                myArray[i] = rand.Next(3 * size);
            }
        }

        public static void PrintArray(int[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("{0} ", myArray[i]);
            }
            Console.WriteLine();
        }

        public static void Swap(int i, int j)
        {
            int temp = 0;
            temp = myArray[j];
            myArray[j] = myArray[i];
            myArray[i] = myArray[j];
            myArray[i] = temp;
        }

        public static void SelectionSort()
        {
            int len = myArray.Length;
            for (int i = 0; i < len - 1; i++)
            {
                int min = myArray[i], pos = i;
                for (int j = i + 1; j < len; j++)
                {
                    if (myArray[j] < min)
                    {
                        min = myArray[j]; pos = j;
                    }
                }

                if (pos != i)
                {
                    int temp = myArray[pos];
                    myArray[pos] = myArray[i];
                    myArray[i] = temp;
                }
            }
        }

        public static void BubbleSort()
        {
            int len = myArray.Length;
            for (int i = 0; i < len - 1; i++)
            {
                for (int j = 0; j < len - i - 1; j++)
                {
                    if (myArray[j] > myArray[j + 1])
                    {
                        Swap(j + 1, j);
                    }
                }
            }
        }

        public static void InsertionSort()
        {
            int len = myArray.Length;
            for (int i = 1; i < len; i++)
            {
                int x = myArray[i];
                int pos = i;
                while (pos > 0 && myArray[pos - 1] > x)
                {
                    myArray[pos] = myArray[pos - 1];
                    pos--;
                }
                myArray[pos] = x;
            }
        }

        public static bool FindElement(int num)
        {
            for (int i = 0; i < myArray.Length; i++)
            {

                if (myArray[i] == num)
                {
                    Console.WriteLine("Correct number");
                    return true;

                  
                }

              
         }
            Console.WriteLine("Incorrect number");
            return false;
        }

        
        static void Main(string[] args)
        {            
            const int N = 50;
            EnterArray(N);
            //RandomArray(N);
            PrintArray(myArray);
            Stopwatch stw = new Stopwatch();
            stw.Start();
            //SelectionSort();
            BubbleSort();
            //InsertionSort();
            stw.Stop();
            
            Console.WriteLine("Time: {0}", stw.ElapsedMilliseconds);
            PrintArray(myArray);
            FindElement(2);
           

            












        }
    }
}
