using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace codingPractice
{
    class Result
    {

        /*
         * Complete the 'optimalPoint' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY magic
         *  2. INTEGER_ARRAY dist
         */

        public static int optimalPoint(List<int> magic, List<int> dist)
        {
            int unitsOfMagic = 0;
            int n = magic.Count;
            for (int i =0; i < n; i++)
            {
                unitsOfMagic = magic[i];
                if (dist[i] <= unitsOfMagic)
                {
                    if (i + 1 < n)
                    {
                        unitsOfMagic = unitsOfMagic - dist[i] + magic[i + 1];
                    }
                    else
                    {
                        unitsOfMagic = unitsOfMagic - dist[i] + magic[0];
                    }

                    for (int j = i + 1; j < n; j++)
                    {
                        if (dist[j] < unitsOfMagic)
                        {
                            if (j + 1 < n)
                            {
                                unitsOfMagic = unitsOfMagic - dist[j] + magic[j + 1];
                            }
                            else
                            {
                                unitsOfMagic = unitsOfMagic - dist[j] + magic[0];
                            }
                        }
                        else
                        {
                            j = n; 
                        }

                        if (j == n - 1 && unitsOfMagic - dist[0] > 0)
                            return i;
                    }
                }
            }

            return -1;
        }

    }

    class Solution
    {
        //public static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int magicCount = Convert.ToInt32(Console.ReadLine().Trim());

        //    List<int> magic = new List<int>();

        //    for (int i = 0; i < magicCount; i++)
        //    {
        //        int magicItem = Convert.ToInt32(Console.ReadLine().Trim());
        //        magic.Add(magicItem);
        //    }

        //    int distCount = Convert.ToInt32(Console.ReadLine().Trim());

        //    List<int> dist = new List<int>();

        //    for (int i = 0; i < distCount; i++)
        //    {
        //        int distItem = Convert.ToInt32(Console.ReadLine().Trim());
        //        dist.Add(distItem);
        //    }

        //    int result = Result.optimalPoint(magic, dist);

        //    textWriter.WriteLine(result);

        //    textWriter.Flush();
        //    textWriter.Close();
        //}
    }
}
