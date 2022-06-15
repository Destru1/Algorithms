using System;

namespace Task_2
{
    class Program
    {
        private const int N = 30;

        private static Node node = new Node();
        private static Tree tree = new Tree();
        static void Main(string[] args)
        {
            var tree = new Tree();
            Random random = new Random();

            int[] array = new int[N];
            Console.WriteLine("Initial array");
            for (int i = 0; i < N; i++)
            {
                int number = random.Next(1, 100);
                array[i] = number;
                Console.Write(array[i] + " ");
            }

            node.value = array[0];
            int value = 0;
            for (int i = 1; i < N; i++)
            {
                value = array[i];
                tree.Add(ref node, value);

            }
            Console.WriteLine();
            Console.WriteLine("Sorted array with LNR traverse");


            tree.Traverse(node);


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
