    using System;
using Task1._1.Models;
using Task1._1.Models.Base;

namespace Task1._1
{
    class Program
    {
        static void Main(string[] args)                                                                     // main method that will call each created function as well as line breaks to keep unity amoung output.
        {                                                                                                   // no calculations will be kept in main as to make the app as scalable as possible
            Greetings();
            Console.WriteLine("");

            MonthlyIncome();
            Tax();
            Console.WriteLine("");

            Groceries();
            Console.WriteLine("");

            Utilities();
            Console.WriteLine("");

            TravelCosts();
            Console.WriteLine("");

            PhoneBills();
            Console.WriteLine("");

            OtherExpense();
            Console.WriteLine("");

            HomePayment();
            Console.WriteLine("");

            ApprovalAlert();
            Console.WriteLine("");

            TotalExpenses();
            Console.WriteLine();

            MoneyLeft();

            //Print array
            //Expense.Expenses.ForEach(item => Console.WriteLine(item.ToString()));
        }


        static void Greetings()                                                                                             // method to welcome the user to the application
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Console.WriteLine("Welcome to the Budget Planner Application!");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
        }


        static void HomePayment()                                                                   // method containing if statment that will determin via user input whether or not they will be renting , buying or not paying rent etc.
        {
            Console.WriteLine("Please type 1 if renting a home or 2 if you are paying off a home loan. ");

            Console.WriteLine("If neither press 3 else press anything else to exit");

            var answer = Console.ReadLine();

            if (answer.Equals("1"))                                                                 // if statement for determining living status costs
            {
                Console.WriteLine("Please enter how much is spent on rent per month: ");

                Rent amount = new Rent();

                amount.PrintLine();

                amount.Amount();

            }
            else if (answer.Equals("2"))
            {
                var amount = new HomeLoan();

                amount.Amount();
            }

            else if (answer.Equals("3"))                                // if user chooses 3 the program continues with R0 paid for living expenses
            {
               //PLACEHOLDER
            }
            else 
            {
                Environment.Exit(0);
            }
        }

        static double MonthlyIncome()                                                           // monthly income is stored here and called. *note the only value calculation as it is not an expense
        {

            Console.WriteLine("Please enter your monthly income");
            double answer = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Expense.Expenses[0] = answer;                                                       // is stored at position [0] in the array as to help with unity
            return answer;
            

        }

        static void Tax()                                                                       // method to call tax and its functions
        {
            var amount = new Tax();

            amount.PrintLine();

            amount.Amount();
        }
        static void Groceries()                                                                 // method to call groceries and its functions
        {   
            var amount = new Groceries();                                                 // instatiating the object
            
            amount.PrintLine();                                                                  // calling the method in the object
           
            amount.Amount();
        }

        static void Utilities()                                                                  // method to call utilities and its functions
        {
            var amount = new Utilities();
            
            amount.PrintLine();
            
            amount.Amount();
        }

        static void TravelCosts()                                                                  // method to call travel and its functions
        {
            var amount = new TravelCosts();

            amount.PrintLine();

            amount.Amount();
        }

        static void PhoneBills()                                                                  // method to call cellular and its functions
        {
            var amount = new PhoneBills();

            amount.PrintLine();

            amount.Amount();
        }

        static void OtherExpense()                                                                  // method to call otherexpenses and its functions
        {
            var amount = new OtherExpense();

            amount.PrintLine();

            amount.Amount();
        }

        static void ApprovalAlert()                                                                 // method that checks whether or not the monthly homeloan payment will be more than a 3rd of users rent and throws warning 
        {
            if (Expense.Expenses[8]>(0.33*Expense.Expenses[0]))                                         // checks if position [8]payment is greater that a 3rd of position [0] monthly income
                Console.WriteLine("WARNING, YOUR HOME LOAN MONTHLY PAYMENT EXCEEDS A 3RD OF YOUR TOTAL MONTHLY INCOME THEREFORE YOU ARE UNLIKELY TO BE APPROVED FOR A LOAN"); // warning
        }

        static void TotalExpenses()                                 // method calculation total expenses by adding each from the array postion related to the expense
        {
           double totalExpense= Expense.Expenses[1] + Expense.Expenses[2]+ Expense.Expenses[3] + Expense.Expenses[4] + Expense.Expenses[5] + Expense.Expenses[6]+ Expense.Expenses[7];

           Console.WriteLine("Your total expenses are : R"+totalExpense);
        }

        static void MoneyLeft()                                         // method for calculating what is left after all expenses are deducted ( homeloan/rent included)
        {
            double totalExpense = Expense.Expenses[1] + Expense.Expenses[2] + Expense.Expenses[3] + Expense.Expenses[4] + Expense.Expenses[5] + Expense.Expenses[6] + Expense.Expenses[7];

            double residual = (Expense.Expenses[0]-totalExpense);                                               // income [0] minus total expenses [1]-[9]
           
            Console.WriteLine("Your total remaining value is :R"+residual);                                 
        }
    }
}