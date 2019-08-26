using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class MergeTwoSortedList
    {
        public static void Main(string[] args)
        {
            #region "CREATE INPUT"
            ListNode l12 = new ListNode(4);
            ListNode l11 = new ListNode(2);
            ListNode l1 = new ListNode(1);
            l1.next = l11;
            l11.next = l12;

            ListNode l22 = new ListNode(4);
            ListNode l21 = new ListNode(3);
            ListNode l2 = new ListNode(1);
            l2.next = l21;
            l21.next = l22;


            #endregion

            MergeTwoSortedList clsMergeTwoSortedList = new MergeTwoSortedList();

            ListNode resultNodes = null;
            resultNodes = clsMergeTwoSortedList.MergeTwoLists(l1, l2);
            while (resultNodes != null)
            {
                Console.WriteLine(resultNodes.val);
                resultNodes = resultNodes.next;
            }

            Console.ReadLine();

        }


       public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode(0); ; ListNode tail = dummy; 

            while(l1 != null || l2 != null)
            {
                var l1Value = l1 != null ? l1.val : int.MaxValue;
                var l2Value = l2 != null ? l2.val : int.MaxValue;

                if (l1Value < l2Value)
                {
                    tail.next = l1;
                    tail = l1;
                    l1 = l1.next;
                }
                else
                {
                    tail.next = l2;
                    tail = l2;
                    l2 = l2.next;
                }
                  
            }

            return dummy.next;
        }       
    }

   public class ListNode
    { 
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; next = null; }
    }
}
