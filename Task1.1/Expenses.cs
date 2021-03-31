using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1
{
public abstract class Expense
    {
        string name;
        public abstract double Amount();
        







        
    }

    public class groceries : Expense

    {
        
        public override double Amount()
        {
           
           222222
            

        }
    }

    public class utilities : Expense

    {
        public override void Amount()
        {
            Console.WriteLine("Please enter amount spent on utilities ( Water & Lights ) : ");
            double value = double.Parse(Console.ReadLine());
            //Console.WriteLine("You spend " + value + " on utilities a month");
            
        }
    }


    public class travelCosts : Expense

    {
        public override void Amount()
        {
            Console.WriteLine("Please enter amount spent on travel costs (Petrol etc.) : ");
            double value = double.Parse(Console.ReadLine());
            //Console.WriteLine("You spend " + value + " on travelCosts a month");
        }
    }

    public class phoneBills : Expense

    {
        public override void Amount()
        {

            Console.WriteLine("Please enter amount spent on Cellular and telephonic calls:  ");
            double value = double.Parse(Console.ReadLine());
        }
    }

    public class otherExpense : Expense

    {
        public override void Amount()
        {
            Console.WriteLine("Please enter amount spent on any other catagories: ");
            double value = double.Parse(Console.ReadLine());
        }
    }

    public class rent : Expense

    {
        public override void Amount()
        {
            Console.WriteLine("Please enter amount spent on rent: ");
            double value = double.Parse(Console.ReadLine());
        }
    }
    //public class placeholder : Expense

    //{
    //    public override void Amount()
    //    {


    //    }
    //}
    public class homeLoan : Expense

    {
        public override void Amount()
        {
            Console.WriteLine("Please fill in the required information: ");

        }
    }

}
