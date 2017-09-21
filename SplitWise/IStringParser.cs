using System;

namespace SplitWise
{
    public interface IStringParser
    {
        Expense Parse(string statement);
    }

    class StringParser : IStringParser
    {
        public Expense Parse(string statement)
        {
            throw new NotImplementedException();
        }
    }
}