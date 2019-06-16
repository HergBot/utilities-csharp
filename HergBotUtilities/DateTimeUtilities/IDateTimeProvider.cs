/*
* PROJECT: HergBot Utilities
* PROGRAMMER: Justin
* FIRST VERSION: 2019-06-02
*/

using System;

namespace HergBot.Utilities.DateTimeUtilities
{
    public interface IDateTimeProvider
    {
        DateTime Now { get; }
    }
}
