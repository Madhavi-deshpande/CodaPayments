using NUnit.Framework;
using LoadCSV;
using System;

namespace Tests
{
    [TestFixture]
    class PhoneNumberTests
    {
        [Test]
        public void PhoneNumberFormatCorrect()
        {
            //Arrange
            string number = "1234567890";

            // Act
            bool res = PhoneNumber.IsPhoneNbr(number);

            //Assert
            Console.WriteLine("test");

            Assert.IsTrue(res);
        }

        [Test]
        public void PhoneNumberFormatNotCorrect()
        {
            //Arrange
            string number = "abcd123";

            // Act
            bool res = PhoneNumber.IsPhoneNbr(number);

            //Assert

            Assert.IsFalse(res);
        }

    }
}
