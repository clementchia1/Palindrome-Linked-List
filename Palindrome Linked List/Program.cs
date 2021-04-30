using System;

namespace Palindrome_Linked_List
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
                ListNode listNode = new ListNode(1);
                Add(listNode, 2);
                Add(listNode, 3);
                Add(listNode, 4);
                Add(listNode, 4);
                Add(listNode, 3);
                Add(listNode, 2);
                Add(listNode, 1);
                show(listNode);
                Console.WriteLine("IsPalindrome:" + IsPalindrome(listNode)); 
            }

            public static void Add(ListNode listNode, int val)
            {
                ListNode newNode = new ListNode(val);

                if (listNode == null)
                {
                    listNode = newNode;
                    return;
                }

                while (listNode.next != null)
                {
                    listNode = listNode.next;
                }

                listNode.next = newNode;
                return;
            }

            public static void show(ListNode listNode)
            {
                while (listNode != null)
                {
                    Console.Write(listNode.val);
                    if (listNode.next != null)
                    {
                        Console.Write(",");
                    }
                    listNode = listNode.next;
                }
            }

            public static bool IsPalindrome(ListNode head)
            {
                int count = 0;
                ListNode reverse_head = new ListNode();
                ListNode head_copy = head;
                while (head_copy != null)
                {
                    ListNode newNode = new ListNode(head_copy.val);
                    if (count>0)
                    {
                        newNode.next = reverse_head;
                    }

                    reverse_head = newNode;

                    head_copy = head_copy.next;
                    count++;
                }

                for (int i = 0; i < count/2; i++)
                {
                    if (head.val!=reverse_head.val)
                    {
                        return false;
                    }
                    head = head.next;
                    reverse_head = reverse_head.next;
                }
                return true;
            }
        }
    }
}
