using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_trees
{
    class Program
    {
        static void Main()
        {
            Tree newTree = new Tree();

            int[] AA = Enumerable.Range(0, 10).ToArray();

            foreach(int a in AA)
            {
                newTree.AddNode(newTree.root, a);
            }

            newTree.PrintTree(newTree.root);

            Console.ReadKey();
        }
    }
}
