using System;
using System.Collections.Generic;
using System.Linq;

namespace SplitWise
{
    /// <summary>
    /// String parser
    /// </summary>
    public interface IStringParser
    {
        /// <summary>
        /// Parse expenses
        /// </summary>
        /// <param name="statements"></param>
        /// <returns></returns>
        List<Expense> Parse(IList<string> statements);
        Expense Parse(string statement);
    }

    public class StringParser : IStringParser
    {
        const string omitWord = "And";

        public List<Person> Persons { get; set; }

        public StringParser()
        {
            Persons = new List<SplitWise.Person>();
        }

        /// <summary>
        /// Parse expenses
        /// </summary>
        /// <param name="statements"></param>
        /// <returns></returns>
        public List<Expense> Parse(IList<string> statements)
        {
            var expenses = new List<Expense>();
            foreach (var statement in statements)
            {
                expenses.Add(Parse(statement));
            }

            return expenses;
        }

        public Expense Parse(string statement)
        {
            string[] splittedText = statement.Split(' ');

            string personSpent = splittedText[0];
            double amount = double.Parse(splittedText[2]);

            var persons = new List<Person>();
            for (int i = 5; i < splittedText.Length; i++)
            {
                if (!splittedText[i].Contains(omitWord))
                {
                    persons.Add(FindPersonByName(persons, splittedText[i].TrimEnd(',')));
                }

            }

            return new Expense
            {
                SpentBy = FindPersonByName(persons, personSpent),
                AmountSpent = amount,
                Participants = persons,

            };
        }

        Person FindPersonByName(List<Person> Persons, string name)
        {
            var person = Persons.FirstOrDefault(h => h.Name == name);

            if (person == null)
                return new Person { Name = name };

            return person;
        }


        Person FindPersonByName(string name)
        {
            var person = Persons.FirstOrDefault(h => h.Name == name);

            if (person == null)
                return new Person { Name = name };

            return person;
        }

    }
}