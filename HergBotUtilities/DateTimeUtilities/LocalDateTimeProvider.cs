using System;
using System.Collections.Generic;
using System.Text;

namespace HergBotUtilities.DateTimeUtilities
{
    public class LocalDateTimeProvider : IDateTimeProvider
    {
        public DateTime Now { get { return DateTime.Now; } }
    }
}
