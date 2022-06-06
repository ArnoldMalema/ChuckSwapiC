using System;
using System.Collections.Generic;

namespace ChuckSwapiC.Application.Utilities.ExtensionMethods
{
    public static class ExceptionExtensions
    {
        public static List<string> GetExceptionMessageChain(this Exception exception)
        {
            var errorChain = new List<string>();
            errorChain.Add($"{exception.GetType().Name}: {exception.Message}");
            var innerException = exception.InnerException;
            while (innerException != null)
            {
                errorChain.Add($"{innerException.GetType().Name}: {innerException.Message}");
                innerException = innerException.InnerException;
            }
            errorChain.Reverse();
            errorChain.Add($"Stack: {exception.StackTrace}");
            return errorChain;
        }
    }
}