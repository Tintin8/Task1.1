using System;
using Task1._1.Models.Base;

namespace Task1._1.Models
{
    public class Rent : Expense                                                                             // rent is a simple technique as its just added to the total expense as rent is a flat rate.
    {
        public void PrintLine()
        {
            Console.WriteLine("");
        }
        public override double Amount()
        {
            double cost = Rent.NewAmount();
            
            Expense.Expenses[7] = cost;
         
            return cost;
        }
    }
}
