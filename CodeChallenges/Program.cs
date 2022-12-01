using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CodeChallenges
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
    }

    class Tests
    {


        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
                return list2;
            if (list2 == null)
                return list1;
            ListNode newHead = new ListNode();
            var result = newHead;
            while (list1 != null && list2!=null)
            {

                if (list1.val >=list2.val)
                {
                    result.next = list2;
                    list2 = list2.next;
                }
                else
                {
                    result.next = list1;
                    list1 = list1.next;
                }



                result = result.next;
              
            }

            if (list1 != null) result.next = list1;
            if (list2 != null) result.next = list2;

            return newHead.next;
        }
        class Program
        {

            static void Main(string[] args)
            {
                ListNode list1 = new ListNode();
                list1.val =2;
                list1.next = new ListNode(3);
                list1.next.next = new ListNode(5);


                ListNode list2 = new ListNode();
                list2.val = 4;
                list2.next = new ListNode(3);
                list2.next.next = new ListNode(6);

                Tests.MergeTwoLists(list1, list2);

                Console.ReadKey();
            }

        }

    }
}
