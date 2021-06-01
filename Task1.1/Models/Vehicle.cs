using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1._1.Models.Base;


namespace Task1._1.Models
{
    class Vehicle : Expense
    {

        public void PrintLine()                                                          // Just used to create a unified look in the presentation of the program
        {
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public override double Amount()                                                   // the amount() method prompts users for input regarding the home loan and uses the equation to figure out the monthly payments to be made.
        {
            Console.WriteLine("Please enter Make of vehicle");
            string make = Console.ReadLine();

            Console.WriteLine("Please enter model of vehicle");
            string model = Console.ReadLine();

            Console.WriteLine("Please enter purchase price of vehicle");
            double purchase_price = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter total deposit of car");
            double deposit = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter Interest rate (percentage seperated by , if necessary)");
            double interestRatePercentage = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter Estimated insurance premium)");
            double insurance = double.Parse(Console.ReadLine());


             double cost_After_Deposit = (purchase_price - deposit);            
             double repayMonths = 54;                                            //months value that will be used in the 
             double interestRateNumber = (interestRatePercentage / 100);       // percentage interest
            

             double  interest_Value=(cost_After_Deposit) * (interestRateNumber);
             double total_Owed = (interest_Value)+(cost_After_Deposit);



             double monthlyPayment = (total_Owed / repayMonths)+insurance;                                // Finds out monthly payment owed with provided information



            Console.WriteLine("Your total monthly payments for vehicle will be  ");
            Console.WriteLine("R" + monthlyPayment);
            Expense.Expenses.Add(monthlyPayment);
                                                      

            return monthlyPayment;                                                                      
        }
    }






}

