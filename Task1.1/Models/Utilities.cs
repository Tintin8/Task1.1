using System;
using Task1._1.Models.Base;

namespace Task1._1.Models
{
    public class Utilities : Expense
    {
        public void PrintLine()
        {
            Console.WriteLine("");
            Console.Write(Utilities.EnterAmountSpent() + "on utilites per month.");
            Console.WriteLine("");
        }
        
        public override double Amount()
        {
            double cost = Utilities.NewAmount();
            Expense.Expenses[3] = cost;
            return cost;
        }
    }
}
