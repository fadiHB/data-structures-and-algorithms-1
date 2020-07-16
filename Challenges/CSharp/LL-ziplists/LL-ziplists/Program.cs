﻿using System;
using LinkedListLibrary;
namespace LL_ziplists
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Zip two linked lists together
        /// </summary>
        /// <param name="listA">listA list</param>
        /// <param name="listB">listB list</param>
        /// <returns>New Linked List with alternating values from supplied lists</returns>
        public static Node Zip(LinkedList listA, LinkedList listB)
        {
            LinkedList newLinkedList = new LinkedList();
            newLinkedList.Current = newLinkedList.Head;
            Node CurrentA = listA.Head;
            Node CurrentB = listB.Head;

            while (CurrentA != null || CurrentB != null)
            {
                if (CurrentA != null && CurrentB != null)
                {
                    newLinkedList.Insert(CurrentB.Value);
                    newLinkedList.Insert(CurrentA.Value);
                    CurrentB = CurrentB.Next;
                    CurrentA = CurrentA.Next;
                }
                else if (CurrentA != null && CurrentB == null)
                {
                    newLinkedList.Insert(CurrentA.Value);
                    CurrentA = CurrentA.Next;
                }
                else if (CurrentA == null && CurrentB != null)
                {
                    newLinkedList.Insert(CurrentB.Value);
                    CurrentB = CurrentB.Next;
                }
                else
                {
                    CurrentA = CurrentA.Next;
                    CurrentB = CurrentB.Next;
                }
            }
            return newLinkedList.Head;
        }
    }
}