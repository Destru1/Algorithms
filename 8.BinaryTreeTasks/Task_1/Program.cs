using System;
using System.Collections;

namespace Task_1
{
    public class Program
    {
        private const int MIN_VALUE = 10;
        private const int MAX_VALUE = 99;

        private const string VALUE_FOR_X = "Enter value for x: ";
        private const string VALUE_FOR_Y = "Enter value for y: ";
        

        private static Tree tree = new Tree();
        private static Node node = new Node();
        private static Stack stack = new Stack();

        static void Main(string[] args)
        {
            var tree = new Tree();
            FillTree();

            Console.WriteLine("Tree LNR");
            tree.Traverse(node);
            Console.WriteLine();

            int x, y;
            EnterValues(out x, out y);

            tree.GetNumbersBetween(node, x, y);

            PrintStack();
        }

        private static void PrintStack()
        {
            Console.Write("Numbers in stack: ");
            foreach (var number in stack)
            {
                Console.Write(number.ToString() + " ");
            }
        }

        private static void EnterValues(out int x, out int y)
        {
           

            Console.Write(VALUE_FOR_X);
            x = int.Parse(Console.ReadLine());
            Console.Write(VALUE_FOR_Y);
            y = int.Parse(Console.ReadLine());
            while (x < 10 || y < 10)
            {
                Console.WriteLine("Both numbers must be two digit.");
                Console.Write(VALUE_FOR_X);
                x = int.Parse(Console.ReadLine());
                Console.Write(VALUE_FOR_Y);
                y = int.Parse(Console.ReadLine());
            }
            while (y <= x)
            {
                Console.WriteLine("X must be smaller than y.");
                Console.Write(VALUE_FOR_X);
                x = int.Parse(Console.ReadLine());
            }
        }

        public static void FillTree()
        {
            Random random = new Random();
            int number = random.Next(MIN_VALUE, MAX_VALUE);
            node.value = number;

            for (int i = 1; i <= 19; i++)
            {
                try
                {
                    number = random.Next(MIN_VALUE, MAX_VALUE);

                    tree.Add(ref node, number);
                }
                catch (Exception e)
                {

                    i--;
                }

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

                if (Search(root, number))
                {

                    throw new Exception();
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

            public bool Search(Node root, int key)
            {
                if (root == null)
                {
                    return false;
                }

                if (root.value == key)
                {
                    return true;
                }

                if (root.value > key)
                {
                    return Search(root.left, key);
                }
                else
                {
                    return Search(root.right, key);
                }
            }

            public void GetNumbersBetween(Node node, int x, int y)
            {
                if (node.left != null)
                {
                    GetNumbersBetween(node.left, x, y);
                }
                if (node.value >= x && node.value <= y)
                {
                    stack.Push(node.value);
                }

                if (node.right != null)
                {
                    GetNumbersBetween(node.right, x, y);
                }
            }

            public void Traverse(Node node)
            {
                if (node.left != null)
                {
                    Traverse(node.left);
                }
                Console.Write(node.value + " ");

                if (node.right != null)
                {
                    Traverse(node.right);
                }
            }
        }

    }
}
