using System;
using System.Text.RegularExpressions;

namespace SplitWise
{
    public interface IStringParser
    {
        Expense Parse(string statement);
    }

    public class StringParser : IStringParser
    {
        const string s = "A spent 100 snacks for A, B, C, And D";
        const string g = "B spent 100 snacks for C And D";

        public Expense Parse(string statement)
        {
            //Regex.Split(s,)

            string[] splittedText = s.Split(' ');

            var name = splittedText[0];
            var amount = splittedText[2];


            return null;
        }
    }
}