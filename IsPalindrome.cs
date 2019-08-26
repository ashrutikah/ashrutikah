using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class PalindromInt
    {
        //public static void Main()
        //{
        //    int a = int.Parse(Console.ReadLine());
        //    Console.WriteLine(IsPalindrome(a));
        //    Console.ReadLine();
        //}

        public static bool IsPalindrome(int x)
        {
            char[] x1 = x.ToString().ToCharArray();
           
            for(int i = 0, j = x1.Length -1; i < x1.Length; i++)
                {
                    
                    if (j > 0)
                    {
                        if (x1[i] != x1[j])
                        {
                            return false;
                        }
                        
                    }
                    j--;
                }
                return true;
            }            
         
    }



}
