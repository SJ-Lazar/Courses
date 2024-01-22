using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue() => 
            Assert.That(new Reservation().CanBeCancelledBy(new User { IsAdmin = true }), Is.True);

        [Test]
        public void CanBeCancelledBy_SameUserCancellingTheReservation_ReturnsTrue()
        {
            var user = new User();
            var reservation = new Reservation() { MadeBy = user};
            Assert.IsTrue(reservation.CanBeCancelledBy(user));
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingTheReservation_ReturnsFalse()
        {
            var reservation = new Reservation() { MadeBy = new User()};
            Assert.IsFalse(reservation.CanBeCancelledBy(new User()));
        }
    }

    //TDD 
    // 1. Write a failing test
    // 2. Write the minimum amount of code to pass the test
    // 3. Refactor the code

    //Testable souce code 
    //simpler implementation
    //more readable
    //less prone to bugs

    //First Class Citizen
    //Clean,  readable, maintainable code
    //No Logic in the test (if, else, loop)

    //Test the outcome of a function 
    //Query =>  test the return value
    //Command => test teh outcome of the command

    //Dont test language features
    //Dont test third party code


    //Naming and Organize 
    //ProjectName.UnitTests
    //A Test class for each class in the production code
    
    //MethodName_Scenario_ExpectedBehavior
    //CanBeCancelledBy_UserIsAdmin_ReturnsTrue


}
