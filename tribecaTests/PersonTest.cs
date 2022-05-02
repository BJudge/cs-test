using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using tribeca;

namespace tribecaTests;

[TestClass]
public class PersonTest
{
    [TestMethod]
    public void AgeofPerson()
    {
        var bday = Convert.ToDateTime("1984-12-29");
        var person = new Person();

        Assert.AreEqual(person.CalculateAge(bday), 37);
    }

    [TestMethod]
    public void LastNameOfPerson()
    {
        var person = new Person();
        var lastName = "Judge";
        person.Surname = lastName;

        Assert.AreEqual(person.Surname, "Judge");
    }

    [TestMethod]
    public void DateOfBirth()
    {
        var person = new Person();
        var bday = Convert.ToDateTime("1984-12-29");
        person.DateOfBirth = bday;

        Assert.AreEqual(person.DateOfBirth, bday);
    }

}
