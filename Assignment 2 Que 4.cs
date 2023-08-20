/*
Write a program to implement a 2D array using indexers. The indexing should be done with indexers.
*/

using System;
class Ass2Q4
    {
        int a,b;
        string[,] arr = new string[5,5];

        public string this[int index1,int index2]
        {
            get
            {
                return arr[index1,index2];
            }
            set
            {
                arr[index1,index2] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ass2Q4 ob = new Ass2Q4();
            Console.WriteLine("Enter the size of the matrix i.e., Rows and Column : ");
            int m=  Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i < m; i++)
            {
                for(int j=0; j < n; j++)
                {
                    Console.Write("Enter your element @ position (" + (i+1) + "," + (j+1) + ") : ");
                    ob[i, j]=Console.ReadLine();
                }
            }
            Console.WriteLine("Enterd array list is : ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(ob[i,j]+"\t");

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }

