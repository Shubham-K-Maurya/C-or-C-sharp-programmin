/* For a certain electrical circuit with an inductance L and resistance R, the damped natural frequency is given by
Frequency = √ (1 / LC – R2 / 4C2)
It is desired to study the variation of this frequency with C (capacitance). Write a program to calculate the frequency for different values of C starting from 0.01 to 0.1 in steps of 0.01
*/

using System;
class Ass1Q3
{
    private double Freq, L, R, C;
    public double GetFrequency()
    {
        Freq = Math.Sqrt((1 / L * C) - (R * R / 4 * C * C));
        return Freq;
    }
    public void setValues(double indctance, double resistance, double capacitance)
    {
        L = indctance;
        R = resistance;
        C = capacitance;
    }

}
class Program
{
    static void Main(string[] args)
    {
        Ass1Q3 ob = new Ass1Q3();
        Console.WriteLine("Enter the Inductance (in Henry): ");
        double inductance = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the Resistance (in Ohms): ");
        double resistance = Convert.ToDouble(Console.ReadLine());
        for (double C = 0.01; C <= 0.1; C = C + 0.01)
        {
            Console.Write("Frequency @ C = " + C + " is : ");
            ob.setValues(inductance, resistance, C);
            Console.WriteLine(ob.GetFrequency() + " Hz");

        }
        Console.ReadLine();
    }
}

