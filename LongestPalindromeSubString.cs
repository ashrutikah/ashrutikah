using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class LongestPalindromeSubString
    {

        public static String longestPalindrome(String s)
        {
            int start = 0, end = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int len1 = expandAroundCenter(s, i, i);
                int len2 = expandAroundCenter(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if (len > end - start)
                {
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                }
            }
            return s.Substring(start, end + 1);
        }

        private static int expandAroundCenter(String s, int left, int right)
        {
            int L = left, R = right;
            while (L >= 0 && R < s.Length && s[L] == s[R])
            {
                L--;
                R++;
            }
            return R - L - 1;
        }

        //public static void Main()
        //{
        //    string str = Console.ReadLine();
        //    Console.WriteLine("\n LONGEST PALINDROME IS :" +longestPalindrome(str));
        //    Console.ReadLine();

        //    string strTest = "abcd";

        //    int asciiCode = strTest[2];
        //}

        public static Boolean isPalindrome(string s)
        {
            for (int i = 0, j = s.Length -1; i < s.Length; i++)
            {
                if (j > 0)
                {

                    if (s[i] != s[j])
                    {
                        return false;
                    }
                }

                j--;
            }

            return true;
        }

        public string LongestPalindrome(string s)
        {
            //get all of the substrings
            Dictionary<int, string> dicAllSubStrs = new Dictionary<int, string>();
            int dicCount = 0;
            string strLongestP = string.Empty;

            if (s.Length == 1)
                return s;

            string subStr = string.Empty;


            for (int i = 0; i < s.Length; i++)
            {

                for (int j = s.Length; j > 0; j--)
                {


                    try
                    {

                        subStr = s.Substring(i, j - i);
                    }
                    catch
                    {
                        subStr = s.Substring(i, s.Length - i);
                    }
                    if (isPalindrome(subStr))
                    {
                        dicAllSubStrs.Add(dicCount, subStr);

                        if (strLongestP.Length < subStr.Length)
                            strLongestP = subStr;
                        dicCount++;
                    }
                }

            }

            return strLongestP;
        }

       }


}
