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
            var A = new Person();

            var B = new Person();

            var C = new Person();

            var D = new Person();

            var exp = new Expense();

            A.AddExpense(new Expense { AmountSpent = 100, SpentBy = A, Participants = new[] { A, B, C, D } });
            B.AddExpense(new Expense { AmountSpent = 500, SpentBy = B, Participants = new[] {  C, D } });
            D.AddExpense(new Expense { AmountSpent = 300, SpentBy = B, Participants = new[] { A, B } });

            exp.Add(new Expense { AmountSpent = 100, SpentBy = A, Participants = new[] {A, B, C, D } });

            
        }
    }
}
