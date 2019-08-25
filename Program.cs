using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingPractice
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    // The code provided will print ‘Hello World’ to the console.
        //    // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
        //    Console.WriteLine("Hello World!");
           

        //    GenericClass<string> obj = new GenericClass<string>();
        //   Console.WriteLine(obj.Compare("Hello", "Hello"));

        //    Factorial objFactorial = new Factorial();
            
        //    objFactorial.WhereToSend = DisplayResults; objFactorial.CalculateFactiorial(4);
        //    // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app

        //    Console.ReadKey();
        //}

        static void DisplayResults(Int64 val)
        {
            Console.WriteLine(val);
        }

        
    }

    public class GenericClass<T>
    {
        public bool Compare(T obj1, T obj2)
        {
            if (obj1.Equals(obj2))
                return true;
            return false;
        }
    }

    public class Factorial
    {
        public delegate void SendResult(Int64 x);

        public SendResult WhereToSend;
        public void CalculateFactiorial(Int64 x)
        {
            Int64 result = 1;
            for (Int64 i = x; i > 1; i--)
            {
                result = result * i;
            }
            WhereToSend(result);
        }
        public void Print(Int64 x)
        {
            Int64 y = x;
            WhereToSend(y);
        }
    }
}
