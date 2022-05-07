using System;
using System.Collections;
using System.Collections.Generic;

namespace StackToQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();


            int value = int.Parse(Console.ReadLine());
         

            while (value > 0)
            {
               
                stack.Push(value);
                value = int.Parse(Console.ReadLine());
                
            }

            Console.Write("Elements in stack: ");
            foreach (var numb in stack)
            {
                Console.Write(numb + " ");
            }
           

            int[] arr = stack.ToArray();
         

            Queue queue = new Queue();
            for (int i = 0; i < arr.Length; i++)
            {
                int number = arr[i];
                if (number %2 == 0)
                {

                    queue.Enqueue(number);
                }
            }
            Console.WriteLine();
            Console.Write("Queue with even numbers:");
            foreach (var element in queue)
            {
                Console.Write(element + " ");
            }

        }
    }
}
