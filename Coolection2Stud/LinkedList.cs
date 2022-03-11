using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coolection2Stud
{
    class Node
    {

        public int value;
        public Node next;
        public Node previous;

        public Node(int v, Node node)
        {
            value = v;
            next = node;
        }
        public Node(int v)
        {
            value = v;
            next = null;
            previous = null;
        }


    }


    class LinkedList
    {

        public Node head = null;
        public Node tail = null;
        public Node cur = null;

        public LinkedList()
        {
        }

        public void Add(int value)
        {
            if (head == null)
            {
                AddFirst(value);
            }
            else
            {
                AddLast(value);
                
            }

            
        }

        public void AddFirst(int value)
        {
            try
            { 
                if (head == null)
                {
                    head = new Node(value);
                    cur = head;
                    tail = head;
                }
                else
                {
                    InsertBefore(head.value, value);
                }
            }
            catch (ArgumentException ex)
            { Console.WriteLine(ex.Message); }

        }

        public void AddLast(int value)
        {
            try
            {
                 Node newTail = new Node(value);
                newTail.previous = cur;
                cur.next = newTail;
                cur = cur.next;
                tail = cur;
            }
            catch (ArgumentException ex)
            { Console.WriteLine(ex.Message);}
        }


        public void InsertAfter(int prevValue, int value)
        {
            try
            { 
                Node prevNode = head;

                while(prevNode != null)
                {
                    if(prevNode.value == prevValue)
                    {
                        break;
                    }
                    prevNode = prevNode.next;

                }

                Node nextNode = prevNode.next;
            
                prevNode.next = new Node(value,nextNode);
                nextNode.previous = prevNode;
            }
            catch (ArgumentException ex)
            { Console.WriteLine(ex.Message); }

        }

        public void InsertBefore(int nodeValue, int value)
        {
            try 
            { 

                if(nodeValue==head.value)
                {
                    Node newHead = new Node(value);
                    newHead.previous = null;
                    newHead.next = head;
                    head = newHead;
                }

                else
                {
                    Node node = head;
                    while (node != null)
                    {
                        if (node.value == nodeValue)
                        {
                            break;
                        }
                        node = node.next;

                    }
                    Node newNode = new Node(value);
                    newNode.next = node;
                    node.previous.next = newNode;
                    newNode.previous = node.previous;
                    node.previous = newNode;
                }
            }
            catch (ArgumentException ex)
            { Console.WriteLine(ex.Message); }


        }

        public void Show()
        {
            Node tempCur= head;
            while(tempCur != null)
            {
                Console.Write(tempCur.value + "  ");
                tempCur = tempCur.next;
            }
            Console.WriteLine("");


        }

        public void Remove(int value)
        {
            try
            {
                if (value == head.value)
                {
                    head.next.previous = null;
                    head = head.next;


                }

                else
                {
                    Node node = head;
                    while (node != null)
                    {
                        if (node.value == value)
                        {
                            break;
                        }
                        node = node.next;

                    }

                    node.previous.next = node.next;
                    node.next.previous = node.previous;
                    node = null;

                }
            }
            catch (ArgumentException ex)
            { Console.WriteLine(ex.Message);}

        }


    }
    
}
