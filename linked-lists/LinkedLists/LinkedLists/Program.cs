using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class Program
    {
        static void Main()
        {
            LinkedList myList = new LinkedList();

            int[] numarr = { 1, 1, 3,5};
            foreach(int a in numarr)
            {
                myList.AddEnd(a);
            }

            myList.PrintAll();
            Console.ReadKey();
        }
    }
}
