using System;
using System.Collections.Generic;


namespace ConsoleApplication1
{
    class NumberSet
    {
        private HashSet<int> numberSet = new HashSet<int>();

        public void InsertElement(int a)
        {
            
            numberSet.Add(a);
        }

        public SortedSet<int> GetSumDigits()
        {            
            SortedSet<int> s = new SortedSet<int>();
            foreach (int number in numberSet)
            {
                int[] digits = Array.ConvertAll(number.ToString("0").ToCharArray(), ch => ch - '0');
                int sum =0;
                foreach(int i in digits)
                {
                    sum = sum + i; 
                }
                s.Add(sum);
            }

                       
            return s;
        }
    }

    public class Programn
    {

        //public static void Main()
        //{
        //    Console.WriteLine("Enter number of integers:");
        //    int n = int.Parse(Console.ReadLine());
        //    NumberSet ns = new NumberSet();
            
        //    for (int i = 0; i < n; i++)
        //    {
        //        int numberINput = int.Parse(Console.ReadLine());
        //        ns.InsertElement(numberINput);
        //    }
        //    SortedSet<int> finalResult = ns.GetSumDigits();
        //    Console.WriteLine("Unique digit sum");
        //    foreach (int number in finalResult)
        //    {
        //        Console.WriteLine(number);
        //    }

        //   // Console.ReadLine();
        //}
    }
}
