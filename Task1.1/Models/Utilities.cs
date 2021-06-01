using System;
using Task1._1.Models.Base;

namespace Task1._1.Models
{
    public class Utilities : Expense
    {
        public void PrintLine()
        {
            Console.WriteLine("");
            Console.Write(EnterAmountSpent() + "on utilites per month.");
            Console.WriteLine("");
        }
        
        public override double Amount()
        {
            double cost = NewAmount();
            Expense.Expenses.Add(cost);
            //Expenses[3] = cost;
            return cost;
        }
    }
}
