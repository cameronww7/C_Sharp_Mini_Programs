/***********************************************************************
 *              Cameron Walters
 *                      C# Exploring C#
 ***********************************************************************/

using System;

namespace Singly_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singly Linked_List!");
            SinglyLinkedList myList = new SinglyLinkedList();

            myList.insertFirst(100);
            myList.insertFirst(99);
            myList.insertFirst(98);
            myList.insertFirst(97);
            myList.insertFirst(96);
            myList.insertLast(101);
            myList.displayList();

            myList.deleteFirst();
            myList.displayList();

            myList.displayList();
            myList.displayList();

        }
    }

    public class SinglyLinkedList
    {
        private Node first;
        public bool isEmpty()
        {
            return (first == null);
        }

        public void insertFirst(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = first;
            first = newNode;
        }

        public Node deleteFirst()
        {
            Node temp = first;
            first = first.next;
            return temp;
        }

        public void displayList () {
            Console.WriteLine("List (First -- Last) ");
            Node current = first;
            while (current != null) {
                current.displayNode();
                current = current.next;
            }
            Console.WriteLine();
        }

        public void insertLast(int data) {
            Node current = first;
            while ( current.next != null) {
                current = current.next;
            }

            Node newNode = new Node();
            newNode.data = data;
            current.next = newNode;
        }

    }

    public class Node
    {
        public int data;
        public Node next;

        public void displayNode()
        {
            Console.WriteLine(" < " + data + " > ");
        }
    }
}
