using System;
using System.Collections;

namespace AlgorithmsExam
{
    class Program
    {
        private static Tree tree = new Tree();
        private static Node node = new Node();
        private static Queue queue = new Queue();

        private const int MIN_VALUE = 1;
        private const int MAX_VALUE = 99;
        static void Main(string[] args)
        {

            var tree = new Tree();
            FillTree();
            Console.WriteLine($"Root: {node.value}");
            Console.Write("LNR tree : ");
          
            tree.Traverse(node);
            tree.SumLeftSubTree(node.left);
            Console.WriteLine();
            Console.WriteLine($"Sum = {tree.sum} ");
            
            tree.GetNumbersSmallerThan(node.right, tree.sum);
          
            Console.Write("Elements In queue: ");
           
            foreach (var item in queue)
            {
                Console.Write(item + " ");
            }
            

        }


        public static void FillTree()
        {
            Random random = new Random();
            int number = random.Next(MIN_VALUE, MAX_VALUE);
            node.value = number;

            for (int i = 1; i <= 19; i++)
            {
                
                    number = random.Next(MIN_VALUE, MAX_VALUE);

                    tree.Add(ref node, number);
             

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


            

            public int sum = 0;
            public void SumLeftSubTree(Node node)
            {
                if (node.left != null)
                {
                    SumLeftSubTree(node.left);
                }
                    this.sum += node.value;
                if (node.right != null)
                {
                    SumLeftSubTree(node.right);
                }
            }


            public void GetNumbersSmallerThan(Node root, double value)
            {
                if (root.left != null)
                {
                    GetNumbersSmallerThan(root.left, value);
                }

                if (root.value < value)
                {
                    queue.Enqueue(root.value);
                }

                if (root.right != null)
                {
                    GetNumbersSmallerThan(root.right, value);
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
