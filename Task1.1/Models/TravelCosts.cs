﻿using System;
using Task1._1.Models.Base;

namespace Task1._1.Models
{
    public class TravelCosts : Expense
    {
        public void PrintLine()
        {
            Console.WriteLine("");

            Console.Write(TravelCosts.EnterAmountSpent() + "on travel costs per month.");

            Console.WriteLine("");
        }
        public override double Amount()
        {
            double cost = TravelCosts.NewAmount();

            Expense.Expenses[4] = cost;

            return cost;

        }
    }
}
