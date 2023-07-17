/* Given a list of marks ranging from 0 to 100.Write  aprogarm to compute and print the number of students who have obtained marks
      a.	In the range 81-100
      b.	In the range 61-80
      c.	In the range 41-61 and
      d.	In the range 0-40
*/

using System;
class Program
{
    static void Main(string[] args)
    {
        //  Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("Enter the number of students : ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] ar = new int[n];

        int c1 = 0, c2 = 0, c3 = 0, c4 = 0;

        for (int i = 0; i < n; i++)
        {
            // Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Enter the Marks Of Student : ");
            ar[i] = Convert.ToInt32(Console.ReadLine());

            if (ar[i] >= 81 && ar[i] <= 100)
                c1++;
            else if (ar[i] > 61 && ar[i] <= 80)
                c2++;
            else if (ar[i] >= 41 && ar[i] <= 61)
                c3++;
            else if (ar[i] >= 0 && ar[i] <= 40)
                c4++;
        }
        Console.WriteLine("No. of students who have obtained in range of 81-100 : " + c1);
        Console.WriteLine("No. of students who have obtained in range of 61-80 : " + c2);
        Console.WriteLine("No. of students who have obtained in range of 41-61 : " + c3);
        Console.WriteLine("No. of students who have obtained in range of 0-40 : " + c4);
        Console.ReadLine();
    }
}
