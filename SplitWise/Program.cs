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



            foreach (var item in expenses)
            {
                item.AddExpense(item);
            }


            var peoples = expenses.SelectMany(h => h.Participants.Select(p => p)).Distinct();

            foreach (var item in peoples)
            {
                Console.WriteLine(item.ShowOutStanding());
            }

            Console.ReadKey();

        }
    }
}
