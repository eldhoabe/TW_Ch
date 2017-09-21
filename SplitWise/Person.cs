using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitWise
{
    public class Person
    {
        public double Amount { get; set; }

        readonly IStringParser _stringParser;

        
        public void AddExpense(string statement)
        {
            Expense expense = _stringParser.Parse(statement);

        }

        public void AddExpense(Expense expense)
        {
            Amount = Amount + expense.AmountSpent;

            var dividedAmount = expense.AmountSpent / expense.Participants.Count();

            for (int i = 0; i < expense.Participants.Length; i++)
            {
                expense.Participants[i].Amount = expense.Participants[i].Amount - dividedAmount;
            }
        }
    }
}
