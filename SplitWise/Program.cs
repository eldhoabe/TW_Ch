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

            const string filePath = @"D:\A.txt";


            var s = new StringParser();
            s.Parse("fds");

            var A = new Person();
            A.Name = "A";

            var B = new Person();
            B.Name = "B";

            var C = new Person();
            C.Name = "C";

            var D = new Person();
            D.Name = "D";

            var E = new Person();
            E.Name = "E";
            //var exp = new Expense();

            A.AddExpense(new Expense { AmountSpent = 100,  Participants = new[] { A, B,C,D,E } });
            B.AddExpense(new Expense { AmountSpent = 500,  Participants = new[] { C, D } });
            //D.AddExpense(new Expense { AmountSpent = 300,  Participants = new[] { A, B } });



            Person[] persons = new[] { A, B, C, D,E };

            foreach (var item in persons)
            {
                item.ToString();
                Console.WriteLine(item.ToString() +"  " +item.ShowOutStanding());
            }

            Console.ReadKey();

        }
    }
}
