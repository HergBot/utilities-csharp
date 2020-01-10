/*
* PROJECT: HergBot Utilities
* PROGRAMMER: Justin
* FIRST VERSION: 2020-01-10
*/

using System;

using NUnit.Framework;

using HergBot.Utilities.ExceptionUtilities;

namespace HergBotUtilities_Tests.ExceptionUtilities_Tests
{
    class ExceptionUtilities_Tests
    {
        private const string TEST_MESSAGE = "Message.";

        [Test]
        public void GetAllExceptionMessages_WithNullException_ReturnsEmptyString()
        {
            Assert.AreEqual(string.Empty, ExceptionUtilities.GetAllExceptionMessages(null));
        }

        [Test]
        public void GetAllExceptionMessages_WithOneException_ReturnsMessage()
        {
            Exception ex = new Exception(TEST_MESSAGE);
            Assert.AreEqual(TEST_MESSAGE, ExceptionUtilities.GetAllExceptionMessages(ex));
        }

        [Test]
        public void GetAllExceptionMessages_WithMultipleExceptions_ReturnsJoinedString()
        {
            Exception inner = new Exception(TEST_MESSAGE);
            Exception ex = new Exception(TEST_MESSAGE, inner);
            Assert.AreEqual(string.Join(" ", TEST_MESSAGE, TEST_MESSAGE), ExceptionUtilities.GetAllExceptionMessages(ex));
        }
    }
}
