using System.Collections.Generic;
using System.Linq;

namespace SplitWise
{
    public class Expense
    {
        public double AmountSpent { get; set; }

        public List<Person> Participants { get; set; }

        public Person SpentBy { get; set; }

        public Expense()
        {
            SpentBy = new SplitWise.Person();
        }



        public void AddExpense(Expense expense)
        {
            SpentBy.Amount = SpentBy.Amount + expense.AmountSpent;
            double dividedAmount = expense.AmountSpent / expense.Participants.Count();

            for (int i = 0; i < expense.Participants.Count; i++)
            {
                expense.Participants[i].Amount = expense.Participants[i].Amount - dividedAmount;
            }

        }

    }
}
