using System;
using System.Collections.Generic;

namespace Task_3
{
    class Program
    {
        public static Node node = new Node();
        public static Tree tree = new Tree();
        public static LinkedList<int> primeNumbers = new LinkedList<int>();
        static void Main(string[] args)
        {
            var tree = new Tree();

            FindPrimeNumbers(primeNumbers);
            Console.WriteLine("Prime numbers:");
            Console.WriteLine(String.Join(" ", primeNumbers));
            Console.WriteLine("Tree");
            FillTree();
            tree.Traverse(node);

        }

        private static void FindPrimeNumbers(LinkedList<int> primeNumbers)
        {
            for (int i = 2; i < 1000; i++)
            {
                int count = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                    if (count == 2) break;

                }
                if (count != 2)
                    if (i > 100)
                        primeNumbers.AddLast(i);

            }
        }

        public static void FillTree()
        {
            var firstNode = primeNumbers.First;
            int number;
            

            while (firstNode != null)
            {


                var nextNode = firstNode.Next;
                if (firstNode.Value % 10 == 7)
                {

                    number = firstNode.Value;
                    tree.Add(ref node, number);
                }
                firstNode = nextNode;
            }

        }
        public class Node
        {
            public int value;
            public Node left;
            public Node right;
        }

        public class Tree
        {

            public void Add(ref Node root, int number)
            {
                if (root == null)
                {
                    root = new Node();
                    root.value = number;

                    return;
                }


                if (number < root.value)
                {
                    Add(ref root.left, number);
                }
                else
                {
                    Add(ref root.right, number);
                }
            }


            public void Traverse(Node node)
            {
                Console.Write(node.value + " ");

                if (node.left != null)
                {
                    Traverse(node.left);
                }

                if (node.right != null)
                {
                    Traverse(node.right);
                }

            }
        }
    }
}
