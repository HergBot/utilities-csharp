using System;

namespace HergBotUtilities.DateTimeUtilities
{
    public interface IDateTimeProvider
    {
        DateTime Now { get; }
    }
}
