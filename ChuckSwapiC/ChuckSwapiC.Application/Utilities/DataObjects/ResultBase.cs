using System;
using System.Collections.Generic;
using System.Text;

namespace ChuckSwapiC.Application.Utilities.DataObjects
{
    public class ResultBase
    {
        private readonly bool success;
        private readonly string message;
        private readonly IEnumerable<object> payload;

        public ResultBase(bool success, string message, IEnumerable<object> payload)
        {
            this.success = success;
            this.message = message;
            this.payload = payload;
        }

        public bool Success => success;

        public string Message => message;

        public IEnumerable<object> Payload => payload;
    }
}
