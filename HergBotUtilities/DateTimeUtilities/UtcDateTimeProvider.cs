using System;

namespace HergBotUtilities.DateTimeUtilities
{
    public class UtcDateTimeProvider : IDateTimeProvider
    {
        public DateTime Now { get { return DateTime.UtcNow; } }
    }
}
