////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace codingPractice
////{
////    class CalculateFactors
////    {
////        public static long pthFactor(long n, long p)
////        {
////            List<long> lst = new List<long>();
////            long quotient = 0;

////            if (n > 0)
////            {
////                //If the input n is 1
////                if (n == 1)
////                {
////                    lst.Add(1);
////                }
////                else
////                {
////                    lst.Add(1);
////                    lst.Add(n);
////                    //if n is divisible by 2
////                    if (n % 2 == 0)
////                    {
////                        lst.Add(2);
////                        quotient = n / 2;
////                    }
////                    else if (n % 3 == 0)
////                    {
////                        lst.Add(3);
////                        quotient = n / 3;
////                    }
////                    else if (n % 5 == 0)
////                    {
////                        lst.Add(5);
////                        quotient = n / 5;
////                    }
////                    else if (n % 7 == 0)
////                    {
////                        lst.Add(7);
////                        quotient = n / 7;
////                    }
////                    while (quotient > 2)

////                    {
////                            if (quotient % 2 == 0)
////                            {
////                            if (!lst.Contains(2))
////                                lst.Add(2);

////                            if (!lst.Contains(quotient / 2))
////                                    lst.Add(quotient / 2);
////                                quotient = quotient / 2;
////                            }
////                            if (quotient % 3 == 0)
////                            {
////                            if (!lst.Contains(3))
////                                lst.Add(3);

////                            if (!lst.Contains(quotient / 3))
////                                    lst.Add(quotient / 3);
////                                quotient = quotient / 3;
////                            }
////                            if (quotient % 5 == 0)
////                            {
////                            if (!lst.Contains(5))
////                                lst.Add(5);

////                            if (!lst.Contains(quotient / 5))
////                                    lst.Add(quotient / 5);
////                                quotient = quotient / 5;
////                            }
////                        if (quotient % 7 == 0)
////                        {
////                            if (!lst.Contains(7))
////                                lst.Add(7);

////                            if (!lst.Contains(quotient / 7))
////                                lst.Add(quotient / 7);
////                            quotient = quotient / 7;
////                        }
////                    }

////                }
////            }
////            lst.Sort();
////            long result = 0;
////            try
////            {
////                result = lst[Convert.ToInt32(p-1)];
////            }
////            catch(Exception exp)
////            {
////                result = 0;
////            }

////            return result;
////        }

////        public static long pthFactor1(long n, long p)
////        {
////            int num, x;
////            List<long> lst = new List<long>();
////            Console.WriteLine("Enter the Number ");
////            num = int.Parse(Console.ReadLine());
////            Console.WriteLine("The Factors are : ");
////            for (x = 1; x <= num; x++)
////            {
////                if (num % x == 0)
////                {
////                    if (!lst.Contains(num / x))
////                        lst.Add(num / x);
////                    Console.WriteLine(num / x);
////                }
////            }
////            lst.Sort();
////            long result = 0;
////            try
////            {
////                result = lst[Convert.ToInt32(p - 1)];
////            }
////            catch (Exception exp)
////            {
////                result = 0;
////            }
////            Console.ReadLine();
////            return result;

////        }

////        static void Main(string[] args)
////        {

////            pthFactor1(10, 3);
////        }
////    }
////}
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;

//class Solution
//{
//    static long[] Elements;

//    static void Main(String[] args)
//    {
//        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
//        var firstLineParams = Console.ReadLine().Split(' ');
//        var fNumber = long.Parse(firstLineParams[0]);

//        Elements = Array.ConvertAll(Console.ReadLine().Split(' '), i => long.Parse(i))
//            .OrderByDescending(i => i)
//            .ToArray();

//        var factorials = GetReverseFactorial(fNumber);
//        if (factorials == null)
//        {
//            Console.WriteLine(-1);
//            return;
//        }
//        //factorials.Reverse();

//        var result = new List<long>();
//        long curr = 1;
//        result.Add(curr);

//        foreach (var f in factorials)
//        {
//            curr *= f;
//            result.Add(curr);
//        }
//        Console.WriteLine(string.Join(" ", result));
//        Console.ReadLine();
//    }

//    static List<long> GetReverseFactorial(long fNumber)
//    {
//        for (var i = 0; i < Elements.Length; i++)
//        {
//            var currElement = Elements[i];
//            if (fNumber == currElement)
//            {
//                var result = new List<long>();
//                result.Add(currElement);
//                return result;
//            }
//            else
//            {
//                if (fNumber % currElement == 0)
//                {
//                    long subFNumber = fNumber / currElement;
//                    var subResult = GetReverseFactorial(subFNumber);
//                    if (subResult != null)
//                    {
//                        subResult.Add(currElement);
//                        return subResult;
//                    }
//                }
//            }
//        }

//        return null;
//    }
//}

