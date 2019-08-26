//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Collections;

//namespace ConsoleApplication1
//{
//    public class State
//    {
//        public string name { get; set; }
//        public Int64 population { get; set; }

//        public State(string n, Int64 p)
//        {
//            this.name = n;
//            this.population = p;
//        }

//    }

//    public class StateComparer : IComparer<State>
//    {
//        public int Compare(State a, State b)
//        {
//            State c1 = (State)a;
//            State c2 = (State)b;

//            if (c1.population > c2.population)
//                return 1;

//            if (c1.population < c2.population)
//                return -1;

//            else
//                return 0;
//        }

//    }
//        // Nested class to do ascending sort on year property.
      
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

//                arrayOfStates.Add(new State(name, p));

//            }

//            StateComparer sc = new StateComparer();
//            arrayOfStates.Sort(sc);
//            Console.WriteLine("State list after sort by population");
//            foreach (State s in arrayOfStates)
//            {
//                Console.WriteLine(s.name + "-" + s.population);
//            }
//            //Console.ReadLine();
//        }

//    }
//}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Programssss { static void Main(string[] args) { int[] nums = { 1, -2, 3, 0, -4, 5 }; var posNums = nums.Where(n => n < 10).Select(r => r % 3); Console.Write("The values in nums: "); foreach (int i in posNums) Console.Write(i + " "); Console.WriteLine(); Console.ReadLine(); } }