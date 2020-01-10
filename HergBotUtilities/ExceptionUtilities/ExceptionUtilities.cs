using System;
using System.Collections.Generic;
using System.Text;

namespace HergBot.Utilities.ExceptionUtilities
{
    public class ExceptionUtilities
    {
        /// <summary>
        /// Returns a single string of the exception and all inner exceptions.
        /// </summary>
        /// <param name="exception">The exception to traverse through</param>
        /// <returns>A joined string of all the exceptions messages</returns>
        public static string GetAllExceptionMessages(Exception exception)
        {
            if (exception == null)
            {
                return string.Empty;
            }
            if (exception.InnerException != null)
            {
                return string.Join(" ", exception.Message, GetAllExceptionMessages(exception.InnerException));
            }
            return exception.Message;
        }
    }
}
