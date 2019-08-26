using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class checkParenthesis
    {
        //public static void Main(string[] args)
        //{
        //    string strInput = "(])";

        //    checkParenthesis clscheckParenthesis = new checkParenthesis();
        //    Console.WriteLine(clscheckParenthesis.IsValid(strInput));
        //    Console.ReadLine();
            
        //}

        public bool IsValid(string strInput)
        {
            Stack<char> strParenthesis = new Stack<char>();
            bool result = true;

            foreach (char c in strInput)
            {
                if (c == '{' || c == '[' || c == '(')
                    strParenthesis.Push(c);
                else if (c == '}' || c == ']' || c == ')')
                {
                    //get the index of the corresponding opening bracket
                    if (c == '}') //search for {
                    {
                        if (strParenthesis.Count > 0)
                        {
                            if (strParenthesis.Peek() == '{')
                            {
                                strParenthesis.Pop();
                            }
                            else
                                result = false;
                        }
                        else
                            result = false;
                    }
                    else if (c == ']') //search for {
                    {
                        if (strParenthesis.Count > 0)
                        {
                            if (strParenthesis.Peek() == '[')
                            {
                                strParenthesis.Pop();
                            }
                            else
                                result = false;
                        }
                        else
                            result = false;
                    }
                    else if (c == ')') //search for {
                    {
                        if (strParenthesis.Count > 0)
                        {
                            if (strParenthesis.Peek() == '(')
                            {
                                strParenthesis.Pop();
                            }
                            else
                                result = false;
                        }
                        else
                            result = false;
                    }

                }
            }

            if (strParenthesis.Count == 0 && result == true)
                return true;


            return false;
        }
    }
}
