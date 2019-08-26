using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    //public enum RomansToINT
    //{
    //    I = 1,
    //    V = 5,
    //    X = 10,
    //    C = 100,
    //    D = 500,
    //    M = 1000
    //}

    class RomansToINTProblem
    {
        //public static void Main(string[] args)
        //{
        //    RomansToINTProblem clsRomansToINTProblem = new RomansToINTProblem();
        //   // Console.WriteLine(clsRomansToINTProblem.RomanToInt("IV"));
        //    //Console.WriteLine(clsRomansToINTProblem.RomanToInt("III"));
        //    Console.WriteLine(clsRomansToINTProblem.RomanToInt("LVIII"));
        //    Console.ReadLine();
        //}
        public int RomanToInt(string s)
        {

            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length && (
                    (s[i].ToString() + s[i + 1].ToString()).ToString().Equals("XL") ||
                    (s[i].ToString() + s[i + 1].ToString()).ToString().Equals("XC") ||
                    (s[i].ToString() + s[i + 1].ToString()).ToString().Equals("IV") ||
                    (s[i].ToString() + s[i + 1].ToString()).ToString().Equals("IX") ||
                    (s[i].ToString() + s[i + 1].ToString()).ToString().Equals("CD") ||
                    (s[i].ToString() + s[i + 1].ToString()).ToString().Equals("CM")
                    ))
                {
                    if ((s[i].ToString() + s[i + 1].ToString()).ToString().Equals("XL"))
                    {
                        i++;
                        result += 40;                        
                    }
                    else if ((s[i].ToString() + s[i + 1].ToString()).ToString().Equals("XC"))
                    {
                        i++;
                        result += 90;
                    }
                    else if ((s[i].ToString() + s[i + 1].ToString()).ToString().Equals("IV"))
                    {
                        i++;
                        result += 4;
                    }
                    else if ((s[i].ToString() + s[i + 1].ToString()).ToString().Equals("IX"))
                    {
                        i++;
                        result += 9;
                    }
                    else if ((s[i].ToString() + s[i + 1].ToString()).ToString().Equals("CD"))
                    {
                        i++;
                        result += 400;
                    }
                    else if ((s[i].ToString() + s[i + 1].ToString()).ToString().Equals("CM"))
                    {
                        i++;
                        result += 900;
                    }

                }
                else
                {
                    if (s[i] == 'X')
                    {

                        result += 10;

                    }
                    else if (s[i] == 'I')
                    {
                        result += 1;
                    }
                    else if (s[i] == 'V')
                    {
                        result += 5;
                    }
                    else if (s[i] == 'L')
                    {
                        result += 50;
                    }
                    else if (s[i] == 'C')
                    {
                        result += 100;
                    }
                    else if (s[i] == 'D')
                    {
                        result += 500;
                    }
                    else if (s[i] == 'M')
                    {
                        result += 1000;
                    }
                }
            }

            return result;

        }
    }   
}
