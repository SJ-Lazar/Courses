using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments() 
            => Assert.That(new Fundamentals.Math().Add(1, 2), Is.EqualTo(3));

        [Test]
        public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument() 
            => Assert.That(new Fundamentals.Math().Max(2, 1), Is.EqualTo(2));

        [Test]
        public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument() 
            => Assert.That(new Fundamentals.Math().Max(1, 2), Is.EqualTo(2));

        [Test]
        public void Max_ArgumentsAreEqual_ReturnTheSameArgument() 
            => Assert.That(new Fundamentals.Math().Max(1, 1), Is.EqualTo(1));


    }
}
