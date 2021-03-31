    using System;

namespace Task1._1
{
    class Program
    {
        static void Main(string[] args)
        {

            greetings();
           





            
            groceries amount = new groceries();
            amount.Amount();



            //utilities amountUtil = new utilities();
            //amountUtil.Amount();

            //travelCosts amountTravel = new travelCosts();
            //amountTravel.Amount();

            //phoneBills amountPhone = new phoneBills();
            //amountPhone.Amount();

            //otherExpense amountOther = new otherExpense();
            //amountOther.Amount();

            
         






        }
        static void greetings()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Console.WriteLine("Welcome to the Budget Planner Application!");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
           
        }


        static void placeholer1()
        {

            Console.WriteLine("Please type 1 if renting a home or 2 if you are paying off a home loan? : ");

            String answer = Console.ReadLine();


            if (answer.Equals("1"))
            {

                Console.WriteLine("Please enter how much is spent on rent per month: ");


            }
            else if (answer.Equals("2"))
            {

                Console.WriteLine("Hello");

            }

            else 
            {

                Environment.Exit(0);

            } 
                
        }

static void  monthlyIncome()
       {
           Console.WriteLine("Please enter your total monthly income");
            
            
        }

        static void groceries()
        {
            Console.WriteLine("Please enter amount spent on groceries: ");


        }



    }
}
