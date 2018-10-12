using System;

namespace MiddleElementLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = GetLinkedList();
            var middleElement = GetMiddleElement(list.Head);
            Console.WriteLine("Middle Element Value is " + middleElement.Value);
            Console.ReadLine();
        }

        private static int? GetMiddleElement(Node head)
        {
            if (head == null)
                return null;
            if (head.Next == null)
                return head.Value;
            var slowPointer = head;
            var fastPointer = head;
            while (fastPointer != null)
            {
                fastPointer = fastPointer.Next;
                if (fastPointer != null)
                {
                    fastPointer = fastPointer.Next;
                    slowPointer = slowPointer.Next;
                }
            }
            return slowPointer.Value;
        }

        private static LinkedList GetLinkedList()
        {
            Node head = new Node() { Value = 1, Next = null };
            var secondNode = new Node() { Value = 2, Next = null };
            var thirdNode = new Node() { Value = 3, Next = null };
            var fourthNode = new Node() { Value = 4, Next = null };
            var fifthNode = new Node() { Value = 5, Next = null };

            fourthNode.Next = fifthNode;
            thirdNode.Next = fourthNode;
            secondNode.Next = thirdNode;
            head.Next = secondNode;
            var list = new LinkedList() { Head = head};
            return list;
        }
    }
}
