using System;
using System.Collections.Generic;
using System.Text;

namespace RegexProgram
{
    /// <summary>
    /// Exception is an inbuilt class here
    /// Exception happens runtime 
    /// </summary>
    class InvalidUserDetailsException : Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRST_NAME,
            INVALID_LAST_NAME,
            INVALID_EMAIL,
            INVALID_MOBILE_NUMBER,
            INVALID_PASSWORD
        }
        public ExceptionType type;
        /// <summary>
        /// creating a constructor and passing exception type and message in it
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        public InvalidUserDetailsException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
