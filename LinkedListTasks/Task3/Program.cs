using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Program
    {
        private static LinkedList<int> listA = new LinkedList<int>();
        private static LinkedList<int> listB = new LinkedList<int>();
        private static LinkedList<int> listC = new LinkedList<int>();
        public static void Main(string[] args)
        {
            Console.Write("Enter element for list A: ");
            int valueForA = int.Parse(Console.ReadLine());

            while (valueForA > 0)
            {

                listA.AddLast(valueForA);
                Console.Write("Enter element for list A: ");
                valueForA = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter element for list B: ");
            int valueForB = int.Parse(Console.ReadLine());

            while (valueForB > 0)
            {
                listB.AddLast(valueForB);
                Console.Write("Enter element for list B: ");
                valueForB = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("List A");
            PrintList(listA);

            Console.WriteLine("==============================");

            Console.WriteLine("List B");
            PrintList(listB);

            var nodeA = listA.First;

            while (nodeA != null)
            {
                var nextNodeA = nodeA.Next;
                bool isInList = listC.Contains(nodeA.Value);

                if (!isInList)
                {
                    listC.AddLast(nodeA.Value);
                }

                nodeA = nextNodeA;
            }

            var nodeB = listB.First;

            while (nodeB != null)
            {
                var nextNodeB = nodeB.Next;
                bool isInList = listC.Contains(nodeB.Value);

                if (!isInList)
                {
                    listC.AddLast(nodeB.Value);
                }

                nodeB = nextNodeB;
            }

            Console.WriteLine("==============================");

            Console.WriteLine("List C");
            var sortList = listC.OrderBy(x => x);

            foreach (int number in sortList)
            {
                Console.Write(number + " ");
            }

        }

        private static void PrintList(LinkedList<int> list)
        {
            foreach (int number in list)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }


    }
}
