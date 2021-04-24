using System;
using Task1._1.Models.Base;

namespace Task1._1.Models
{
    public class Groceries : Expense                                                // each class is the same from here until home loans as they all inherit the classes from Expense
    {
        public void PrintLine()
        {
            Console.WriteLine("");
            Console.WriteLine(Groceries.EnterAmountSpent() + "on groceries per month.");
            Console.WriteLine("");
        }

        public override double Amount()
        {
            double cost = Groceries.NewAmount();
            Expense.Expenses[2] = cost;
            return cost;
        }
    }
}
