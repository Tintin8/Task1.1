using System;
using Task1._1.Models.Base;

namespace Task1._1.Models
{
    public class PhoneBills : Expense
    {
        public void PrintLine()
        {
            Console.WriteLine("");

            Console.Write(EnterAmountSpent() + "on phone billing per month.");

            Console.WriteLine("");
        }

        public override double Amount()
        {
            double cost = NewAmount();

            Expenses[5] = cost;
         
            return cost;
        }
    }
}
