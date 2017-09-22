using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitWise
{
    public class Expense
    {
        public double AmountSpent { get; set; }

        public Person[] Participants { get; set; }



        //public void Add(Expense expense)
        //{
        //    SpentBy.Amount = expense.AmountSpent; 
        //    double dividedAmount = expense.AmountSpent / expense.Participants.Count();

        //    for (int i = 0; i < expense.Participants.Length; i++)
        //    {
        //        expense.Participants[i].Amount = expense.Participants[i].Amount - dividedAmount;
        //    }
        //}

    }
}
