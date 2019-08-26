using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class CharacterOccurence
    {
        public static int[] BuildFrequencyArray(string strInput)
        {
            int[] frequencyArr = new int[26];
            int count = 0;
            foreach(char c in strInput)
            {
                int i = getCharIndex(c);

                if (i > 0)
                {
                    frequencyArr[i]++;
                
                }

                count++;
            }
            return frequencyArr;
        }

        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter the string");
        //    string strInput = Console.ReadLine();
        //    BuildFrequencyArray(strInput);

        //    char[] content = strInput.ToCharArray();
        //    Array.Sort(content);

            
        //}

        public static int getCharIndex(char c)
        {
            int Index = c - 'a';// - c;

            if (Index > 26)
                Index = -1;

            return Index;
        }
    }
}
