using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    using System;

    public class Shape
    {
        public string _shapeName = string.Empty;
        public string shapeName
        {
            get { return this._shapeName; }
            set { this._shapeName = shapeName; }
        }
        public Shape()
        {
        }
        public double CalculateArea()
        {
            return 0;
        }
    }

    public class Square : Shape
    {
        protected Int32 _side;
        public Square()
        {
            _side = 0;
            _shapeName = "Square";
        }

        public double CalculateArea(double side)
        {
            return side * side;
        }
    }

    public class Rectangle : Shape
    {
        protected Int32 _length;
        protected Int32 _breadth;
        public Rectangle()
        {
            _shapeName = "Rectangle";
        }

        public double CalculateArea(Int32 length, Int32 breadth)
        {
            return length * breadth;
        }
    }

    public class Circle : Shape
    {
        protected Int32 _radius;

        public Circle()
        {
            _shapeName = "Circle";
        }

        public double CalculateArea(double radius)
        {
            return System.Math.PI * radius * radius;
        }
    }

    public class Program
    {

        //public static void Main(string[] args)
        //{
        //   // Console.WriteLine("<b>Sample Input and Output 1:</b>");
        //    Console.WriteLine(" 1. Rectangle \n 2. Square \n 3. Circle \n Area Calculator \n--- Choose your shape ");
        //    Int32 choice = Int32.Parse(Console.ReadLine());

        //    switch (choice)
        //    {
        //        case 1:
        //            {
        //                Rectangle rect = new Rectangle();
        //                Console.WriteLine("Enter length and breadth:");
        //                Int32 l = Int32.Parse(Console.ReadLine());
        //                Int32 b = Int32.Parse(Console.ReadLine());
        //                Console.WriteLine("Area of Rectangle is:" +string.Format("{0:0.00}",rect.CalculateArea(l, b)));
        //                break;
        //            }
        //        case 2:
        //            {
        //                Square sq = new Square();
        //                Console.WriteLine("Enter side:");
        //                Int32 side = Int32.Parse(Console.ReadLine());
        //                Console.WriteLine("Area of Square is:" +string.Format("{0:0.00}", sq.CalculateArea(side)));
        //                break;
        //            }
        //        case 3:
        //            {
        //                Circle cir = new Circle();
        //                Console.WriteLine("Enter Radius:");
        //                Int32 radius = Int32.Parse(Console.ReadLine());
        //                Console.WriteLine("Area of Circle is:" +string.Format("{0:0.00}",cir.CalculateArea(radius)));
        //                break;
        //            }
                    
        //    }
        //    //Console.ReadLine();
        //}
    }
}
