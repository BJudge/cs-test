using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using tribeca;

namespace tribecaTests;

[TestClass]
public class UtilitiesTest
{
    [TestMethod]
    public void PrivateNameTest()
    {
        var person = new Person();
        var name = "Bart";
        person.Name = name;

        var privateName = Utilities.GetPersonName(person);

        Assert.AreEqual(privateName, name);
    }
}
