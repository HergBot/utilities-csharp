/*
* PROJECT: HergBot Utilities
* PROGRAMMER: Justin
* FIRST VERSION: 2019-06-03
*/

using NUnit.Framework;

using HergBot.Utilities.EnvironmentUtilities;

namespace HergBotUtilities_Tests.EnvironmentUtilities_Tests
{
    public class OperatingSystemUtilities_Tests
    {
        [Test]
        public void OperatingSystem_IsWindows()
        {
            Assert.IsTrue(OperatingSystemUtilities.IsWindows());
        }

        [Test]
        public void OperatingSystem_IsLinux()
        {
            Assert.IsFalse(OperatingSystemUtilities.IsLinux());
        }
    }
}
