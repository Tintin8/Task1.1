﻿using System;
using Task1._1.Models.Base;

namespace Task1._1.Models
{
    public class OtherExpense : Expense
    {
        public void PrintLine()
        {
            Console.WriteLine("");
            Console.Write(OtherExpense.EnterAmountSpent() + "on other expenses per month.");
            Console.WriteLine("");
        }
        public override double Amount()
        {
            double cost = OtherExpense.NewAmount();
            Expense.Expenses[6] = cost;
            return cost;
        }
    }
}
