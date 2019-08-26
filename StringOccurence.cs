using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class StringOccurence
    {
        //public static void Main(string[] args)
        //{
        //    string input = "racbbrrbar";
        //    //Output should r b a c
        //    //r -4,b - 3, a-2,c-1
        //    //Count the occurence in hashtable/ list/dictionary
        //    //Sort it
        //    //Print the letter descending
        //    StringOccurence StringOccurenceObj = new StringOccurence();
        //    StringOccurenceObj.BuildOccurenceArray(input);
        //}

        public void BuildOccurenceArray(string inp)
        { 
            //Assuming that the string array contains ASCII only
            Dictionary<int,strArray> occurenceArray = new Dictionary<int,strArray>();

                    
            foreach (char c in inp)
            {
                strArray strA = new strArray();
                if (occurenceArray.ContainsKey((int)c))
                {
                    occurenceArray[(int)c].c = c;
                    occurenceArray[(int)c].cnt++;
                }
                else
                {
                    strA.c = c;
                    strA.cnt = 1;
                    occurenceArray[(int)c] = strA;
                }
            }

            var SortedDic = occurenceArray.OrderByDescending(r => r.Value.cnt);

            foreach (KeyValuePair<int, strArray> kv in SortedDic)
            {
                Console.WriteLine(kv.Value.c);
            }

            Console.ReadLine();
        }

        public class strArray
        {
            //public int key;
            public char c;
            public int cnt = 0;
        }
    }
}
