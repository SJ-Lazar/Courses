using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue() => 
            Assert.IsTrue(new Reservation().CanBeCancelledBy(new User { IsAdmin = true }));

        [TestMethod]
        public void CanBeCancelledBy_SameUserCancellingTheReservation_ReturnsTrue()
        {
            var user = new User();
            var reservation = new Reservation() { MadeBy = user};
            Assert.IsTrue(reservation.CanBeCancelledBy(user));
        }

        [TestMethod]
        public void CanBeCancelledBy_AnotherUserCancellingTheReservation_ReturnsFalse()
        {
            var reservation = new Reservation() { MadeBy = new User()};
            Assert.IsFalse(reservation.CanBeCancelledBy(new User()));
        }
    }
}
