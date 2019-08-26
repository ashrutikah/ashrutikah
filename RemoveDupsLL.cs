using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class RemoveDupsLL
    {
        //public static void Main(string[] args)
        //{
        //    # region "INPUT"

        //    Node e = new Node();
        //    e.val = 7;
        //    e.next = null;

        //    Node d = new Node();
        //    d.val = 6;
        //    d.next = e;

        //    Node c = new Node();
        //    c.val = 5;
        //    c.next = d;

        //    Node b = new Node();
        //    b.val = 4;
        //    b.next = c;

        //    Node a = new Node();
        //    a.val = 3;
        //    a.next = b;

        //   #endregion

        //    PrintKthElementToLast(a, 2);
        //    //RemoveDups(a);
        //}

        public static void RemoveDups(graphNodes1 n)
        { 
            List<int> lst = new List<int>();
            graphNodes1 prev = null;
            while (n != null)
            {
                if (lst.Contains(n.val))
                {
                    prev.next = n.next;
                }
                else
                {
                    lst.Add(n.val);
                    prev = n;
                }

                n = n.next;
            }
        }

        public static int PrintKthElementToLast(graphNodes1 head,int k)
        {
            if (head == null)
                return 0;

            
            int index = PrintKthElementToLast(head.next, k) + 1;
            if (index == k)
            {
                Console.WriteLine(head.val);
            }

            return index;
        }
    }

    public class graphNodes1
    {
        public int val;
        public graphNodes1 next;
    }
}
