using Moq;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonTest
{
    [Test]
    public void AGeneratedTicketHasTheCorrectName()
    {
        Person person = new Person { FirstName = "Bob", LastName = "Smith", Age = 18 };

        Mock<IPersonNameCleaner> _mockCleaner = new Mock<IPersonNameCleaner>();
        //_mockCleaner.Setup(m => m.Clean(It.IsAny<Person>()))
        //        .Callback(() => person.FirstName = "B");

        _mockCleaner.Setup(m => m.Clean(It.IsAny<Person>()))
               .Callback<Person>(p => p.FirstName = p.FirstName[0].ToString());

        TicketGenerator generator = new TicketGenerator(_mockCleaner.Object);

        Ticket ticket = generator.GenerateTicket(person);

        Assert.AreEqual("B Smith", ticket.Name);
    }
}
