using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitWise
{
    public class Transaction
    {
        public Person SpentBy { get; set; }
        public double AmountSpent { get; set; }
        public Person[] Particpiants { get; set; }



        public void AddTransaction(Transaction transaction)
        {
            
            double dividedAmount = transaction.SpentBy.Amount / transaction.Particpiants.Count();

            foreach (var particpant in transaction.Particpiants)
            {
                particpant.Amount = particpant.Amount - dividedAmount;
            }
        }
    }
}
