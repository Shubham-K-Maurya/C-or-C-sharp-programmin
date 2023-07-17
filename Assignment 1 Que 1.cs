/* The total distance travelled by a vehicle in t seconds is given by
		    Distance=ut+ (at2)/2
Where u is the initial velocity (meter per second) a is acceleration (meter per second2). Write a program to evaluate the distance travel at regular intervals of time, given the value of u and a. The program should provide the flexibility to the user to select his own time intervals and repeat the calculations for different value of u and a.
*/


using System;

 class Ass1Q1
    {
        private double distance, u, a, t;

        public double GetDistance()
        {
            distance = ((u * t) + (a * t * t) / 2);
            return distance;
        }
        public void SetVariables(double initvel, double acc, double time)
        {
            u = initvel;
            a = acc;
            t = time;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ass1Q1 ob = new Ass1Q1();
            Console.WriteLine("Enter the initial velocity (in m/s): ");
            double initvel = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the acceleration (in m/s^2): ");
            double acc = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the time (in sec): ");
            double time = Convert.ToDouble(Console.ReadLine());
            ob.SetVariables(initvel, acc, time);
            double dist = ob.GetDistance();
            Console.Write("Distance Travelled = " + dist + " m");
            Console.ReadLine();
        }
    }
