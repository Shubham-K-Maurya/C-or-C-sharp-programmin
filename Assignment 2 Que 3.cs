/* For a certain electrical circuit with an inductance L and resistance R, the damped natural frequency is given by
Frequency = √ (1 / LC – R2 / 4C2)
It is desired to study the variation of this frequency with C (capacitance). Write a program to calculate the frequency for different values of C starting from 0.01 to 0.1 in steps of 0.01

(Using Properties)
*/



using System;
class Ass2Q3
    {
        double freq, L, C, R;
        public double Inductance
        {
            get
            {
                return L;
            }
            set
            {
                L = value;
            }
        }
        public double Resistance
        {
            get
            {
                return R;
            }
            set
            {
                R = value;
            }
        }
        public double Capacitence
        {
            get
            {
                return C;
            }
            set
            {
                C = value;
            }
        }
        public double CalcFrequency()
        {

            freq = Math.Sqrt((1 / L * C) - R * R / 4 * C * C);
            return freq;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ass2Q3 ob = new Ass2Q3();
            Console.WriteLine("Enter the Inductance (in Henry): ");
            ob.Inductance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Resistance (in Ohms): ");
            ob.Resistance = Convert.ToDouble(Console.ReadLine());
            for (double C = 0.01; C <= 0.1; C = C + 0.01)
            {
                Console.Write("Frequency @ C = " + C + " is : ");
                ob.Capacitence=C;
                Console.WriteLine(ob.CalcFrequency() + " Hz");

            }
            Console.ReadLine();
        }
    }
