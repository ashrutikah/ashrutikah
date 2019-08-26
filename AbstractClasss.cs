//using System;
//namespace IndiabixConsoleApplication { class MyProgram { static void Main(string[] args) { int index = 6; int val = 44; int[] a = new int[5]; 
//    try { a[index] = val; } catch (IndexOutOfRangeException e)
//    { Console.Write("Index out of bounds "); } Console.Write("Remaining program"); Console.ReadLine();
//}
//}
//}

//using System;
//class sample { int i = 10; int j = 20; public void display() { Console.WriteLine("base method "); } }
//class sample1 : sample { public int s = 30; }
//class Program { static void Main(string[] args) { sample1 obj = new sample1(); Console.WriteLine("{0}, {1}, {2}", obj.i, obj.j, obj.s); obj.display(); Console.ReadLine(); } }

//using System;
//class sample { int i = 10; int j = 20; public void display() { Console.WriteLine("base method "); } }
//class sample1 : sample { public int s = 30; }
//class Program { static void Main(string[] args) { sample1 obj = new sample1(); Console.WriteLine("{0}, {1}, {2}", obj.i, obj.j, obj.s); obj.display(); Console.ReadLine(); } }

//using System;
//interface i1 { void fun(); } 
//interface i2 { void fun(); } 
//public class Sample :i1, i2 { void i1.fun() { Console.Write("i1.fun "); } void i2.fun() { Console.WriteLine("i2.fun"); } } 
//class Ca { static void Main(string[] args) { 
//    Sample obj = new Sample(); i1 i = (i1) obj; i.fun(); i2 ii = (i2) obj; ii.fun(); } }


//using System;
//namespace Ca 
//{ abstract class A { public int i ; public int j ; public abstract void display(); } 
//  class B: A { public int j = 18; public override void display() { this.j = 37; Console.WriteLine(i + " " + j); } } 
//    class Program { static void Main(string[] args) { B obj = new B(); obj.i = 10; obj.display(); Console.ReadLine(); } } 
//}


using System;

abstract public class Shape
{
    protected string _name { get; set; }
    public Shape(string name)
    {
        _name = name;
    }
    abstract public float CalculateArea();
}
public class Circle : Shape
{
    private int _radius;
    public Circle(string name, int radius):base(name)
    {
        this._radius = radius;
        base._name = name;
    }
    public override float CalculateArea()
    {
        //return (float)(Math.PI * _radius * _radius);
        return (float)(3.14 * _radius * _radius);
    }
}

public class Square : Shape
{
    private int _side;
    public Square(string name, int side): base(name)
    {
        this._side = side;
        base._name = name;
    }
    public override float CalculateArea()
    {
        return (float)(_side * _side);
    }
}

public class Rectangle : Shape
{
    private int _length;
    private int _width;
    public Rectangle(string name, int length, int width):base(name)
    {
        this._length = length;
        this._width = width;
        base._name = name;
    }
    public override float CalculateArea()
    {
        return (float)(_length * _width);
    }
}

public class Program
{

    //public static void Main()
    //{
    //    Console.WriteLine("Circle\nSquare\nRectangle\nEnter the shape name");
    //    string shapeInput = Console.ReadLine();
    //    switch (shapeInput)
    //    {
    //        case "Circle":
    //            {
    //                Console.WriteLine("Enter the radius");
    //                Int32 l = Int32.Parse(Console.ReadLine());
    //                Circle r = new Circle(shapeInput, l);
    //                float areaR = r.CalculateArea();
    //                //Console.WriteLine(areaR % 1);
    //                //Console.WriteLine((float)Math.Round(areaR, 2, MidpointRounding.ToEven));
    //                areaR = areaR % 1 > 0.4 ? (float)Math.Round(areaR, 2, MidpointRounding.ToEven) : (float)Math.Truncate(areaR);
    //                //areaR = (float)Math.Truncate(areaR);
    //                Console.WriteLine("Area of " + shapeInput + " is " + string.Format("{0:0.00}", areaR));
    //                break;
    //            }
    //        case "Square":
    //            {
    //                Console.WriteLine("Enter the side");
    //                Int32 l = Int32.Parse(Console.ReadLine());
    //                Square r = new Square(shapeInput, l);
    //                float areaR = r.CalculateArea();
    //                areaR = (float)Math.Floor(areaR);
    //                Console.WriteLine("Area of " + shapeInput + " is " + string.Format("{0:0.00}", areaR));
    //                break;
    //            }
    //        case "Rectangle":
    //            {
    //                Console.WriteLine("Enter the length");
    //                Int32 l = Int32.Parse(Console.ReadLine());
    //                Console.WriteLine("Enter the breadth");
    //                Int32 b = Int32.Parse(Console.ReadLine());
    //                Rectangle r = new Rectangle(shapeInput, l, b);
    //                float areaR = r.CalculateArea();
    //                areaR = (float)Math.Floor(areaR);
    //                Console.WriteLine("Area of " + shapeInput + " is " + string.Format("{0:0.00}",areaR));
    //                break;
    //            }
    //    }
    //   // Console.ReadLine();
    //}

}


