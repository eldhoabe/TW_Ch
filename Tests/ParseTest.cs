using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using SplitWise;

namespace Tests
{
    [TestClass]
    public class ParseTest
    {
        [TestMethod]
        public void Parse_InputIsValid_ValidExpense()
        {
            var list = new List<string> { "A spent 100 snacks for A, B, C, And D" };
            var parser = new StringParser();
            var particpants = new List<string> { "A", "B", "C", "D" };

            //Act 
            var expenses = parser.Parse(list);


            //Assert
            Assert.IsTrue(expenses[0].SpentBy.Name.Equals("A"), "Spent by is invalid");
            Assert.IsTrue(expenses[0].AmountSpent.Equals(100), "Spent amount is invalid");

            foreach (var person in expenses[0].Participants)
            {
                Assert.IsTrue(particpants.Contains(person.Name));
            }
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException), "Invalid input format exception is not thrown")]
        public void Parse_InvalidInput_ExceptionThrown()
        {
            var list = new List<string> { "A spent hundred snacks for A, B, C, And D" };
            var parser = new StringParser();

            //Act 
            var expenses = parser.Parse(list);


            //Assert by exception
        }
    }
}
