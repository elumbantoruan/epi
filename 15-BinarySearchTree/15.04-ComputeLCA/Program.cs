﻿using System;
using System.Diagnostics;
using _15._00_Tree;

namespace _15._04_ComputeLCA
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree = new Tree<int>(19);
            tree.Insert(7);
            tree.Insert(3);
            tree.Insert(2);
            tree.Insert(5);
            tree.Insert(11);
            tree.Insert(17);
            tree.Insert(13);

            tree.Insert(43);
            tree.Insert(23);
            tree.Insert(37);
            tree.Insert(29);
            tree.Insert(41);
            tree.Insert(31);
            tree.Insert(47);
            tree.Insert(53);

            int a = 3;
            int b = 17;
            Tree<int> lcaNode = FindLCA<int>(tree, a,b);
            Debug.Assert(lcaNode.Value == 7);
            Console.WriteLine(lcaNode.Value);

            a = 13;
            b = 53;
            lcaNode = FindLCA<int>(tree, a,b);
            Debug.Assert(lcaNode.Value == 19);            
            Console.WriteLine(lcaNode.Value);
        }

        // The time complexity is O(h) where h is the height of tree
        static Tree<T> FindLCA<T>(Tree<T> root, int node1, int node2) where T : IComparable<T> {
            Tree<T> current = root;
            while (Convert.ToInt32(current.Value) < node1 || Convert.ToInt32(current.Value) > node2) {
                while (Convert.ToInt32(current.Value) < node1 ) {
                    current = current.Right;
                }
                while (Convert.ToInt32(current.Value) > node2 ) {
                    current = current.Left;
                }
            }
            return current;
        }
    }
}
