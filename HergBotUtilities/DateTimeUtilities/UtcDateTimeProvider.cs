﻿/*
* PROJECT: HergBot Utilities
* PROGRAMMER: Justin
* FIRST VERSION: 2019-06-02
*/

using System;

namespace HergBotUtilities.DateTimeUtilities
{
    public class UtcDateTimeProvider : IDateTimeProvider
    {
        public DateTime Now { get { return DateTime.UtcNow; } }
    }
}
