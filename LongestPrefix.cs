using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class LongestPrefix
    {
        //public static void Main(string[] args)
        //{
        //    string[] input = { "c","acc","ccc"};
        //    LongestPrefix clsLongestPrefix = new LongestPrefix();
        //    clsLongestPrefix.LongestCommonPrefix(input);
        //}

        public string LongestCommonPrefix(string[] strs)
        {
            string output = string.Empty;
            int maxLength = 10;
            string temp = string.Empty;

            for (int i = 0; i < maxLength; i++)
            {
                if (i < strs[0].Length)
                {
                    temp = output + strs[0][i];
                    foreach (string s in strs)
                    {

                        if (s.StartsWith(temp))
                        {
                            //temp = temp;
                        }
                        else
                            return output;


                    }
                    output = temp;
                }
            }

            return output;
        }
    }

    
        
    
}
