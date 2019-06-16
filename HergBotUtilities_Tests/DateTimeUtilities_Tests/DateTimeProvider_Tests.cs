/*
* PROJECT: HergBot Utilities
* PROGRAMMER: Justin
* FIRST VERSION: 2019-06-02
*/

using System;

using NUnit.Framework;

using HergBot.Utilities.DateTimeUtilities;

namespace HergBotUtilities_Tests.DateTimeUtilities_Tests
{
    public class DateTimeProvider_Tests
    {
        private IDateTimeProvider localProvider;

        private IDateTimeProvider utcProvider;

        [SetUp]
        public void SetUp()
        {
            localProvider = new LocalDateTimeProvider();
            utcProvider = new UtcDateTimeProvider();
        }

        [Test]
        public void CurrentDateTime_LocalDate()
        {
            Assert.AreEqual(DateTime.Now.Date, localProvider.Now.Date);
        }

        [Test]
        public void CurrentDateTime_LocalTime()
        {
            TimeSpan timeDifference = DateTime.Now - localProvider.Now;
            // Check if the time difference is less than one minute because we can't predict execution time
            bool lessThanOneMinuteApart = timeDifference.TotalMinutes == 0;
            Assert.IsTrue(lessThanOneMinuteApart);
        }

        [Test]
        public void CurrentDateTime_UtcDate()
        {
            Assert.AreEqual(DateTime.Now.ToUniversalTime().Date, utcProvider.Now.Date);
        }

        [Test]
        public void CurrentDateTime_UtcTime()
        {
            TimeSpan timeDifference = DateTime.UtcNow - utcProvider.Now;
            // Check if the time difference is less than one minute because we can't predict execution time
            bool lessThanOneMinuteApart = timeDifference.TotalMinutes == 0;
            Assert.IsTrue(lessThanOneMinuteApart);
        }
    }
}
