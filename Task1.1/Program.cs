    using System;

namespace Task1._1
{
    class Program
    {
        static void Main(string[] args)                                                                     // main method that will call each created function as well as line breaks to keep unity amoung output.
        {                                                                                                   // no calculations will be kept in main as to make the app as scalable as possible


            greetings();
            Console.WriteLine("");
            monthlyIncome();
            tax();
            Console.WriteLine("");
            groceries();
            Console.WriteLine("");
            utilities();
            Console.WriteLine("");
            travelCosts();
            Console.WriteLine("");
            phoneBills();
            Console.WriteLine("");
            otherExpense();
            Console.WriteLine("");
            homePayment();
            Console.WriteLine("");
            approvalAlert();
            Console.WriteLine("");
            totalExpenses();
            Console.WriteLine();
            moneyLeft();

            ////Print array
            //foreach (var item in Expense.expenses)
            //{
            //    Console.WriteLine(item.ToString());
            //}






        }


        static void greetings()                                                                                             // method to welcome the user to the application
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Console.WriteLine("Welcome to the Budget Planner Application!");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Console.WriteLine("");

        }


        static void homePayment()                                                                   // method containing if statment that will determin via user input whether or not they will be renting , buying or not paying rent etc.
        {

            Console.WriteLine("Please type 1 if renting a home or 2 if you are paying off a home loan. ");
            Console.WriteLine("If neither press 3 else press anything else to exit");

            String answer = Console.ReadLine();
           

            if (answer.Equals("1"))                                                                 // if statement for determining living status costs
            {

                Console.WriteLine("Please enter how much is spent on rent per month: ");

                Rent amount = new Rent();
                amount.printLine();
                amount.Amount();

            }
            else if (answer.Equals("2"))
            {

               

                homeLoan amount = new homeLoan();

                amount.Amount();


            }

            else if (answer.Equals("3"))                                // if user chooses 3 the program continues with R0 paid for living expenses
            {

               //PLACEHOLDER
               
            }
            else 
            {

                System.Environment.Exit(0);

                
            }

        }

        static double monthlyIncome()                                                           // monthly income is stored here and called. *note the only value calculation as it is not an expense
        {

            Console.WriteLine("Please enter your monthly income");
            double answer = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Expense.expenses[0] = answer;                                                       // is stored at position [0] in the array as to help with unity
            return answer;
            

        }
        static void tax()                                                                       // method to call tax and its functions
        {

            Tax amount = new Tax();
            amount.printLine();
            amount.Amount();

        }
        static void groceries()                                                                 // method to call groceries and its functions
        {   

            Groceries amount = new Groceries();                                                 // instatiating the object
            amount.printLine();                                                                  // calling the method in the object
            amount.Amount();
           

        }
        static void utilities()                                                                  // method to call utilities and its functions
        {

            Utilities amount = new Utilities();
            amount.printLine();
            amount.Amount();
            

        }
        static void travelCosts()                                                                  // method to call travel and its functions
        {

            travelCosts amount = new travelCosts();
            amount.printLine();
            amount.Amount();
            
        }
        static void phoneBills()                                                                  // method to call cellular and its functions
        {

            phoneBills amount = new phoneBills();
            amount.printLine();
            amount.Amount();
            
        }
        static void otherExpense()                                                                  // method to call otherexpenses and its functions
        {

            otherExpense amount = new otherExpense();
            amount.printLine();
            amount.Amount();
            
        }
        static void approvalAlert()                                                                 // method that checks whether or not the monthly homeloan payment will be more than a 3rd of users rent and throws warning 
        {

            if (Expense.expenses[8]>(0.33*Expense.expenses[0]))                                         // checks if position [8]payment is greater that a 3rd of position [0] monthly income
            {

                Console.WriteLine("WARNING, YOUR HOME LOAN MONTHLY PAYMENT EXCEEDS A 3RD OF YOUR TOTAL MONTHLY INCOME THEREFORE YOU ARE UNLIKELY TO BE APPROVED FOR A LOAN"); // warning
               
            }

        }
        static void totalExpenses()                                 // method calculation total expenses by adding each from the array postion related to the expense
        {
           double totalExpense= Expense.expenses[1] + Expense.expenses[2]+ Expense.expenses[3] + Expense.expenses[4] + Expense.expenses[5] + Expense.expenses[6]+ Expense.expenses[7];
           Console.WriteLine("Your total expenses are : R"+totalExpense);
          
                }
        static void moneyLeft()                                         // method for calculating what is left after all expenses are deducted ( homeloan/rent included)
        {
            double totalExpense = Expense.expenses[1] + Expense.expenses[2] + Expense.expenses[3] + Expense.expenses[4] + Expense.expenses[5] + Expense.expenses[6] + Expense.expenses[7];

            double residual = (Expense.expenses[0]-totalExpense);                                               // income [0] minus total expenses [1]-[9]
            Console.WriteLine("Your total remaining value is :R"+residual);                                 

        }
    }
}