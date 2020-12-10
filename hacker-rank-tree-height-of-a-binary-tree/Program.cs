﻿using System;

namespace hacker_rank_tree_height_of_a_binary_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int element = int.Parse(Console.ReadLine());
            Node root = null;
            while (element-- > 0)
            {
                int data = int.Parse(Console.ReadLine());
                root = Insert(root, data);
            }
            int height = Height(root);
            Console.ReadKey();
        }

        private static Node Insert(Node root, int data)
        {
            if (root is null)
            {
                return new Node(data);
            }
            else
            {
                Node currentNode;
                if (data <= root.Data)
                {
                    currentNode = Insert(root.Left, data);
                    root.SetLeftNode(currentNode);
                }
                else
                {
                    currentNode = Insert(root.Right, data);
                    root.SetRightNode(currentNode);
                }
                return root;
            }

        }

        private static int Height(Node node)
        {
            if (node is null || node.Left is null && node.Right is null)
            {
                return 0;
            }
            else
            {
                return (Math.Max(Height(node.Left), Height(node.Right)) + 1);
            }
        }
    }
}
