﻿using System;
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
    }


    public class StringParser : IStringParser
    {
        const string ignoreWord = "And";

        List<Person> GlobalPersons { get; set; }

        public StringParser()
        {
            GlobalPersons = new List<Person>();
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

        private Expense Parse(string statement)
        {
            try
            {
                string[] splittedText = statement.Split(' ');

                string personName = splittedText[0];
                double amount = double.Parse(splittedText[2]);

                var participants = new List<Person>();

                for (int i = 5; i < splittedText.Length; i++)
                {
                    if (!splittedText[i].Contains(ignoreWord))
                    {
                        AddToGlobalPeople(splittedText[i].TrimEnd(','));

                        participants.Add(GetPerson(splittedText[i].TrimEnd(',')));
                    }
                }

                return new Expense
                {
                    SpentBy = GetPerson(personName),
                    AmountSpent = amount,
                    Participants = participants,
                };
            }
            catch (FormatException)
            {
                throw new FormatException("The input is not still in valid format");
            }
            
        }

        Person GetPerson(string name)
        {
            var person = GlobalPersons.FirstOrDefault(h => h.Name == name);
            return person;
        }


        void AddToGlobalPeople(string name)
        {
            var person = GlobalPersons.FirstOrDefault(h => h.Name == name);

            if (person == null)
                GlobalPersons.Add(new Person { Name = name });
        }

    }
}