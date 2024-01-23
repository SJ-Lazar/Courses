using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Fundamentals.Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Fundamentals.Math();
        }

        [Test]
        [Ignore("Because I wanted to!")]
        public void Add_WhenCalled_ReturnTheSumOfArguments() 
            => Assert.That(_math.Add(1, 2), Is.EqualTo(3));

        //[Test]
        //public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument() 
        //    => Assert.That(_math.Max(2, 1), Is.EqualTo(2));

        //[Test]
        //public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument() 
        //    => Assert.That(_math.Max(1, 2), Is.EqualTo(2));

        //[Test]
        //public void Max_ArgumentsAreEqual_ReturnTheSameArgument() 
        //    => Assert.That(_math.Max(1, 1), Is.EqualTo(1));

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a , int b, int expectedResult) 
            => Assert.That(_math.Max(a, b), Is.EqualTo(expectedResult));
    }
}
