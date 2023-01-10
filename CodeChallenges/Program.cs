using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Collections;
using CodeChallenges;
using System.ComponentModel;

namespace CodeChallenges
{
    class Tests
    {

        static public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) return head;
            ListNode temp = head;
            while (temp.next != null)
            {
                if (temp.val == temp.next.val)
                {
                    temp.next = temp.next.next;
                }
                else
                {
                    temp = temp.next;
                }
            }
            return head;
        }



    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            ListNode listNode = new ListNode();
            listNode.val = 1;

            ListNode listnode1 = new ListNode(1,listNode);
            ListNode listnode2 = new ListNode(3, listnode1);
            ListNode listnode3 = new ListNode(1, listnode2);

          




            Console.WriteLine(Tests.DeleteDuplicates(listnode3));

            Console.ReadKey();
        }

    }
}

