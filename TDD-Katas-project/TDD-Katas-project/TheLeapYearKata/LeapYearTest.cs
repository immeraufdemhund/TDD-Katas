﻿using NUnit.Framework;

namespace TDD_Katas_project.The_LeapYear_Kata
{
    [TestFixture]
    [Category("The LeapYear")]
    public class LeapYearTest
    {
        [Test]
        public void CanTestForLeapYear()
        {
            Assert.That(true, Is.EqualTo(LeapYear.IsLeapYear(1996)));
        }

        [Test]
        [TestCase(false, 2013)]
        [TestCase(false, 2001)]
        [TestCase(true, 1996)]
        [TestCase(true, 1992)]
        public void CanTestForLeapYears(bool expectedResult, int year)
        {
            Assert.That(expectedResult, Is.EqualTo(LeapYear.IsLeapYear(year)));
        }
    }
}
