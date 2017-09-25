using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitWise
{
    public class TransactionManager
    {
        List<Transaction> _transactions;

        List<Person> _persons; 

        public Person A = new Person();

        public Person B = new Person();

        public Person C = new Person();

        public Person D = new Person();

        public TransactionManager()
        {
            _transactions = new List<Transaction>();
            _transactions.Add(new Transaction { AmountSpent = 100, Particpiants = new[] { A,B,C,D }, SpentBy = A});
            _transactions.Add(new Transaction { AmountSpent = 500, Particpiants = new[] { C, D }, SpentBy = B });
            _transactions.Add(new Transaction { AmountSpent = 300, Particpiants = new[] { B, D }, SpentBy = C });
        }

        public void AddTransaction()
        {
            var transaction = new Transaction();

            foreach (var item in _transactions)
            {
                transaction.AddTransaction(item);
            }
        }

    }
}
