using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestConsoleUI.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Moq;

    [TestClass]
    public class TestTicketGenerator
    {
        [TestMethod]
        public void TestTicket()
        {
            Person person = new Person { FirstName = "Bob", LastName = "Smith", Age = 18 };

            Mock<IPersonNameCleaner> _mockCleaner = new Mock<IPersonNameCleaner>();

            var ticketGenerator = new TicketGenerator(_mockCleaner.Object);

            var ticket = ticketGenerator.GenerateTicket(person);

            Assert.AreEqual("B Smith", ticket.Name);
        }

        [TestMethod]
        public void TestTicketWithCallback()
        {
            Person person = new Person { FirstName = "Bob", LastName = "Smith", Age = 18 };

            Mock<IPersonNameCleaner> _mockCleaner = new Mock<IPersonNameCleaner>();
            _mockCleaner.Setup(m => m.Clean(It.IsAny<Person>()))
                .Callback(() => person.FirstName = "B");

            var ticketGenerator = new TicketGenerator(_mockCleaner.Object);

            var ticket = ticketGenerator.GenerateTicket(person);

            Assert.AreEqual("B Smith", ticket.Name);
        }

        [TestMethod]
        public void TestTicketWithCallbackParameter()
        {
            Person person = new Person { FirstName = "Bob", LastName = "Smith", Age = 18 };

            Mock<IPersonNameCleaner> _mockCleaner = new Mock<IPersonNameCleaner>();
            _mockCleaner.Setup(m => m.Clean(It.IsAny<Person>()))
                .Callback<Person>(p => p.FirstName = p.FirstName[0].ToString());

            var ticketGenerator = new TicketGenerator(_mockCleaner.Object);

            var ticket = ticketGenerator.GenerateTicket(person);

            Assert.AreEqual("B Smith", ticket.Name);
        }
    }
}
