/* The total distance travelled by a vehicle in t seconds is given by
		    Distance=ut+ (at2)/2
Where u is the initial velocity (meter per second) a is acceleration (meter per second2). Write a program to evaluate the distance travel at regular intervals of time, given the value of u and a. The program should provide the flexibility to the user to select his own time intervals and repeat the calculations for different value of u and a.

(Using properties)
*/

using System;
    class Ass2Q1
    {
        double dist, u, a, t;
        public double InitVel { 
            get
            {
                return u;
            }
            set
            {
                u = value;
            }
        }
        public double Acceleration
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public double Time
        {
            get
            {
                return t;
            }
            set
            {
                t = value;
            }
        }
        public double CalcDistance() 
        { 
          
            dist = u * t + a * t * t / 2;
            return dist;
        }  
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ass2Q1 ob = new Ass2Q1();
            Console.WriteLine("Enter the Value of Initial Velocity : ");
            ob.InitVel = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of time taken : ");
            ob.Time=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of acceleration : ");
            ob.Acceleration = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entered Details are : ");
            Console.WriteLine("u="+ob.InitVel+" m/s , a="+ob.Acceleration+" m/s2 , t="+ob.Time+" s");
            double Distance=ob.CalcDistance();
            Console.WriteLine("Distance Travelled = " + Distance+" m");
            Console.ReadLine();

        }
    }

