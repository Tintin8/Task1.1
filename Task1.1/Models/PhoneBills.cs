using System;
using Task1._1.Models.Base;

namespace Task1._1.Models
{
    public class PhoneBills : Expense
    {
        public void PrintLine()
        {
            Console.WriteLine("");

            Console.Write(PhoneBills.EnterAmountSpent() + "on phone billing per month.");

            Console.WriteLine("");
        }

        public override double Amount()
        {
            double cost = PhoneBills.NewAmount();
            
            Expense.Expenses[5] = cost;
         
            return cost;
        }
    }
}
