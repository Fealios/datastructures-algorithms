using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class LinkedList
    {
        public Node head;

        public LinkedList()
        {
            this.head = null;
        }

        public void AddFront(int a)
        {
            Node newNode = new Node(a);
            newNode.next = this.head;
            this.head = newNode;
        }

        public void AddEnd(int a)
        {
            Node newNode = new Node(a);
            if (this.head == null)
            {
                this.head = newNode;
            } else
            {
                Node current = this.head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
            }
        }

        public void FindByValue(int a)
        {
            Node current = this.head;
            if (current.data == a)
            {
                Console.WriteLine($"Value {a} has been found");
            } else
            {
                while (current.next != null)
                {
                    if(current.next.data == a)
                    {
                        Console.WriteLine($"Value {a} has been found");
                        return;
                    } else
                    {
                        current = current.next;
                    }
                }
                Console.WriteLine($"Value {a} has not been found");
            }
        }

        public void PrintAll()
        {
            Node current = this.head;
            while(current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
    }

    class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
