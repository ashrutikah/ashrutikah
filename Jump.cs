using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Jump
    {
        public enum Romans{
                ttt = 1
            };

        //public static void Main(string[] args)
        //{

            

        //    int[] arr = { 2,3,1,1,4};

        //    Jump clsJump = new Jump();
        //    if(clsJump.ReachesEnd(arr))
        //    {
        //         Console.WriteLine("Reached end");
        //    }
        //    Console.ReadLine();
        //}

        public List<int> possibleSolutions(int num)
        {
            List<int> possiblesoln = new List<int>();
            possiblesoln.Add(num);
            num = num - 1;
            while (num > 0)
            {
                possiblesoln.Add(num - 1);
                num--;
            }
            return possiblesoln;
        }

        public bool ReachesEnd(int[] nums)
        {
            int lastPos = nums.Length - 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (i + nums[i] >= lastPos)
                {
                    lastPos = i;
                }
            }
            return lastPos == 0;
        }
    }
}
