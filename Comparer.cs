//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Collections;

//namespace ConsoleApplication1
//{
//    public class State : IComparable
//    {
//        //string _name;
//        //Int64 _population;

//        public string name { get; set; }
//        public Int64 population { get; set; }

//        public State(string n, Int64 p)
//        {
//            this.name = n;
//            this.population = p;
//        }
   
    
//        // Nested class to do ascending sort on year property.
//        private class sortYearAscendingHelper : IComparer
//        {
//            int IComparer.Compare(object a, object b)
//            {
//                State c1 = (State)a;
//                State c2 = (State)b;

//                if (c1.population > c2.population)
//                    return 1;

//                if (c1.population < c2.population)
//                    return -1;

//                else
//                    return 0;
//            }
//        }


//        // Implement IComparable CompareTo to provide default sort order.
//        int IComparable.CompareTo(object obj)
//        {
//            State c = (State)obj;
//           // return Int64.CompareTo(population, c.population);
//            return population.CompareTo(c.population);
//        }

//        // Method to return IComparer object for sort helper.
//        public static IComparer<State> sortYearAscending()
//        {
//            return (IComparer<State>)new sortYearAscendingHelper();
//        }

//        private class sortMakeDescendingHelper : IComparer
//        {
//            int IComparer.Compare(object a, object b)
//            {
//                State c1 = (State)a;
//                State c2 = (State)b;
//                return c1.population.CompareTo(c2.population);
//            }
//        }
//    }

//    class host
//    {
//        //[STAThread]
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter number of states:");
//            int n = int.Parse(Console.ReadLine());
//            int j = 0;
//            List<State> arrayOfStates = new List<State>();
        
//            for (int i = 0; i < n; i++)
//            {
//                j = i + 1;
//                Console.WriteLine("Enter state " + j + " detail");
//                Console.WriteLine("Enter Name");
//                string name = Console.ReadLine();
//                Console.WriteLine("Enter Population");
//                Int64 p = Int64.Parse(Console.ReadLine());
                
//                 arrayOfStates.Add(new State(name, p)); 

//            }

//            State[] arrState = arrayOfStates.ToArray<State>();
        
//            // Demo ascending sort of numeric value with IComparer.
//            Array.Sort(arrState, State.sortYearAscending());
//            Console.WriteLine("State list after sort by population");
//            foreach (State s in arrState)
//            {
//                Console.WriteLine(s.name + "-" + s.population);
//            }
//            Console.ReadLine();
//        }
       
//    }
//    }