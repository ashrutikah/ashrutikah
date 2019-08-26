using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class AmzDemo
    {
        // IMPORT LIBRARY PACKAGES NEEDED BY YOUR PROGRAM
        // SOME CLASSES WITHIN A PACKAGE MAY BE RESTRICTED
        // DEFINE ANY CLASS AND METHOD NEEDED
        // CLASS BEGINS, THIS CLASS IS REQUIRED
        public class Solution
        {
            //public static void Main(string[] args)
            //{
            //    int[] states = { 1,0,0,0,0,1,0,0};
            //    int days = 1;
            //    cellCompete(states, days);
            //}

            //METHOD SIGNATURE BEGINS, THIS METHOD IS REQUIRED
            public static int[] cellCompete(int[] states, int days)
            {
                // INSERT YOUR CODE HERE
                //int[] Outputarr;
                while (days > 0)
                {
                    states = iterationOne(states);
                    days--;
                }

                return states;
            }

            public static int computeValue(int a, int b)
            {
                //Console.WriteLine(a);
                int returnVal = 1;
                if (a == 0 && b == 0)
                    returnVal = 0;
                if (a == 1 && b == 1)
                    returnVal = 0;

                return returnVal;
            }

            public static int[] iterationOne(int[] states)
            {
                int[] arr = {0,0,0,0,0,0,0,0};
                List<int> wwi = new List<int>();
                wwi.Count();
                int Tkey;
                string tval;
                //BinaryTree<int> bt = new BinaryTree<int>();
                for (int i = 0; i < states.Length; i++)
                {
                    //For the first element, one neighbor is always 0
                    if (i == 0)
                        arr[i] = computeValue(0, states[i + 1]);
                    else if (i == states.Length - 1)
                        arr[i] = computeValue(0, states[i - 1]);
                    else
                        arr[i] = computeValue(states[i - 1], states[i + 1]);
                }
                return arr;
            }
            // METHOD SIGNATURE ENDS
        }
    }


}
