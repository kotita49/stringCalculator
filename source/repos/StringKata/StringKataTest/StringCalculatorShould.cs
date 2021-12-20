using NUnit.Framework;
using StringKata;
using System;

namespace StringKataTest
{
    public class StringCalculatorShould

    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestEmptyString()
        {
            StringCalculator stringCalculator = new StringCalculator();

            Assert.AreEqual(0, stringCalculator.Add(""));
           
        }

        [Test]
        public void Test1ormoreNumbers()
        {
            StringCalculator stringCalculator = new StringCalculator();
            Assert.AreEqual(1, stringCalculator.Add("1"));
            Assert.AreEqual(3, stringCalculator.Add("1,2"));
            Assert.AreEqual(6, stringCalculator.Add("1,2,3"));
            Assert.AreEqual(23, stringCalculator.Add("1,2,3,4,6,7"));
           
        }
        [Test]
        public void TestNewLinesSeparators()
        {
            StringCalculator stringCalculator = new StringCalculator();
            
            Assert.AreEqual(6, stringCalculator.Add("1\n2, 3"));
        }
        [Test]
        public void TestDifferentDelimiter()
        {
            StringCalculator stringCalculator = new StringCalculator();
            Assert.AreEqual(3, stringCalculator.Add("//;\n1;2"));
        }
        [Test]
        public void TestNegatives()
        {
            StringCalculator stringCalculator = new StringCalculator();
            Assert.Throws<Exception>(()=> stringCalculator.Add("-1,2"));
            Assert.Throws<Exception>(()=> stringCalculator.Add("-1,-2,3"));
            Assert.Throws<Exception>(()=> stringCalculator.Add("2,-4,-2,3"));
        }
        [Test]
        public void TestOver1000Ignored()
        {
            StringCalculator stringCalculator = new StringCalculator();
            Assert.AreEqual(2, stringCalculator.Add("//;\n1001;2"));
        }
    }
}