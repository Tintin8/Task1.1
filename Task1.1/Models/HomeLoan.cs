using System;
using Task1._1.Models.Base;

namespace Task1._1.Models
{
    public class HomeLoan : Expense                                                      // homeloan has its own calculations that pertain to its specific situation 
    {
        public void PrintLine()                                                          // Just used to create a unified look in the presentation of the program
        {
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public override double Amount()                                                   // the amount() method prompts users for input regarding the home loan and uses the equation to figure out the monthly payments to be made.
        {
            Console.WriteLine("Please enter Purchase price of property");
            double propertyPrice = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter Total deposit");
            double totalDeposit = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter Interest rate (percentage seperated by , if necessary)");
            double interestRatePercentage = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter Number of months to repay");
            Console.WriteLine("Please check the number of months is correct(240-360)");

            double repayMonths = double.Parse(Console.ReadLine());                                          // Collects the months value that will be used in the calculation
            int months = Convert.ToInt32(repayMonths);

            double interestRateNumber = interestRatePercentage / 100;                                       // interest rate from user in decimal or int 12/2,3 etc divided by 100 to get a double to be used later.
            double priceLessDeposit = propertyPrice - totalDeposit;                                         // price with deposit sabtracted in order to discover the amount left to be paid
            double numberYears = repayMonths / 12;                                                         // number of years to pay out calculated by total months /12
            double total = priceLessDeposit * (1 + interestRateNumber * numberYears);                       // total price of payment is price minus deposit times ( one + interest rate times number of years)


            double monthlyPayment = total / repayMonths;                                                    // Finds out monthly payment owed with provided information
            Console.WriteLine("Your total monthly payments are: ");
            Console.WriteLine("R" + monthlyPayment);
            Expense.Expenses[8] = monthlyPayment;                                                          // stores final amount per month into array slot 8

            return monthlyPayment;                                                                        // returns final monthlypayment that will be added to other monthly payments in array
        }
    }
}
