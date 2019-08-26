using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class ZigZagStringConversion
    {
        //public static void Main()
        //{
        //    //Console.WriteLine(convert("cbxdwjccgtdoqiscyspqzvuqivzptlpvooynyapgvswoaosaghrffnxnjyeeltzaizniccozwknwyhzgpqlwfkjqipuujvwtxlbznryjdohbvghmyuiggtyqjtmuqinntqmihntkddnalwnmsxsatqqeldacnnpjfermrnyuqnwbjjpdjhdeavknykpoxhxclqqedqavdwzoiorrwwxyrhlsrdgqkduvtmzzczufvtvfioygkvedervvudneghbctcbxdxezrzgbpfhzanffeccbgqfmzjqtlrsppxqiywjobspefujlxnmddurddiyobqfspvcoulcvdrzkmkwlyiqdchghrgytzdnobqcvdeqjystmepxcaniewqmoxkjwpymqorluxedvywhcoghotpusfgiestckrpaigocfufbubiyrrffmwaeeimidfnnzcphkflpbqsvtdwludsgaungfzoihbxifoprwcjzsdxngtacw", 472));
        //    Console.WriteLine(convert("PAYPALISHIRING", 3));
        //    Console.ReadLine();
        //}

        public static String convert(String s, int numRows)
        {
            if (numRows == 1) return s;
            int gap = (numRows - 1) << 1;
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < numRows; i++)
            {
                int current = i;
                int offset = gap - (i << 1);
                while (current < s.Length)
                {
                    if (offset != 0)
                    {
                        // avoid inserting duplicate elements
                        // in the first and the last row
                        result.Append(s[current]);

                        current += offset;
                    }
                    offset = gap - offset;
                }
            }

            return result.ToString();
        }

       static string convertZigZag(string s, int numRows)
        {
            StringBuilder output = new StringBuilder();
            int len = s.Length;
            int maxChars = len / numRows;
            
            int i = 0; int iterationR =0;
            if (maxChars > 0)
            {
                for (int iteration = 0; iteration < numRows; iteration++)
                {
                    if (iteration % 2 == 0)
                    {
                        i = iterationR;
                        while (i < len)
                        {
                            output.Append(s[i]);
                            i = i + maxChars;
                        }
                        iterationR++;
                    }
                    if (iteration % 2 != 0)
                    {
                        i = iterationR;
                        while (i < len)
                        {
                            output.Append(s[i]);
                            i = i + 2;
                        }
                        iterationR++;
                    }

                }
            }
            else
            {
                output.Append(s);
            }
           return output.ToString();
        }
    }

    
    
}
