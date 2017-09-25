using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SplitWise;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void AddExpense_OwesAmountIsEqualToPartipantShare_BothShouldBeEqual()
        {
            var p1 = new Person();
            
            var p2 = new Person();
            var p3 = new Person();
            p3.Amount = 100;

            var expenseModel = new Expense { AmountSpent = 100, SpentBy = p3, Participants = new List<Person> { p1, p2 } };

            //Act
            var exp = new Expense();
            exp.AddExpense(expenseModel);

            //Assert
            Assert.IsTrue(exp.SpentBy.Amount.Equals(expenseModel.Participants.Sum(h => -h.Amount)));
        }
    }
}
