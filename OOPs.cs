using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Car
{
     abstract class Car
    {
        protected bool isSedan;
        protected string seats;

        public Car() { }

        public Car(bool isSedan, string seats)
        {
            this.isSedan = isSedan;
            this.seats = seats;
        }

        public bool getIsSedan()
        {
            return this.isSedan;
        }

        public string getSeats()
        {
            return this.seats;
        }

        abstract public string getMileage();

        public void printCar(string name)
        {
            Console.WriteLine("A {0} is{1} Sedan, is {2}-seater, and has a mileage of around {3}.",
            name,
            this.getIsSedan() ? "" : " not",
            this.getSeats(),
            this.getMileage());
        }
    }



    // Write your code here.

    /**
    *   WagonR class
    **/
   internal class WagonR : Car
    {
        string mileage;
       public WagonR(int carMileage) : base(false, "4")
        {
            this.mileage = carMileage + " kmpl";
        }
        public override string getMileage()
        {
            return mileage;
        }
    }
    /**
    *   HondaCity class
    **/
   internal class HondaCity : Car
    {
        int mileage;
        public HondaCity(int carMileage) : base(true, "4")
        {
            this.mileage = carMileage;
        }

        public override string getMileage()
        {
            return this.mileage + " kmpl";
        }
    }
      internal  class InnovaCrysta : Car
    {
        /**
        *   InnovaCrysta class
        **/
        int mileage;
        public InnovaCrysta(int carMileage) : base(true, "4")
        {
            this.mileage = carMileage;
        }
        public override string getMileage()
        {
            return this.mileage + " kmpl";
        }
    }

        class Solution
    {
        //static void Main(string[] args)
        //{
        //    int carType = Convert.ToInt32(Console.ReadLine().Trim());
        //    int carMileage = Convert.ToInt32(Console.ReadLine().Trim());
        //    if (carMileage >= 5 && carMileage <= 30)
        //    {
        //        if (carType == 0)
        //        {
        //            Car wagonR = new WagonR(carMileage);
        //            wagonR.printCar("WagonR");
        //        }

        //        else if (carType == 1)
        //        {
        //            Car hondaCity = new HondaCity(carMileage);
        //            hondaCity.printCar("HondaCity");
        //        }

        //        else if (carType == 2)
        //        {
        //            Car innovaCrysta = new InnovaCrysta(carMileage);
        //            innovaCrysta.printCar("InnovaCrysta");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Please enter <carType> number between 0 to 2");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Please enter mileage between 5 to 30");
        //    }
        //}
    }
}
