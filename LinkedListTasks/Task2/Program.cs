using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        private const int N = 30;
        private const int MAX_VALUE = 99;
        private const int MIN_VALUE = 1;

        private static LinkedList<int> list = new LinkedList<int>();
        static void Main(string[] args)
        {
            Random random = new Random();

            for (int i = 0; i < N; i++)
            {
                int value = random.Next(MIN_VALUE, MAX_VALUE);
                list.AddLast(value);
            }

            foreach (int number in list)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            Console.Write("Enter value of x: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter value of y: ");
            int y = int.Parse(Console.ReadLine());

            while (x > y)
            {
                Console.WriteLine("X can't be bigger than y");
                Console.Write("Enter value of x: ");
                x = int.Parse(Console.ReadLine());
            }

            var node = list.First;

            while (node != null)
            {
                var nextNode = node.Next;
                if (node.Value > x && node.Value < y)
                {
                    list.Remove(node);
                }
                node = nextNode;
            }




            Console.WriteLine($"List without numbers between {x} and {y} :");
            foreach (var number in list)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.WriteLine("==============================================");

            int[] array = new int[list.Count];
            list.CopyTo(array, 0);

            Console.WriteLine($"Array with numbers devidable by {x} or {y} ");
            for (int i = 0; i < array.Length; i++)
            {
                int number = array[i];
                bool isDevidable = number % x == 0 || number % y == 0;
                if (isDevidable)
                {
                    Console.Write(array[i] + " ");
                }
            }

        }
    }
}
