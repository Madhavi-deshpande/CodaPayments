using NUnit.Framework;
using LoadCSV;
using System;

namespace Tests
{
    [TestFixture]
    class EmailTests
    {
        [Test]
        public void EmailFormatCorrect()
        {
            //Arrange
            string email = "abc@gmail.com";

            // Act
            bool res = EMail.IsEmail(email);

            //Assert
            Console.WriteLine("test");

            Assert.IsTrue(res);
        }

        [Test]
        public void EmailFormatNotCorrect()
        {
            //Arrange
            string email = "@gmailabcd123";

            // Act
            bool res = EMail.IsEmail(email);

            //Assert

            Assert.IsFalse(res);
        }

    }
}
