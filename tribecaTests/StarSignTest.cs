using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using tribeca;

namespace tribecaTests;

[TestClass]
public class StarSignTest
{
    [TestMethod]
    public void StarSigns()
    {
        var person = new Person();
        var dob = Convert.ToDateTime("1984-12-29");
        person.DateOfBirth = dob;

        var starsign = person.GetStarSign();

        Assert.AreEqual(starsign, StarSign.StarSigns.Capricorn.ToString());
    }
}
