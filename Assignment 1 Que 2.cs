/* In Inventory Management, the Economic Order Quantity for a single item is given by
EOQ=√ (2*demand rate*setup costs)/holding cost per item per unit time
	And the optimal Time between orders:
TBO=√ (2*setup cost)/ (demand rate *holding cost per item per unit time)
Write a program to compute EQ and TBO, given demand rate (items per unit time), costs (per order) and the holding cost (per item per unit time)
*/


using System;
class Ass1Q2
{
    private double EOQ, TBO, demrt, setcst, holdcst;
    public double GetEOQ()
    {
        EOQ = Math.Sqrt((2 * demrt * setcst) / holdcst);
        return EOQ;
    }
    public double GetTBO()
    {
        TBO = Math.Sqrt((2 * setcst) / demrt * holdcst);
        return TBO;
    }
    public void SetVar(double dmndrate, double setcost, double holdcost)
    {
        demrt = dmndrate;
        setcst = setcost;
        holdcst = holdcost;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Ass1Q2 ob = new Ass1Q2();
        Console.WriteLine("Enter the demand rate (in items per unit time) : ");
        double demandrt = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the setup costs (in per order) : ");
        double setupcst = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the holding cost (in per items per unit time) : ");
        double holdcst = Convert.ToDouble(Console.ReadLine());
        ob.SetVar(demandrt, setupcst, holdcst);
        double EOQ = ob.GetEOQ();
        double TBO = ob.GetTBO();
        Console.WriteLine("Economic Order Quantity = " + EOQ);
        Console.WriteLine("Time Between Orders = " + TBO);
        Console.ReadLine();

    }
}
