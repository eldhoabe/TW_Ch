using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitWise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputs = new List<string>
            {
                "A spent 100 snacks for A, B, C, And D",
                "B spent 500 snacks for C And D",
                "D spent 300 snacks for A And B",
            };


            IStringParser parser = new StringParser();
            List<Expense> expenses = parser.Parse(inputs);

            foreach (var expense in expenses)
            {
                expense.AddExpense(expense);
            }


            var persons = expenses.SelectMany(h => h.Participants.Select(p => p)).Distinct();

            foreach (var person in persons)
            {
                Console.WriteLine(person.ShowOutStanding());
            }

            Console.ReadKey();

        }
    }
}
