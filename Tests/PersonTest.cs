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
            var particpant1 = new Person();
            var particpant2 = new Person();
            var spender = new Person();
            

            var expenseModel = new Expense { AmountSpent = 100, SpentBy = spender, Participants = new List<Person> { particpant1, particpant2 } };

            //Act
            var exp = new Expense();
            exp.AddExpense(expenseModel);

            //Assert
            Assert.IsTrue(exp.SpentBy.Amount.Equals(expenseModel.Participants.Sum(h => -h.Amount)));
        }


        [TestMethod]
        public void AddExpense_ParticipantAndSpenderInList_BothShouldBeEqual1()
        {
            var particpant1 = new Person();
            var particpant2 = new Person();

            var spender = new Person();

            var expenseModel = new Expense { AmountSpent = 10, SpentBy = spender, Participants = new List<Person> { particpant1, particpant2 ,spender} };

            //Act
            var exp = new Expense();
            exp.AddExpense(expenseModel);

            //Assert
            Assert.IsTrue(exp.SpentBy.Amount.Equals(expenseModel.Participants.Sum(h => -h.Amount)));
        }
    }
}
