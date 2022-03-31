using System;
using System.Collections.Generic;

namespace Task_2
{
    class Program
    {

        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            Random random = new Random();

            for (int i = 0; i < 30; i++)
            {
                int value = random.Next(1, 99);
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

            if (x < y)
            {
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
    

