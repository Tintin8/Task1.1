using System;
using System.Collections.Generic;

namespace Task1._1.Models.Base
{
    public abstract class Expense                                                   // Original Abstract class from which all expense classes will inherit information from.
    {
        public static List<double> Expenses = new List<double>();                   // Array that stores in [0] stores the monthly income. and in [1]-[9] stores each relavent expense.
        public abstract double Amount();                                            // Method that every expense inherits. Since its abstract it has no body and as its a double, all furthur classes will return a double value.

        public static string EnterAmountSpent()                                     // Method for each class to inherit that prompts the user to enter information
        {
            return "Please enter amount spent ";
        }

        public static double NewAmount()                                            // Method that  collects a value from the user input to be used in later calculations
        {
            Console.WriteLine("");

            double value = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            return value;
        }
    }
}















        
