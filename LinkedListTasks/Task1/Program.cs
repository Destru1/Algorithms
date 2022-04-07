using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {

        private const int N = 10;

        private static LinkedList<int> list = new LinkedList<int>();
        private static LinkedListNode<int> lastNode;

        public static void Main(string[] args)
        {

            for (int i = 0; i < N; i++)
            {
                Console.Write("Enter an element: ");
                int value = int.Parse(Console.ReadLine());
                list.AddLast(value);
            }
            foreach (int number in list)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            Console.Write("Enter value of x ");
            int x = int.Parse(Console.ReadLine());


            if (x > 0)
            {
                var node = list.First;
                while (node != null)
                {
                    var nextNode = node.Next;



                    if (node.Value > x)
                    {
                        list.Remove(node);

                    }
                    else if (node.Value == x)
                    {
                        lastNode = node;
                    }

                    node = nextNode;

                }
                if (lastNode != null)
                {
                    list.AddAfter(lastNode, 10);
                }


            }

            foreach (int number in list)
            {
                Console.Write(number + " ");
            }
        }
    }
}

