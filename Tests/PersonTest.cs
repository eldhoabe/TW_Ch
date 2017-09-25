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
        public void ShowOutstanding_NegativeAmount_ShowOwesMessage()
        {
            var person = new Person();
            person.Name = "A";
            person.Amount = -75;

            string expectedMessge = string.Format("{0} Has to give {1}", person.Name, -person.Amount);
            
            //Act
            string message = person.ShowOutStanding();

            //Assert
            Assert.AreEqual(expectedMessge, message, "Failed to return expected message");
        }

        [TestMethod]
        public void ShowOutstanding_PositiveAmount_ShowOwesMessage()
        {
            var person = new Person();
            person.Name = "A";
            person.Amount = 75;

            string expectedMessge = string.Format("{0} Gets {1}", person.Name, person.Amount);

            //Act
            string message = person.ShowOutStanding();

            //Assert
            Assert.AreEqual(expectedMessge, message, "Failed to return expected message");
        }
    }
}
