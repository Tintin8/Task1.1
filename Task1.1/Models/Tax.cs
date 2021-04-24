using System;
using Task1._1.Models.Base;

namespace Task1._1.Models
{
    public class Tax : Expense                                                      // First class that inherits from the expense class above.
    {
        public void PrintLine()                                                     // Method that adds info to the next value reported by the user.
        {
            Console.WriteLine("");

            Console.WriteLine(EnterAmountSpent() + "on tax per month.");     // appended text to value
            
            Console.WriteLine("");
        }

        public override double Amount()                                             // Overrides the method found in Expense and collects user input while storing it into the array in slot [1]
        {
            double cost = NewAmount();

            Expenses[1] = cost;

            return cost;                                                            // Since the amount() in expense is a double, the inherited class returns a value
        }
    }
}
