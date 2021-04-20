using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1
{
    public abstract class Expense                                                   // Original Abstract class from which all expense classes will inherit information from.
    {


        public static double[] expenses = new double[9];                            // Array that stores in [0] stores the monthly income. and in [1]-[9] stores each relavent expense.
        public abstract double Amount();                                            // Method that every expense inherits. Since its abstract it has no body and as its a double, all furthur classes will return a double value.

        public static string enterAmountSpent()                                     // Method for each class to inherit that prompts the user to enter information
        {
            string enterAmount = "Please enter amount spent ";
            return enterAmount;                                                                 



        }
        public static double newAmount()                                            // Method that  collects a value from the user input to be used in later calculations
        {

            Console.WriteLine("");
            double value = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            return value;


        }

        

    }
    public class Tax : Expense                                                      // First class that inherits from the expense class above.

    {

        public void printLine()                                                     // Method that adds info to the next value reported by the user.
        {

            Console.WriteLine("");
            Console.WriteLine(Tax.enterAmountSpent() + "on tax per month.");        // appended text to value
            Console.WriteLine("");


        }
        public override double Amount()                                             // Overrides the method found in Expense and collects user input while storing it into the array in slot [1]
        {

            double cost = Tax.newAmount();
            Expense.expenses[1] = cost;
            return cost;                                                            // Since the amount() in expense is a double, the inherited class returns a value

        }



    }
    public class Groceries : Expense                                                // each class is the same from here until home loans as they all inherit the classes from Expense

    {

        public void printLine()
        {

            Console.WriteLine("");
            Console.WriteLine(Groceries.enterAmountSpent() + "on groceries per month.");
            Console.WriteLine("");

        }
        public override double Amount()
        {

            double cost = Groceries.newAmount();
            Expense.expenses[2] = cost;
            return cost;

        }



    }
    public class Utilities : Expense

    {
        public void printLine()
        {

            Console.WriteLine("");
            Console.Write(Utilities.enterAmountSpent() + "on utilites per month.");
            Console.WriteLine("");




        }
        public override double Amount()
        {
            double cost = Utilities.newAmount();
            Expense.expenses[3] = cost;
            return cost;

        }
    }
    public class travelCosts : Expense

    {
        public void printLine()
        {

            Console.WriteLine("");
            Console.Write(travelCosts.enterAmountSpent() + "on travel costs per month.");
            Console.WriteLine("");
        }
        public override double Amount()
        {
            double cost = travelCosts.newAmount();
            Expense.expenses[4] = cost;
            return cost;

        }
    }
    public class phoneBills : Expense

    {
        public void printLine()
        {

            Console.WriteLine("");
            Console.Write(phoneBills.enterAmountSpent() + "on phone billing per month.");
            Console.WriteLine("");
        }
        public override double Amount()
        {
            double cost = phoneBills.newAmount();
            Expense.expenses[5] = cost;
            return cost;

        }
    }
    public class otherExpense : Expense

    {
        public void printLine()
        {
            Console.WriteLine("");
            Console.Write(otherExpense.enterAmountSpent() + "on other expenses per month.");
            Console.WriteLine("");
        }
        public override double Amount()
        {
            double cost = otherExpense.newAmount();
            Expense.expenses[6] = cost;
            return cost;

        }


    }
    public class Rent : Expense                                                                             // rent is a simple technique as its just added to the total expense as rent is a flat rate.

    {
        public void printLine()
        {
            Console.WriteLine("");
           
            
        }
        public override double Amount()
        {
            double cost = Rent.newAmount();
            Expense.expenses[7] = cost;
            return cost;

        }


    }
    public class homeLoan : Expense                                                      // homeloan has its own calculations that pertain to its specific situation 

    {

        public void printLine()                                                          // Just used to create a unified look in the presentation of the program
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
            Expense.expenses[8] = monthlyPayment;                                                          // stores final amount per month into array slot 8

             return monthlyPayment;                                                                        // returns final monthlypayment that will be added to other monthly payments in array
                                


           



        }
       

    }



    }















        
