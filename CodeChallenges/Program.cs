using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Collections;

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

        static public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {


            var left = 0;
            var list = new Stack();

            while (l1 != null || l2 != null)
            {
                var first = l1 == null ? 0 : l1.val;
                var second = l2 == null ? 0 : l2.val;


                var add = (first + second + left);

                if (add > 9)
                {
                    left = Convert.ToInt32(add.ToString().Substring(0, 1));
                }
                else
                {
                    left = 0;
                }


                list.Push(add % 10);


                if (l1 == null && l2 != null)
                {
                    l1 = null;
                    l2 = l2.next;
                }
                else if (l1 != null && l2 == null)
                {
                    l1 = l1.next;
                    l2 = null;
                }
                else
                {
                    l1 = l1.next;
                    l2 = l2.next;
                }

            }
            if (left > 0)
            {
                list.Push(left);
            }

            var returnNode = new ListNode((int)list.Pop());
            while (list.Count > 0)
            {

                returnNode = new ListNode((int)list.Pop(), returnNode);
            }





            return returnNode;

        }




    }
    class Program
    {

        static void Main(string[] args)
        {
            var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));



            Console.WriteLine(Tests.AddTwoNumbers(l1, l2));

            Console.ReadKey();
        }

    }
}
