﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework5
{
    public class SingleLinkedList
    {
        public Node first;
        public SingleLinkedList()
        {
            first = null;
        }
        public void AddingBeforeFirst(int data)
        {
            Node start = new Node(data, first);
            first = start;
        }
        public void PrintList()
        {
            Node current = first;
            while (current != null)
            {
                Console.Write(current.Info + " ");
                current = current.Link;
            }
        }
        public void AddToBeginning(int value)
        {
                Node newNode = new Node(value);
                newNode.Link = first;
            first = newNode;
        }
        public void Concat(SingleLinkedList L2)
        {
            if (first == null)
            {
                first = L2.first;
            }
            else
            {
                Node current = first;
                while (current.Link != null)
                {
                    current = current.Link;
                }
                current.Link = L2.first;
                L2.first = null;
            }
        }
        public void AddToEnd1(int value)
        {
            Node newNode = new Node(value);
            if (first == null)
            {
                first = newNode;
            }
            else
            {
                Node current = first;
                while (current.Link != null)
                {
                    current = current.Link;
                }
                current.Link = newNode;
            }
        }
        public void AddRangeToEnd(int[] values)
        {
            foreach (int value in values)
            {
                AddToEnd1(value);
            }
        }


        public void RemoveFromEnd()
        {
            if (first != null)
            {
                if (first.Link != null)
                {
                    Node current = first;
                    while (current.Link.Link != null)
                    {
                        current = current.Link;
                    }
                    current.Link = null;

                }
                else
                    first = null;

            }

        }

        public void RemoveFromBeginning()
        {
            if (first != null)
            {
                first = first.Link;

            }
        }
        public void RemoveNodeByIndex(int index)
        {
            if (first != null)
            {

                if (index != 0)
                {
                    Node current = first;
                    int currentIndex = 0;
                    while (current.Link != null && currentIndex < index - 1)
                    {
                        current = current.Link;
                        currentIndex++;
                    }

                    if (current.Link != null || currentIndex == index - 1)
                        current.Link = current.Link.Link;

                }
                else
                    first = first.Link;


            }

        }
        public void AddNode(int value, int index)
        {
            if (index != 0)
            {
                Node current = first;
                int currentIndex = 0;
                while (current != null && currentIndex < index - 1)
                {
                    current = current.Link;
                    currentIndex++;
                }

                if (current != null || currentIndex == index - 1)
                {

                    Node newNode = new Node(value);
                    newNode.Link = current.Link;
                    current.Link = newNode;
                }


            }
            else
                AddToBeginning(value);


        }
        public void RemoveRange(int start, int end)
        {
            if (first != null)
            {
                Node p = first;
                Node prev = null;
                int index = 0;

                while (p != null && index < start)
                {
                    prev = p;
                    p = p.Link;
                    index++;
                }

                while (p != null && index <= end)
                {
                    Node next = p.Link;
                    if (prev == null)
                    {
                        first = next;
                    }
                    else
                    {
                        prev.Link = next;
                    }
                    p = next;
                    index++;
                }
            }
        }
        public void ListBoxUPD(SingleLinkedList list,ListBox listBox1)
        {
            if (first == null)
            {
                listBox1.Items.Clear();
            }
            listBox1.Items.Clear();
            Node current = list.first;
            while (current != null)
            {
                listBox1.Items.Add(current.Info);
                current = current.Link;
            }
        }
        public void Destroy()
        {
            first = null;
        }

    }
}
