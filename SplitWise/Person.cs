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

        public string Name { get; set; }

        readonly IStringParser _stringParser;

        public void AddExpense(Expense expense)
        {
            Amount = Amount + expense.AmountSpent;

            var dividedAmount = expense.AmountSpent / expense.Participants.Count();

            for (int i = 0; i < expense.Participants.Count; i++)
            {
                expense.Participants[i].Amount = expense.Participants[i].Amount - dividedAmount;
            }
        }

        public string ShowOutStanding()
        {
            if (Amount < 0)
            {
                return string.Format("{0} Has to give {1}", Name, -Amount);
            }
            else
            {
                return string.Format("{0} Gets {1}", Name, Amount);
            }
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            var person = obj as Person;

            return person.Name.Equals(this.Name, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
