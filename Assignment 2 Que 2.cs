/* In Inventory Management, the Economic Order Quantity for a single item is given by
EOQ=√ (2*demand rate*setup costs)/holding cost per item per unit time
	And the optimal Time between orders:
TBO=√ (2*setup cost)/ (demand rate *holding cost per item per unit time)
Write a program to compute EoQ and TBO, given demand rate (items per unit time), costs (per order) and the holding cost (per item per unit time)

(Using Properties)
*/

using System;
class Ass2Q2
    {
        double EoQ, TBO, setupcst, dmndrte, hldcst;
        public double SetUpCost
        {
            get
            {
                return setupcst;
            }
            set
            {
                setupcst = value;
            }
        }
        public double DemandRate
        {
            get
            {
                return dmndrte;
            }
            set
            {
                dmndrte = value;
            }
        }
        public double HoldCost
        {
            get
            {
                return hldcst;
            }
            set
            {
                hldcst = value;
            }
        }
        public double CalcEoQ()
        {

            EoQ =Math.Sqrt((2*dmndrte*setupcst)/hldcst) ;
            return EoQ;
        }
        public double CalcTBO()
        {

            TBO = Math.Sqrt((2 * setupcst) / dmndrte * hldcst);
            return TBO;
        } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ass2Q2 ob= new Ass2Q2();
            Console.WriteLine("Enter the Value of Demand Rate(in items per unit time) : ");
            ob.DemandRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of setup cost(in per order) : ");
            ob.SetUpCost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of holding cost(in per item per unit time) : ");
            ob.HoldCost = Convert.ToDouble(Console.ReadLine());

          Console.WriteLine("Entered Details are : ");
            Console.WriteLine("Demand rate : " + ob.DemandRate + " , Setup Cost : " + ob.SetUpCost + " , Hold Cost : " + ob.HoldCost);
            double EOQ = ob.CalcEoQ();
            double TBO = ob.CalcTBO();
            Console.WriteLine("Economic Order Quantity for single item : " + EOQ);
            Console.WriteLine("Optimal Time Between Orders : " + TBO);
            Console.ReadLine();

        }
    }
