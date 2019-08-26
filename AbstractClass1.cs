using System;
namespace ConsoleApplication1
{
    class Program123
    {
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter the 2 numbers");
        //    int a = int.Parse(Console.ReadLine());
        //    int b = int.Parse(Console.ReadLine());
        //    int c = 0;
        //    try
        //    {
        //        c = a / b;
        //        Console.WriteLine("The quotient of "+ a +"/" +b  +"= " + c);
        //    }
        //    //catch (ArithmeticException exp)
        //    //{
        //    //    Console.WriteLine(exp.Message);
        //    //}
        //    catch (DivideByZeroException exp1)
        //    {
        //        string msg = exp1.Message;
        //        Console.WriteLine("DivideByZeroException caught Inside finally block");
        //    }
        //    finally {
        //        Console.WriteLine("Inside finally block");
        //    }
        //    Console.WriteLine(c);
        //    //Console.ReadLine();
        //}
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace ConsoleApplication1
//{
//    abstract public class Vehicle
//    {
//        public string _make { get; set; }
//        public string _vehicleNumber { get; set; }
//        public string _fuelType { get; set; }
//        public int _fuelCapacity { get; set; }
//        public int _cc { get; set; }
//        public Vehicle(string make, string vehicleNumber, string fuelType, int fuelCapacity, int cc)
//        {
//            _make = make;
//            _vehicleNumber = vehicleNumber;
//            _fuelCapacity = fuelCapacity;
//            _fuelType = fuelType;
//            _cc = cc;
//        }
//        public void DisplayMake()
//        {
//            Console.WriteLine("***" + _make + "***");
//        }
//        public void DisplayBasicInfo()
//        {
//            Console.WriteLine("---Basic Information---\nVehicle Number:" + _vehicleNumber);
//            Console.WriteLine("Fuel Capacity:" + _fuelCapacity);
//            Console.WriteLine("Fuel Type:" + _fuelType);
//            Console.WriteLine("CC:" + _cc);
//        }
//        abstract public void DisplayDetailInfo();
//    }
//    public class TwoWheeler : Vehicle
//    {
//        private bool _kickStartAvailable;
//        public TwoWheeler(bool kickStartAvailable, string make, string vehicleNumber, string fuelType, int fuelCapacity, int cc)
//            : base(make, vehicleNumber, fuelType, fuelCapacity, cc)
//        {
//            _kickStartAvailable = kickStartAvailable;
//        }
//        public override void DisplayDetailInfo()
//        {
//            Console.WriteLine("---Detail Information---\nKick Start Available:" + (_kickStartAvailable == true ? "YES" : "NO"));
//        }
//    }
//    public class FourWheeler : Vehicle
//    {
//        private string _audioSystem;
//        private int _numberOfDoors;
//        public FourWheeler(string audioSystem, int numberOfDoors, string make, string vehicleNumber, string fuelType, int fuelCapacity, int cc)
//            : base(make, vehicleNumber, fuelType, fuelCapacity, cc)
//        {
//            _audioSystem = audioSystem;
//            _numberOfDoors = numberOfDoors;
//        }
//        public override void DisplayDetailInfo()
//        {
//            Console.WriteLine("---Detail Information---\nAudio System:" + _audioSystem + "\nNumber of Doors:" + _numberOfDoors);
//        }
//    }

//    public class Program1
//    {

//        //public static void Main()
//        //{
//        //    Console.WriteLine("1.Four Wheeler\n2.Two Wheeler\nEnter Vehicle Type:");
//        //    int vehicleInput = int.Parse(Console.ReadLine());
//        //    switch (vehicleInput)
//        //    {
//        //        case 1:
//        //            {
//        //                Console.WriteLine("Vehicle Make:");
//        //                string make = Console.ReadLine();
//        //                Console.WriteLine("Vehicle Number:");
//        //                string number = Console.ReadLine();
//        //                Console.WriteLine("Fuel Type:\n1.Petrol\n2.Diesel");
//        //                string type = int.Parse(Console.ReadLine()) == 1 ? "Petrol" : "Diesel";
//        //                Console.WriteLine("Fuel Capacity:");
//        //                int capacity = int.Parse(Console.ReadLine());
//        //                Console.WriteLine("Engine CC:");
//        //                int cc = int.Parse(Console.ReadLine());
//        //                Console.WriteLine("Audio System:");
//        //                string aSystem = Console.ReadLine();
//        //                Console.WriteLine("Number of Doors:");
//        //                int nDoors = int.Parse(Console.ReadLine());
//        //                FourWheeler tw = new FourWheeler(aSystem, nDoors, make, number, type, capacity, cc);
//        //                tw.DisplayMake();
//        //                tw.DisplayBasicInfo();
//        //                tw.DisplayDetailInfo();
//        //                break;
//        //            }
//        //        case 2:
//        //            {
//        //                Console.WriteLine("Vehicle Make:");
//        //                string make = Console.ReadLine();
//        //                Console.WriteLine("Vehicle Number:");
//        //                string number = Console.ReadLine();
//        //                Console.WriteLine("Fuel Type:\n1.Petrol\n2.Diesel");
//        //                string type = int.Parse(Console.ReadLine()) == 1 ? "Petrol" : "Diesel";
//        //                Console.WriteLine("Fuel Capacity:");
//        //                int capacity = int.Parse(Console.ReadLine());
//        //                Console.WriteLine("Engine CC:");
//        //                int cc = int.Parse(Console.ReadLine());
//        //                Console.WriteLine("Kick Start Available(yes/no):");
//        //                bool kickSTart = Console.ReadLine() == "yes" ? true : false;
//        //                //Console.WriteLine(kickSTart);
//        //                TwoWheeler tw = new TwoWheeler(kickSTart, make, number, type, capacity, cc);
//        //                tw.DisplayMake();
//        //                tw.DisplayBasicInfo();
//        //                tw.DisplayDetailInfo();
//        //                break;
//        //            }
//        //    }
//        //}

//    }
//}
