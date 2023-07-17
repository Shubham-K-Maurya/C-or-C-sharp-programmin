/* A set of two linear equations with two unknowns x¬1 and x2 is given below:
Ax1+bx2=m
Cx2+dx2=n
   	The set has  a unique solution
		X1= (md+bn)/(ad-cb)
		X2= (na+mc)/(ad-cb)
Provided the denominator ad-cb is not equal to zero. Write a program that will read the values of constants a, b, c, d, m and n and compute the values of x and x2.An appropriate message should be printed if ad-cb=0
*/

using System;
 class Ass1Que4
    {
        private double X1,X2,A,B,C,D,M,N;
        public double GetX1()
        {
            if ((A * D - C * B) == 0)
                Console.WriteLine("Sorry! Unable to Find X1 because AD-BC=0");
            else
            {
                X1 = (M * D + B * N) / (A * D - C * B);   
            }
            return X1;
        }
        public double GetX2()
        {
            if ((A * D - C * B) == 0)
                Console.WriteLine("Sorry! Unable to Find X1 because AD-BC=0");
            else
            {
                X2 = (N * A + C * M) / (A * D - C * B);
            }
            return X2;
        }
        public void SetVariables(double a,double b,double c,double d,double m,double n)
        {
            A= a;
            B = b;
            C= c;
            D= d;
            M= m;
            N= n;

        }
    }
  class Program
    {
        static void Main(string[] args)
        {
            Ass1Que4 ob = new Ass1Que4();
            Console.WriteLine("Write the 1st linear equation i.e Ax1+Bx2=M ");
            Console.WriteLine("Write value of A : ");
            double a=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write value of B : ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write value of M : ");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Equation 1st is : " + a + "x1+" + b + "x2=" + m);
            Console.WriteLine();
            Console.WriteLine("Write the 2nd linear equation i.e Cx1+Dx2=N ");
            Console.WriteLine("Write value of C : ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write value of D : ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write value of n : ");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Equation 2nd is :  " + c + "x1+" + d + "x2=" + n);
            Console.WriteLine();
            ob.SetVariables(a,b,c,d,m,n);
            double x1 = ob.GetX1();
            Console.WriteLine("The value of X1 is : "+x1);
            double x2 = ob.GetX2();
            Console.WriteLine("The value of X2 is : " + x2);
            Console.ReadLine();
        }
    }
